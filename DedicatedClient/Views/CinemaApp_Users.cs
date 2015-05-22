namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // Users
    {
        private void FirstLoad_Users() 
        {
            GetUsersFromDB(0, 10);

            foreach (var accesstype in Enum.GetValues(typeof(AccessType)))
                Users_Combobox_AccessLevel.Items.Add(accesstype);

            Users_Combobox_AccessLevel.SelectedIndex = 0;
        }


        async private void GetUsersFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of users...");
                ICollection<User> users = await CinemaClient.Client.GetusersByPageAsync(page.ToString(), noperpage.ToString());
                Grid_Users.Rows.Clear();

                foreach (var user in users) AddRow(user);

                Grid_Users.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void AddRow(User user)
        {
            var index = Grid_Users.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_Users.Rows[index];
            row.Cells[0].Value = user.UserGuid;
            row.Cells[1].Value = String.Format("{0} {1}", user.FirstName, user.LastName);
            row.Cells[2].Value = user.Email;
            row.Cells[3].Value = user.Phone;
            row.Cells[4].Value = user.IsDeleted;
        }



        private void Users_Button_Insert_Click(object sender, EventArgs e)
        {
            UserRegister userToInsert = GetUserRegisterDataFromFields();

            try
            {
                CreateUserResult res = CinemaClient.Client.CreateUser(userToInsert);

                User user = CinemaClient.Client.GetUser(res.UserKey.ToString());

                AddRow(user);

                Info_Right_Show(String.Format("The User ({0}) was successfully inserted.", user.Email));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Users_Button_Update_Click(object sender, EventArgs e)
        {
            User userToUpdate = GetUserDataFromFields();

            if (userToUpdate.UserGuid.Equals(Guid.Empty))
            {
                Info_Wrong_Show("You didn't select a user row to update.");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateUser(userToUpdate);

                Grid_Users.Rows.RemoveAt(Grid_Users.SelectedRows[0].Index);
                AddRow(userToUpdate);

                Info_Right_Show(String.Format("The User ({0}) was successfully updated.", userToUpdate.Email));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Users_Button_Clear_Click(object sender, EventArgs e)
        {
            Users_Textbox_ID.Text = "auto";
            Users_Textbox_Email.Text = "";
            Users_Textbox_Phone.Text = "";

            Users_Textbox_LastLogin.Text = "";
            Users_Textbox_CreatedBy.Text = "";
            Users_Textbox_CreatedOn.Text = "";
            Users_Textbox_UpdatedBy.Text = "";
            Users_Textbox_UpdatedOn.Text = "";


            Users_Checkbox_IsDeleted.Checked = false;

            Users_Textbox_FirstName.Text = "";
            Users_Textbox_LastName.Text = "";
            Users_Textbox_Password.Text = "";
            Users_Textbox_ConfirmPassword.Text = "";


            Users_Button_Update.Visible = false;
            Users_Button_Insert.Visible = true;
            Users_Panel_Password.Visible = true;
            Users_Panel_UpdatePanel.Visible = false;

            Grid_Users.ClearSelection();
        }

        async private void Grid_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try  {
                User user = await CinemaClient.Client.GetUserAsync(Grid_Users.Rows[e.RowIndex].Cells[0].Value.ToString());

                Users_Textbox_ID.Text = user.UserGuid.ToString();
                Users_Textbox_Email.Text = user.Email;
                Users_Textbox_Phone.Text = user.Phone;
                Users_Textbox_FirstName.Text = user.FirstName;
                Users_Textbox_LastName.Text = user.LastName;

                Users_Combobox_AccessLevel.SelectedItem = user.AccessLevel;

                Users_Textbox_LastLogin.Text = user.LastLogin.ToString();
                Users_Textbox_CreatedBy.Text = user.CreatedBy.ToString();
                Users_Textbox_CreatedOn.Text = user.CreatedOn.ToString();
                Users_Textbox_UpdatedBy.Text = user.UpdatedBy.ToString();
                Users_Textbox_UpdatedOn.Text = user.UpdatedOn.ToString();

                Users_Checkbox_IsDeleted.Checked = user.IsDeleted;

                Users_Button_Insert.Visible = false;
                Users_Button_Update.Visible = true;
                Users_Panel_Password.Visible = false;
                Users_Panel_UpdatePanel.Visible = true;

            } catch { }
        }

        private void Grid_Users_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_Users.Rows[e.RowIndex].Selected = true;
        }

        private UserRegister GetUserRegisterDataFromFields() 
        {
            string email = Users_Textbox_Email.Text;
            string phone = Users_Textbox_Phone.Text;
            string firstname = Users_Textbox_FirstName.Text;
            string lastname = Users_Textbox_LastName.Text;

            string password = Users_Textbox_Password.Text;
            string confirmpassword = Users_Textbox_ConfirmPassword.Text;

            UserRegister user = new UserRegister
            {
                Email = email,
                Phone = phone,
                FirstName = firstname,
                LastName = lastname,
                Password = password,
                ConfirmPassword = confirmpassword
            };

            return user;
        }


        private User GetUserDataFromFields() 
        {
            Guid id = Guid.Empty;

            try
            {
                id = new Guid(Users_Textbox_ID.Text);
            }
            catch {}


            bool isdeleted = Users_Checkbox_IsDeleted.Checked;
            string email = Users_Textbox_Email.Text;
            string phone = Users_Textbox_Phone.Text;
            string firstname = Users_Textbox_FirstName.Text;
            string lastname = Users_Textbox_LastName.Text;

            AccessType accesstype = (AccessType) Users_Combobox_AccessLevel.SelectedItem;
            

            User user = new User
            {
                UserGuid = id,
                Email = email,
                Phone = phone,
                FirstName = firstname,
                LastName = lastname,
                AccessLevel = accesstype,
                IsDeleted = isdeleted
            };

            return user;
        }
    }
}
