namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // ScreeningInfo
    {
        private void FirstLoad_ScreeningInfo() 
        {
            GetScreeningsInfoFromDB(0, 10);
        }


        async private void GetScreeningsInfoFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of screening informations...");

                ICollection<ScreeningInfo> screeninginfos = await CinemaClient.Client.GetScreeningInfosByPageAsync(page.ToString(), noperpage.ToString());
                Grid_ScreeningInfo.Rows.Clear();

                foreach (var screeninginfo in screeninginfos)
                    AddRow(screeninginfo);

                Grid_ScreeningInfo.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void AddRow(ScreeningInfo screeninginfo)
        {
            var index = Grid_ScreeningInfo.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_ScreeningInfo.Rows[index];
            row.Cells[0].Value = screeninginfo.ScreeningInfoId;
            row.Cells[1].Value = screeninginfo.MovieId;
            row.Cells[2].Value = screeninginfo.HallId;
            row.Cells[3].Value = screeninginfo.TicketPrice;
        }



        private void ScreeningInfo_Button_Insert_Click(object sender, EventArgs e)
        {
            ScreeningInfo screeninginfoToInsert = GetScreeningInfoDataFromFields();

            try
            {
                screeninginfoToInsert.ScreeningInfoId = CinemaClient.Client.CreateScreeningInfo(screeninginfoToInsert);
                AddRow(screeninginfoToInsert);

                Info_Right_Show(String.Format("The Screening Info ({0}) was successfully inserted.", screeninginfoToInsert.ScreeningInfoId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void ScreeningInfo_Button_Update_Click(object sender, EventArgs e)
        {
            ScreeningInfo screeninginfoToUpdate = GetScreeningInfoDataFromFields();

            if (screeninginfoToUpdate.ScreeningInfoId == 0)
            {
                Info_Wrong_Show("You didn't select a screening info row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateScreeningInfo(screeninginfoToUpdate, screeninginfoToUpdate.ScreeningInfoId.ToString());
                Grid_ScreeningInfo.Rows.RemoveAt(Grid_ScreeningInfo.SelectedRows[0].Index);
                AddRow(screeninginfoToUpdate);
                Info_Right_Show(String.Format("The Screening Info ({0}) was successfully updated.", screeninginfoToUpdate.ScreeningInfoId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void ScreeningInfo_Button_Clear_Click(object sender, EventArgs e)
        {
            ScreeningInfo_Textbox_ID.Text = "auto";
            ScreeningInfo_Textbox_MovieId.Value = 0;
            ScreeningInfo_Textbox_HallId.Value = 0;
            ScreeningInfo_Textbox_TicketPrice.Text = "0";

            ScreeningInfo_Button_Update.Visible = false;
            ScreeningInfo_Button_Insert.Visible = true;

            Grid_ScreeningInfo.ClearSelection();
        }

        private void Grid_ScreeningInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ScreeningInfo screeninginfo = CinemaClient.Client.GetScreeningInfo(Grid_ScreeningInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                ScreeningInfo_Textbox_ID.Text = screeninginfo.ScreeningInfoId.ToString();
                ScreeningInfo_Textbox_MovieId.Value = screeninginfo.MovieId;
                ScreeningInfo_Textbox_HallId.Value = screeninginfo.HallId;
                ScreeningInfo_Textbox_TicketPrice.Text = screeninginfo.TicketPrice.ToString();

                ScreeningInfo_Button_Insert.Visible = false;
                ScreeningInfo_Button_Update.Visible = true;
            }
            catch { }
        }

        private void Grid_ScreeningInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_ScreeningInfo.Rows[e.RowIndex].Selected = true;
        }  


        private void Grid_ScreeningInfo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Screening Info Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteScreeningInfo(Grid_ScreeningInfo.Rows[Grid_ScreeningInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Screening Info was successfully deleted."));
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

        private ScreeningInfo GetScreeningInfoDataFromFields() 
        {
            int id = 0;
            try
            {
                id = Int32.Parse(ScreeningInfo_Textbox_ID.Text);
            }
            catch {}


            int movieid = (int)ScreeningInfo_Textbox_MovieId.Value;
            int hallid = (int)ScreeningInfo_Textbox_HallId.Value;
            float ticketprice = 0;

            try
            {
                ticketprice = float.Parse(ScreeningInfo_Textbox_TicketPrice.Text);
            }
            catch { }
            

            ScreeningInfo screeninginfo = new ScreeningInfo
            {
                ScreeningInfoId = id,
                MovieId = movieid,
                HallId = hallid,
                TicketPrice = ticketprice
            };

            return screeninginfo;
        }
    }
}
