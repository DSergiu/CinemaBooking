namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // Ticket Types
    {
        private void FirstLoad_TicketType() 
        {
            GetTicketTypesFromDB();
        }


        async private void GetTicketTypesFromDB()
        {
            try
            {
                Info_Loading_Show("Getting all ticket types...");
                ICollection<TicketType> ticketypes = await CinemaClient.Client.GetAllTicketTypesAsync();
                Grid_TicketType.Rows.Clear();

                foreach (var tickettype in ticketypes) AddRow(tickettype);

                Grid_TicketType.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                Info_Hide();
                HandleException(ex);
            }
        }

        private void AddRow(TicketType tickettype)
        {
            var index = Grid_TicketType.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_TicketType.Rows[index];
            row.Cells[0].Value = tickettype.TicketTypeId;
            row.Cells[1].Value = tickettype.Type;
            row.Cells[2].Value = tickettype.Discount;
        }



        private void TicketType_Button_Insert_Click(object sender, EventArgs e)
        {
            TicketType tickettypeToInsert = GetTicketTypeDataFromFields();

            try
            {
                tickettypeToInsert.TicketTypeId = CinemaClient.Client.CreateTicketType(tickettypeToInsert);
                AddRow(tickettypeToInsert);

                Info_Right_Show(String.Format("The Ticket Type ({0}) was successfully inserted.", tickettypeToInsert.TicketTypeId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void TicketType_Button_Update_Click(object sender, EventArgs e)
        {
            TicketType tickettypeToUpdate = GetTicketTypeDataFromFields();

            if (tickettypeToUpdate.TicketTypeId <= 0)
            {
                Info_Wrong_Show("You didn't select a ticket type row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateTicketTypeAsync(tickettypeToUpdate, tickettypeToUpdate.TicketTypeId.ToString());
                Grid_TicketType.Rows.RemoveAt(Grid_TicketType.SelectedRows[0].Index);
                AddRow(tickettypeToUpdate);

                Info_Right_Show(String.Format("The Ticket Type ({0}) was successfully updated.", tickettypeToUpdate.TicketTypeId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void TicketType_Button_Clear_Click(object sender, EventArgs e)
        {
            TicketType_Textbox_ID.Text = "auto";
            TicketType_Textbox_TicketType.Text = "";
            TicketType_Textbox_Discount.Value = 0;

            TicketType_Button_Update.Visible = false;
            TicketType_Button_Insert.Visible = true;

            Grid_TicketType.ClearSelection();
        }

        async private void Grid_TicketType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try  {
                TicketType tickettype = await CinemaClient.Client.GetTicketTypeAsync(Grid_TicketType.Rows[e.RowIndex].Cells[0].Value.ToString());

                TicketType_Textbox_ID.Text = tickettype.TicketTypeId.ToString();
                TicketType_Textbox_Discount.Value = (decimal)tickettype.Discount;
                TicketType_Textbox_TicketType.Text = tickettype.Type;

                TicketType_Button_Insert.Visible = false;
                TicketType_Button_Update.Visible = true;
            } catch { }
        }

        private void Grid_TicketType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_TicketType.Rows[e.RowIndex].Selected = true;
        }


        private void Grid_TicketType_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Ticket Type Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteTicketTypeAsync(Grid_TicketType.Rows[Grid_TicketType.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Ticket Type was successfully deleted."));
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




        private TicketType GetTicketTypeDataFromFields() 
        {
            int id = 0;
            try
            {
                id = Int32.Parse(TicketType_Textbox_ID.Text);
            }
            catch {}


            string type = TicketType_Textbox_TicketType.Text;
            byte discount = (byte)TicketType_Textbox_Discount.Value;

            TicketType tickettype = new TicketType
            {
                TicketTypeId = id,
                Type = type,
                Discount = discount
            };

            return tickettype;
        }
    }
}
