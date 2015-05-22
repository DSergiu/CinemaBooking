namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Linq;

    public partial class CinemaApp      // Halls
    {
        private Color[]  SeatMapLegend     = new  Color[] { Color.White,   Color.Blue,  Color.Purple };
        private string[] SeatMapLegendText = new string[] { "Unavailable", "Available", "Wheelchair" };

        private void FirstLoad_Halls() 
        {
            GetHallsFromDB();
        }


        async private void GetHallsFromDB()
        {
            try
            {
                Info_Loading_Show("Getting a list of halls...");
                ICollection<Hall> halls = await CinemaClient.Client.GetAllHallsAsync();
                Grid_Hall.Rows.Clear();

                foreach (var hall in halls)  AddRow(hall);

                Grid_Hall.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                Info_Hide();
                HandleException(ex);
            }
        }

        private void AddRow(Hall hall)
        {
            var index = Grid_Hall.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_Hall.Rows[index];
            row.Cells[0].Value = hall.HallId;
            row.Cells[1].Value = hall.HallName;
        }



        private void Hall_Button_Insert_Click(object sender, EventArgs e)
        {
            Hall hallToInsert = GetHallDataFromFields();

            try
            {
                hallToInsert.HallId = CinemaClient.Client.CreateHall(hallToInsert);
                AddRow(hallToInsert);

                Info_Right_Show(String.Format("The Hall ({0}) was successfully inserted.", hallToInsert.HallId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Hall_Button_Update_Click(object sender, EventArgs e)
        {
            Hall hallToUpdate = GetHallDataFromFields();

            if (hallToUpdate.HallId <= 0)
            {
                Info_Wrong_Show("You didn't select a hall row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateHall(hallToUpdate, hallToUpdate.HallId.ToString());
                Grid_Hall.Rows.RemoveAt(Grid_Hall.SelectedRows[0].Index);
                AddRow(hallToUpdate);

                Info_Right_Show(String.Format("The Hall ({0}) was successfully updated.", hallToUpdate.HallId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Hall_Button_Clear_Click(object sender, EventArgs e)
        {
            Hall_Textbox_ID.Text = "auto";
            Hall_Textbox_Name.Text = "";

            Hall_Button_Update.Visible = false;
            Hall_Button_Insert.Visible = true;

            Grid_Hall.ClearSelection();
        }


        private void ShowSeatsLegend() 
        {
            Control[] controls = new Control[2 * SeatMapLegend.Length];

            for (int i = 0; i < SeatMapLegend.Length; i++)
            {
                PictureBox legendPic = new PictureBox();
                Label legendText = new Label();

                legendPic.BackColor = SeatMapLegend[i];
                legendText.Text     = SeatMapLegendText[i];

                legendPic.Width = 30;
                legendPic.Height = 30;

                legendPic.Left = i * legendPic.Width + 10;
                legendText.Left = legendPic.Left;

                legendPic.Click += LegendItem_Click;
                
                controls[2 * i]     = legendPic;
                controls[2 * i + 1] = legendText;
            }

            Hall_Seat_Seats_Legend.Controls.AddRange(controls);

            InitializeSeatDesigner();
        }


        private void InitializeSeatDesigner()
        {
            Grid_Seats.ColumnCount = 25;
            Grid_Seats.RowCount = 20;

            for (int i = 1; i < Grid_Seats.ColumnCount;i++ )
                Grid_Seats.Rows[0].Cells[i].Value = (i - 1);


            for (int i = 1; i < Grid_Seats.RowCount; i++)
            {
                Grid_Seats.Rows[i].Cells[0].Value = (char)('A'+i-1);
            }
        }

        private bool mouseDOWN;

        private void Grid_Seats_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDOWN = true;
        }

        private void Grid_Seats_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDOWN = false;
        }

        private void Grid_Seats_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (mouseDOWN && e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                ChangeSeat(e.RowIndex, e.ColumnIndex);               
            }
        }

        private void Grid_Seats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                ChangeSeat(e.RowIndex, e.ColumnIndex);
            }
        }


        private void ChangeSeat(int row, int column) 
        {
            try
            {
                int colorindex = GetSeatIndexByColor(selectedLegendColor);
                int hallId = (int)Grid_Hall.Rows[Grid_Hall.SelectedRows[0].Index].Cells[0].Value;
                SeatType seatValue = (SeatType)colorindex;
                Seat seat = new Seat { Row = row, Column = column, HallId = hallId, Value = seatValue };

                CinemaClient.Client.UpdateSeatAsync(seat);

                Info_Hide();

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = selectedLegendColor;
                Grid_Seats.Rows[row].Cells[column].Style = style;                                
            }
            catch(Exception)
            {
                Info_Wrong_Show(String.Format("An error occurred while delecting a seat ....."));
            }
            
        }

        private void Grid_Seats_SelectionChanged(object sender, EventArgs e)
        {
            Grid_Seats.ClearSelection();    // disable select cell selection color
        }

        private Color selectedLegendColor = Color.White;
        private void LegendItem_Click(object sender, EventArgs e) 
        {
            selectedLegendColor = ((PictureBox)sender).BackColor;
        }
        


        private int GetSeatIndexByColor(Color col) 
        {
            for (int i = 0; i < SeatMapLegend.Length; i++)
                if (SeatMapLegend[i].Equals(col))
                    return i;
            return -1;
        }

        private void GridSeats_Clear() 
        {
            for (int i = 1; i < Grid_Seats.RowCount; i++)
                for (int j = 1; j < Grid_Seats.ColumnCount; j++)
                {
                    Grid_Seats.Rows[i].Cells[j].Style.BackColor = SeatMapLegend[(int)SeatType.NoSeat];
                }
        }

        private void SelectedHall_ShowSeats(Hall hall) 
        {
            GridSeats_Clear();

            foreach(var seat in hall.Seats)
            {
                try {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = SeatMapLegend[(int)seat.Value];
                    Grid_Seats.Rows[seat.Row].Cells[seat.Column].Style = style;
                } catch{}
            }
        }

        private void Grid_Hall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try  {
                Hall hall = CinemaClient.Client.GetHall(Grid_Hall.Rows[e.RowIndex].Cells[0].Value.ToString());

                Hall_Textbox_ID.Text = hall.HallId.ToString();
                Hall_Textbox_Name.Text = hall.HallName;

                SelectedHall_ShowSeats(hall);

                Hall_Button_Insert.Visible = false;
                Hall_Button_Update.Visible = true;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Grid_Hall_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_Hall.Rows[e.RowIndex].Selected = true;
        }


        private void Grid_Hall_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Hall Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteHall(Grid_Hall.Rows[Grid_Hall.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Hall was successfully deleted."));
                }
                catch (Exception ex)
                {
                    HandleException(ex);

                    e.Cancel = true;     //cancel this operation
                }
                
            }
            else
            {
                e.Cancel = true; //cancel this operation
            }
        }




        private Hall GetHallDataFromFields() 
        {
            int id = 0;
            try
            {
                id = Int32.Parse(Hall_Textbox_ID.Text);
            }
            catch {}

            string hallname = Hall_Textbox_Name.Text;

            Hall hall = new Hall
            {
                HallId = id,
                HallName = hallname
            };

            return hall;
        }
    }
}
