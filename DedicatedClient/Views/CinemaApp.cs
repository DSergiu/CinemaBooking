namespace DedicatedClient
{
    using CinemaService;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.ServiceModel.Security;

    public partial class CinemaApp : Form
    {
        public CinemaApp()
        {
            InitializeComponent();
            ShowSeatsLegend();
            InitializeTicketChooser();
        }

        private void CinemaApp_Load(object sender, EventArgs e)
        {        
        }



        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTabIndex(Tabs.SelectedIndex);
        }

        private void MoviesPanel_Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectMoviesTabIndex(MoviesPanel_Tabs.SelectedIndex);
        }

        private void ScreeningsPanel_Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectScreeningsTabIndex(ScreeningsPanel_Tabs.SelectedIndex);
        }

        private void SelectScreeningsTabIndex(int index)
        {
            switch (index)
            {
                case 0: { FirstLoad_ScreeningInfo(); } break;
                case 1: { FirstLoad_Screening(); } break;
            }
        }

        private void SelectMoviesTabIndex(int index) 
        {
            switch (index)
            {
                case 0: { FirstLoad_MovieInfo(); } break;
                case 1: { FirstLoad_Movie(); } break;
            }
        }

        private void SelectTabIndex(int index)
        {
            switch (index)
            {
                case 0: { SelectMoviesTabIndex(MoviesPanel_Tabs.SelectedIndex); } break;
                case 1: { SelectScreeningsTabIndex(ScreeningsPanel_Tabs.SelectedIndex); } break;
                case 2: { FirstLoad_Halls();  } break;
                case 3: { FirstLoad_TicketType(); } break;
                case 4: { FirstLoad_Bookings(); } break;
                case 5: { FirstLoad_Users(); } break;
            }
        }


        private void Tabs_VisibleChanged(object sender, EventArgs e)
        {
            if (Tabs.Visible)
            {
                SelectTabIndex(Tabs.SelectedIndex);
            }
        }





        private void Info_Loading_Show(string message)
        {
            Info_Hide();
            InfoPanel_Loading.Visible = true;
            Info_Show(message);
        }

        private void Info_Wrong_Show(string message) 
        {
            Info_Hide();
            InfoPanel_Wrong.Visible = true;
            Info_Show(message);
        }

        private void Info_Right_Show(string message)
        {
            Info_Hide();
            InfoPanel_Right.Visible = true;
            Info_Show(message);
        }

        private void Info_Show(string message) 
        {
            InfoPanel_Text.Text = message;
            InfoPanel.Visible = true;
        }

        private void Info_Hide() 
        {
            InfoPanel.Visible = false;
            InfoPanel_Loading.Visible = false;
            InfoPanel_Wrong.Visible = false;
            InfoPanel_Right.Visible = false;
        }




        private void IsAuthenticated() {
            LoginPanel.Visible = false;
            Label_LoggedInAs.Text = "Logged in as: "+CinemaClient.Name;
            Tabs.Visible = true;
        }

        private void IsNotAuthenticated()
        {
            LoginPanel.Visible = true;
            Tabs.Visible = false;

            Label_LoggedInAs.Text = "";
            CinemaClient.Name = "";
            CinemaClient.Email = "";
            CinemaClient.TokenKey = "";
        }




        private void HandleException(Exception ex) 
        {
            if (ex.GetType() == typeof(System.ServiceModel.FaultException<ValidationError[]>))
            {
                foreach (var error in (ex as System.ServiceModel.FaultException<ValidationError[]>).Detail)
                {
                    Info_Wrong_Show(error.ErrorMessage + " ");
                }
            }
            else if(ex.GetType() == typeof(MessageSecurityException))
            {
                IsNotAuthenticated();
                Info_Wrong_Show("You are not authenticated. (your session expired or you don't have the right access level)");
            }
            else if (ex.GetType() == typeof(System.ServiceModel.EndpointNotFoundException))
            {
                IsNotAuthenticated();
                Info_Wrong_Show("The services might not be started. Ensure you started the service.");
            }
        }     
        
      
    }
}
