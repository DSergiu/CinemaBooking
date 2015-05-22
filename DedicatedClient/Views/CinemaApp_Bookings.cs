namespace DedicatedClient
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class CinemaApp      // Bookings
    {
        private void FirstLoad_Bookings() 
        {
            ShowTicketTypesLegend();

            GetBookingsFromDB(0, 10);
        }

        Color bookingSeatColor = Color.Orange;
        Color alreadyBookedSeat = Color.Green;

        Screening currentScreening;


        async private void GetBookingsFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of bookings...");
                ICollection<Booking> bookings = await CinemaClient.Client.GetAllBookingsByPageAsync(page.ToString(), noperpage.ToString());
                Grid_Booking.Rows.Clear();

                foreach (var booking in bookings) 
                    AddRow(booking);

                Grid_Booking.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                Info_Hide();
                HandleException(ex);
            }
        }


        private void AddRow(Booking booking)
        {
            var index = Grid_Booking.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_Booking.Rows[index];
            row.Cells[0].Value = booking.BookingId;
            row.Cells[1].Value = String.Format("{0} {1}", booking.User.FirstName, booking.User.LastName);
            row.Cells[2].Value = booking.ScreeningId;
        }





        Dictionary<int, NumericUpDown> tickettypesCount;
        Button[]  tickettypeButtons;
        TicketType[] tickettypes;

        async private void ShowTicketTypesLegend()
        {
            try
            {
                tickettypes = await CinemaClient.Client.GetAllTicketTypesAsync();
            }
            catch (Exception ex)
            {
                HandleException(ex); return;
            }            

            tickettypesCount = new Dictionary<int, NumericUpDown>();
            tickettypeButtons  = new Button [tickettypes.Length];

            Control[] controls = new Control[tickettypes.Length];

            for (int i = 0; i < tickettypes.Length; i++)
            {
                NumericUpDown tickettypeCount = new NumericUpDown();
                Button tickettypeButton = new Button();

                tickettypeCount.Value = 0;
                tickettypeButton.Text = tickettypes[i].Type;
                tickettypeButton.Click += SelectTicketType_Click;

                tickettypesCount[tickettypes[i].TicketTypeId] = tickettypeCount;
                tickettypeButtons[i] = tickettypeButton;
                                
                tickettypeCount.Size = new Size(30, 20);

                tickettypeCount.Minimum = 0;
                tickettypeCount.Maximum = 9;

                tickettypeCount.ValueChanged += CalculateTotalPrice_ValueChanged;
                tickettypeCount.KeyUp += CalculateTotalPrice_ValueChanged;

                FlowLayoutPanel panel = new FlowLayoutPanel();

                panel.Controls.Add(tickettypeButton);
                panel.Controls.Add(tickettypeCount);

                panel.AutoSize = true;

                controls[i] = panel;
            }

            Booking_Tickets_TicketTypes.Controls.Clear();
            Booking_Tickets_TicketTypes.Controls.AddRange(controls);
        }




        
        private TicketType GetTicketTypeByType(string type) 
        {
            foreach (var tickettype in tickettypes)
                if (tickettype.Type.Equals(type))
                    return tickettype;

            return null;
        }

        private void CalculateTotalPrice_ValueChanged(object sender, EventArgs e)
        {
            if (Grid_Booking.SelectedRows.Count > 0)
            {
                Info_Wrong_Show("You cannot modify the selected booking.");
                return;
            }

            if(currentScreening == null)
            {
                Info_Wrong_Show("You didn't select a screening. Choose a screening.");
                return;
            }

            NumericUpDown nupd = (NumericUpDown)sender;
            

            int noTickets = 0;
            float totalprice = 0;

            foreach(var tickettype in tickettypes)
            {
                float numberOfTickets = (float)tickettypesCount[tickettype.TicketTypeId].Value;

                noTickets += (int) numberOfTickets;
                if(noTickets > 9)
                {
                    Info_Wrong_Show("Maximum number of tickets is 9.");
                    nupd.Value = nupd.Value - (noTickets - 9);  // reset value to be maxim 9
                    return;
                }

                    
                float discount = 1 - (float)tickettype.Discount / 100;
                totalprice += numberOfTickets * currentScreening.ScreeningInfo.TicketPrice * discount;
            }
            

            Booking_Textbox_TotalPrice.Text = totalprice.ToString();
        }
        




        private TicketType selectedTicketType;
        async private void SelectTicketType_Click(object sender, EventArgs e)
        {
            Button tickettypeButton = (Button)sender;
            string tickettypeType = tickettypeButton.Text;

            try
            {
                selectedTicketType = await CinemaClient.Client.GetTicketTypeByTypeAsync(tickettypeType);
            }
            catch (Exception ex)
            {
                HandleException(ex); return;
            }
            
            
            if (selectedTicketType == null)
            {
                Info_Wrong_Show(String.Format("Invalid ticket type ({0})", tickettypeType));
                return;
            }
        }

        

        private void Grid_Tickets_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Grid_Booking.SelectedRows.Count > 0)
            {
                Info_Wrong_Show("You cannot modify the selected booking.");
                return;
            }

            if (ticketsBooked == null)
            {
                Info_Wrong_Show("First select a screening.");
                return;
            }


            if (e.Button == System.Windows.Forms.MouseButtons.Right && Grid_Tickets.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.Equals(bookingSeatColor))
            {
                DeleteBookedTicket(e.RowIndex, e.ColumnIndex);
                return;
            }

            if (selectedTicketType == null)
            {
                Info_Wrong_Show("First select a ticket type.");
                return;
            }
            

            if (e.Button == System.Windows.Forms.MouseButtons.Left && ticketsBooked.Count == 9)
            {
                Info_Wrong_Show("Maximum number of tickets is 9.");
                return;
            }

            Info_Hide();

            int colorindex = GetSeatIndexByColor(Grid_Tickets.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor);
            SeatType seatValue = (SeatType)colorindex;


            if (e.Button == System.Windows.Forms.MouseButtons.Left && seatValue != SeatType.NoSeat && colorindex != -1)
            {
                AddTicketToBookedList(e.RowIndex, e.ColumnIndex);                
            }
        }


        private Color GetCurrentSeatMapColor(int row, int column) 
        {
            foreach (var seat in currentScreening.ScreeningInfo.Hall.Seats)
                if(seat.Row.Equals(row) && seat.Column.Equals(column))
                    return SeatMapLegend[(int)seat.Value];
            
            return Color.White;
        }



        public void ClearTicketsBookedList()
        {
            foreach (var ticket in ticketsBooked)   // delete tickets just from map
                DeleteBookedTicketFromMap((int)ticket.Row, (int)ticket.Column);

            ticketsBooked.Clear();
        }


        public int GetNoOfTicketsBooked(int tickettype)
        {
            int no = 0;
            foreach (var ticket in ticketsBooked)
                if (ticket.TicketTypeId.Equals(tickettype))
                    no++;

            return no;
        }

        public void AddTicketToBookedList(int row, int col, int tickettypeid = -1)
        {
            string tooltip = "";

            if (tickettypeid == -1)
            {
                if(selectedTicketType == null)
                {
                    Info_Wrong_Show("First select a ticket type.");
                    return;
                }

                tooltip = selectedTicketType.Type;
            }
            else
            {
                tooltip = tickettypes[tickettypeid].Type;
            }

            Info_Hide();

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = bookingSeatColor;
            Grid_Tickets.Rows[row].Cells[col].Style = style;
            Grid_Tickets.Rows[row].Cells[col].ToolTipText = tooltip;

            if (selectedTicketType != null && tickettypesCount[selectedTicketType.TicketTypeId].Value == GetNoOfTicketsBooked(selectedTicketType.TicketTypeId))
                tickettypesCount[selectedTicketType.TicketTypeId].Value++;

            TicketModel ticket = new TicketModel
            {
                Row = row,
                Column = col,
                TicketTypeId = (tickettypeid != -1) ? tickettypes[tickettypeid].TicketTypeId : selectedTicketType.TicketTypeId
            };

            ticketsBooked.Add(ticket);
        }

        private void DeleteBookedTicket(int row, int col) 
        {
            foreach(var ticket in ticketsBooked)
                if(ticket.Row.Equals(row) && ticket.Column.Equals(col))
                {
                    tickettypesCount[(int)ticket.TicketTypeId].Value--;
                    ticketsBooked.Remove(ticket);

                    break;
                }

            DeleteBookedTicketFromMap(row, col);
        }


        private void DeleteBookedTicketFromMap(int row, int col)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = GetCurrentSeatMapColor(row, col);
            Grid_Tickets.Rows[row].Cells[col].Style = style;
        }


        private void Grid_Tickets_SelectionChanged(object sender, EventArgs e)
        {
            Grid_Tickets.ClearSelection();    // disable select cell selection color
        }



        private void InitializeTicketChooser()
        {
            Grid_Tickets.ColumnCount = 25;
            Grid_Tickets.RowCount = 20;

            for (int i = 1; i < Grid_Tickets.ColumnCount; i++)
                Grid_Tickets.Rows[0].Cells[i].Value = (i - 1);


            for (int i = 1; i < Grid_Tickets.RowCount; i++)
            {
                Grid_Tickets.Rows[i].Cells[0].Value = (char)('A' + i - 1);
            }
        }





        private ICollection<TicketModel> ticketsBooked;
        private void ScreeningSelected() 
        {
            ticketsBooked = new List<TicketModel>();

            Seat[] seatsMap = currentScreening.ScreeningInfo.Hall.Seats;

            for (int i = 0; i < seatsMap.Length; i++)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = SeatMapLegend[(int)seatsMap[i].Value];
                Grid_Tickets.Rows[seatsMap[i].Row].Cells[seatsMap[i].Column].Style = style;   
            }

            ICollection<Booking> bookings;

            try
            {
                bookings = CinemaClient.Client.GetBookingsByScreeningId(currentScreening.ScreeningId.ToString());
            }
            catch (Exception ex)
            {
                HandleException(ex); return;
            }            
            
            foreach(var booking in bookings)
                foreach(var ticket in booking.Tickets)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = alreadyBookedSeat;
                    Grid_Tickets.Rows[ticket.Row].Cells[ticket.Column].Style = style;
                }
        }





        private void ResetTicketGrid() 
        {
            currentScreening = null;

            for (int i = 1; i < Grid_Tickets.RowCount; i++)
                for (int j = 1; j < Grid_Tickets.ColumnCount; j++)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = SeatMapLegend[(int)SeatType.NoSeat];
                    Grid_Tickets.Rows[i].Cells[j].Style = style;
                }
        }





        private void Booking_Button_ShowSuggestions_Click(object sender, EventArgs e)
        {
            if(Grid_Booking.SelectedRows.Count > 0)
            {
                Info_Wrong_Show("You cannot get suggestion for the selected booking.");
                return;
            }

            if (currentScreening == null)
            {
                Info_Wrong_Show("You didn't select a screening. Choose a screening first.");
                return;
            }

            int noOfTickets = 0;

            foreach (var ttC in tickettypesCount.Values)
                noOfTickets += (int)ttC.Value;

            if (noOfTickets <= 0)
            {
                Info_Wrong_Show("Select at least one ticket.");
                return;
            }


            try
            {
                var seats = CinemaClient.Client.GetSeatsSuggestion(currentScreening.ScreeningId.ToString(), noOfTickets.ToString());

                if (seats.Length != noOfTickets)
                {
                    Info_Wrong_Show(String.Format("There are not {0} tickets available on this hall.", noOfTickets));
                    return;
                }


                ClearTicketsBookedList();  // empty the actual booked list

                // Parse each type of tickets selected
                int h = -1;
                int k = -1;
                foreach (var ttC in tickettypesCount.Values)
                {
                    k++;
                    if (ttC.Value > 0)  // if selected any of this ticket type
                    {
                        for (int i = 0; i < (int)ttC.Value; i++ )
                        {
                            h++;
                            AddTicketToBookedList(seats[h].Row, seats[h].Column, k);    
                        }                                                
                    }
                }

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }


        private void Booking_Textbox_Screening_KeyDown(object sender, KeyEventArgs e)
        {
            Booking_Button_ChooseTickets.Visible = true;
        }


        private void Booking_Textbox_Screening_ValueChanged(object sender, EventArgs e)
        {
            Booking_Button_ChooseTickets.Visible = true;
        }




        async private void Booking_Button_ChooseTickets_Click(object sender, EventArgs e)
        {
            int screeningId = (int) Booking_Textbox_Screening.Value;

            currentScreening = await CinemaClient.Client.GetScreeningAsync(screeningId.ToString());

            if (currentScreening == null)
            {
                Info_Wrong_Show(String.Format("This screening ({0}) does not exist.", screeningId));
                ResetTicketGrid();
                return;
            }

            Booking_Button_ChooseTickets.Visible = false;
            Info_Hide();

            ScreeningSelected();
        }



        async private void Booking_Button_Insert_Click(object sender, EventArgs e)
        {
            BookingModel bookingToInsert = GetBookingsDataFromFields();

            try
            {
                int bookingId = await CinemaClient.Client.CreateBookingAsync(bookingToInsert);

                Booking booking = await CinemaClient.Client.GetBookingAsync(bookingId.ToString());
                AddRow(booking);

                Info_Right_Show(String.Format("The Booking ({0}) was successfully inserted.", bookingId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }














        private void Booking_Button_Clear_Click(object sender, EventArgs e)
        {
            Booking_Textbox_ID.Text = "auto";
            Booking_Textbox_CreatedBy.Text = CinemaClient.Name;
            Booking_Textbox_CreatedOn.Text = DateTime.UtcNow.ToString();

            Booking_Textbox_Screening.Value = 0;
            Booking_Textbox_TotalPrice.Text = "0";


            Booking_Checkbox_Paid.Checked = false;
            Booking_Checkbox_Canceled.Checked = false;


            Booking_Button_ChooseTickets.Visible = true;
            Booking_Button_Insert.Visible = true;

            Grid_Booking.ClearSelection();

            foreach (var ttCount in tickettypesCount.Values)
            {
                ttCount.Value = 0;
            }

            ResetTicketGrid();
        }




        async private void Grid_Booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try  {
                Booking booking = await CinemaClient.Client.GetBookingAsync(Grid_Booking.Rows[e.RowIndex].Cells[0].Value.ToString());

                currentScreening = await CinemaClient.Client.GetScreeningAsync(booking.ScreeningId.ToString());

                Booking_Textbox_ID.Text = booking.BookingId.ToString();
                Booking_Textbox_CreatedBy.Text = booking.CreatedBy.ToString();
                Booking_Textbox_CreatedOn.Text = booking.CreatedOn.ToString();

                Booking_Textbox_Screening.Value = (decimal)booking.ScreeningId;
                Booking_Textbox_TotalPrice.Text = booking.TotalPrice.ToString();

                Booking_Checkbox_Paid.Checked = booking.Paid;
                Booking_Checkbox_Canceled.Checked = booking.IsCanceled;

                ScreeningSelected();
                
                foreach (var ttCount in tickettypesCount.Values)
                {
                    ttCount.Value = 0;
                }

                foreach(var ticket in booking.Tickets)
                {
                    tickettypesCount[ticket.TicketTypeId].Value++;

                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = bookingSeatColor;
                    Grid_Tickets.Rows[ticket.Row].Cells[ticket.Column].Style = style;
                }
                                

                Booking_Button_Insert.Visible = false;
                Booking_Button_ChooseTickets.Visible = false;


            } catch { }
        }


        private void Grid_Booking_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_Booking.Rows[e.RowIndex].Selected = true;
        }


        private void Grid_Booking_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;    //cancel this operation

            if (MessageBox.Show("Are you sure you want to cancel this Booking ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteBookingAsync(Grid_Booking.Rows[Grid_Booking.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Booking was successfully canceled."));
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
                
            }
        }




        private BookingModel GetBookingsDataFromFields() 
        {
            Guid customerId = Guid.Empty;
            try
            {
                customerId = new Guid(Booking_Textbox_Customer.Text);
            }
            catch {}



            BookingModel booking = new BookingModel
            {
                ScreeningId = currentScreening.ScreeningId,
                UserGuid = customerId,
                Tickets = ticketsBooked.ToArray()
            };

            return booking;
        }
    }
}
