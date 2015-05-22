namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // Screening
    {
        private void FirstLoad_Screening() 
        {
            GetScreeningsFromDB(0, 10);
        }


        async private void GetScreeningsFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of screening informations...");
                ICollection<Screening> screenings = await CinemaClient.Client.GetScreeningsPerPageAsync(page.ToString(), noperpage.ToString());
                Grid_Screening.Rows.Clear();

                foreach (var screening in screenings)
                    AddRow(screening);

                Grid_Screening.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void AddRow(Screening screening)
        {
            var index = Grid_Screening.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_Screening.Rows[index];
            row.Cells[0].Value = screening.ScreeningId;
            row.Cells[1].Value = screening.ScreeningInfoId;
            row.Cells[2].Value = screening.ScreeningDateTime;
        }



        private void Screenings_Button_Insert_Click(object sender, EventArgs e)
        {
            Screening screeningToInsert = GetScreeningDataFromFields();

            try
            {
                screeningToInsert.ScreeningId = CinemaClient.Client.CreateScreening(screeningToInsert);
                AddRow(screeningToInsert);

                Info_Right_Show(String.Format("The Screening Info ({0}) was successfully inserted.", screeningToInsert.ScreeningId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Screenings_Button_Update_Click(object sender, EventArgs e)
        {
            Screening screeningToUpdate = GetScreeningDataFromFields();

            if (screeningToUpdate.ScreeningId == 0)
            {
                Info_Wrong_Show("You didn't select a screening row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateScreening(screeningToUpdate, screeningToUpdate.ScreeningId.ToString());
                Grid_Screening.Rows.RemoveAt(Grid_Screening.SelectedRows[0].Index);
                AddRow(screeningToUpdate);
                Info_Right_Show(String.Format("The Screening ({0}) was successfully updated.", screeningToUpdate.ScreeningId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Screenings_Button_Clear_Click(object sender, EventArgs e)
        {
            Screening_Textbox_ID.Text = "auto";
            Screening_Textbox_ScreeningInfoId.Value = 0;
            Screening_Date.Value = DateTime.UtcNow;

            Screenings_Button_Update.Visible = false;
            Screenings_Button_Insert.Visible = true;

            Grid_Screening.ClearSelection();
        }

        private void Grid_Screening_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Screening screening = CinemaClient.Client.GetScreening(Grid_Screening.Rows[e.RowIndex].Cells[0].Value.ToString());

                Screening_Textbox_ID.Text = screening.ScreeningInfoId.ToString();
                Screening_Textbox_ScreeningInfoId.Value = screening.ScreeningInfoId;
                Screening_Date.Value = screening.ScreeningDateTime;

                Screenings_Button_Insert.Visible = false;
                Screenings_Button_Update.Visible = true;
            }
            catch { }
        }


        private void Grid_Screening_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_Screening.Rows[e.RowIndex].Selected = true;
        }  


        private void Grid_Screening_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Screening Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteScreening(Grid_Screening.Rows[Grid_Screening.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Screening was successfully deleted."));
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

        private Screening GetScreeningDataFromFields() 
        {
            int id = 0;
            try
            {
                id = Int32.Parse(Screening_Textbox_ID.Text);
            }
            catch {}


            int screeninginfoid = (int)Screening_Textbox_ScreeningInfoId.Value;
            DateTime screeningdatetime = Screening_Date.Value;

            Screening screening = new Screening
            {
                ScreeningId = id,
                ScreeningInfoId = screeninginfoid,
                ScreeningDateTime = screeningdatetime
            };

            return screening;
        }
    }
}
