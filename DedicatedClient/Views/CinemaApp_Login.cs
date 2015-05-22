namespace DedicatedClient
{
    using System;
    using System.ServiceModel;
    using CinemaService;
    using System.Text.RegularExpressions;
    using System.Drawing;
    using System.Collections.Generic;

    public partial class CinemaApp      //Login
    {
        private void LoginButton_Click(object sender, EventArgs e)
        {
            AuthenticateUser();            
        }

        async private void AuthenticateUser()
        {
            Info_Hide();
            string emailORphone = LoginEmailTextbox.Text;
            string password = LoginPasswordTextbox.Text;
            UserLogin userlogin = new UserLogin { emailORphone = emailORphone, password = password };

            try
            {
                Info_Loading_Show("Trying to authenticate...");
                LoginResult result = await CinemaClient.Client.LoginAsync(userlogin);
                CinemaClient.TokenKey = result.TokenKey.ToString();
                CinemaClient.Email = result.Email;
                CinemaClient.Name = result.Name;

                IsAuthenticated();
                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void LoginEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            string emailORphone = LoginEmailTextbox.Text;
            
            if (Regex.Match(emailORphone, @"^[\w-.]{1,}@[\w-.]{1,}.[a-zA-Z]{2,4}$").Success)
            {
                LoginEmailTextbox.BackColor = Color.White;
                LoginEmailError.Clear();

                if (LoginPasswordError.GetError(LoginPasswordTextbox).Length == 0)
                    LoginButton.Enabled = true;
            }
            else
            {
                LoginEmailTextbox.BackColor = Color.LightPink;
                LoginEmailError.SetError(LoginEmailTextbox, "Invalid email address");
                LoginButton.Enabled = false;
            }
        }

        private void LoginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            string password = LoginPasswordTextbox.Text;
            if (Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,20}$").Success)
            {
                LoginPasswordTextbox.BackColor = Color.White;
                LoginPasswordError.Clear();
                if (LoginEmailError.GetError(LoginEmailTextbox).Length == 0)
                    LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
                LoginPasswordTextbox.BackColor = Color.LightPink;
                LoginPasswordError.SetError(LoginPasswordTextbox, "The password requires at least one lower case letter, one upper case letter, one digit, 8-20 length.");
            }
        }
    }
}
