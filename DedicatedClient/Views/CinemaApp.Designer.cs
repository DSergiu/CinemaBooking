namespace DedicatedClient
{
    partial class CinemaApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaApp));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginEmailTextbox = new System.Windows.Forms.TextBox();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmailPhoneLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoPanel_Right = new System.Windows.Forms.PictureBox();
            this.InfoPanel_Wrong = new System.Windows.Forms.PictureBox();
            this.InfoPanel_Text = new System.Windows.Forms.Label();
            this.InfoPanel_Loading = new System.Windows.Forms.PictureBox();
            this.Label_LoggedInAs = new System.Windows.Forms.Label();
            this.Tabs_TickeTypes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketType_Textbox_Discount = new System.Windows.Forms.NumericUpDown();
            this.TicketType_Button_Insert = new System.Windows.Forms.Button();
            this.TicketType_Button_Clear = new System.Windows.Forms.Button();
            this.TicketType_Button_Update = new System.Windows.Forms.Button();
            this.TicketType_Textbox_TicketType = new System.Windows.Forms.TextBox();
            this.TicketType_Textbox_ID = new System.Windows.Forms.TextBox();
            this.TicketType_Label_TicketType = new System.Windows.Forms.Label();
            this.TicketType_Label_Discount = new System.Windows.Forms.Label();
            this.TicketType_Label_ID = new System.Windows.Forms.Label();
            this.Grid_TicketType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabs_Bookings = new System.Windows.Forms.TabPage();
            this.Booking_Button_ShowSuggestions = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Booking_Tickets_TicketTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.Booking_Button_ChooseTickets = new System.Windows.Forms.Button();
            this.Booking_Textbox_Screening = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_Tickets = new System.Windows.Forms.DataGridView();
            this.Booking_Button_Insert = new System.Windows.Forms.Button();
            this.Booking_Button_Clear = new System.Windows.Forms.Button();
            this.Booking_Checkbox_Canceled = new System.Windows.Forms.CheckBox();
            this.Booking_Checkbox_Paid = new System.Windows.Forms.CheckBox();
            this.Booking_Textbox_CreatedOn = new System.Windows.Forms.TextBox();
            this.Booking_Textbox_CreatedBy = new System.Windows.Forms.TextBox();
            this.Booking_Textbox_TotalPrice = new System.Windows.Forms.TextBox();
            this.Booking_Textbox_Customer = new System.Windows.Forms.TextBox();
            this.Booking_Textbox_ID = new System.Windows.Forms.TextBox();
            this.Booking_Label_CreatedOn = new System.Windows.Forms.Label();
            this.Booking_Label_CreatedBy = new System.Windows.Forms.Label();
            this.Booking_Label_Canceled = new System.Windows.Forms.Label();
            this.Booking_Label_Paid = new System.Windows.Forms.Label();
            this.Booking_Label_TotalPrice = new System.Windows.Forms.Label();
            this.Booking_Label_Screening = new System.Windows.Forms.Label();
            this.Booking_Label_Customer = new System.Windows.Forms.Label();
            this.Booking_Label_ID = new System.Windows.Forms.Label();
            this.Grid_Booking = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booking_Screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabs_Halls = new System.Windows.Forms.TabPage();
            this.Hall_Seat_Panel = new System.Windows.Forms.Panel();
            this.Grid_Seats = new System.Windows.Forms.DataGridView();
            this.Hall_Seat_Legend_HowToUse = new System.Windows.Forms.Label();
            this.Hall_Seat_Seats_Legend = new System.Windows.Forms.FlowLayoutPanel();
            this.Hall_Seat_Title = new System.Windows.Forms.Label();
            this.Hall_Textbox_Name = new System.Windows.Forms.TextBox();
            this.Hall_Textbox_ID = new System.Windows.Forms.TextBox();
            this.Hall_Button_Insert = new System.Windows.Forms.Button();
            this.Hall_Button_Clear = new System.Windows.Forms.Button();
            this.Hall_Button_Update = new System.Windows.Forms.Button();
            this.Hall_Label_Name = new System.Windows.Forms.Label();
            this.Hall_Label_ID = new System.Windows.Forms.Label();
            this.Grid_Hall = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabs_Screenings = new System.Windows.Forms.TabPage();
            this.ScreeningsPanel_Tabs = new System.Windows.Forms.TabControl();
            this.ScreeningInfo = new System.Windows.Forms.TabPage();
            this.ScreeningInfo_Button_Insert = new System.Windows.Forms.Button();
            this.ScreeningInfo_Textbox_MovieId = new System.Windows.Forms.NumericUpDown();
            this.ScreeningInfo_Button_Clear = new System.Windows.Forms.Button();
            this.ScreeningInfo_Button_Update = new System.Windows.Forms.Button();
            this.ScreeningInfo_Textbox_HallId = new System.Windows.Forms.NumericUpDown();
            this.ScreeningInfo_Label_HallId = new System.Windows.Forms.Label();
            this.ScreeningInfo_Textbox_TicketPrice = new System.Windows.Forms.TextBox();
            this.ScreeningInfo_Label_TicketPrice = new System.Windows.Forms.Label();
            this.ScreeningInfo_Label_MovieId = new System.Windows.Forms.Label();
            this.ScreeningInfo_Textbox_ID = new System.Windows.Forms.TextBox();
            this.ScreeningInfo_Label_ID = new System.Windows.Forms.Label();
            this.Grid_ScreeningInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Screenings = new System.Windows.Forms.TabPage();
            this.Screenings_Button_Insert = new System.Windows.Forms.Button();
            this.Screening_Date = new System.Windows.Forms.DateTimePicker();
            this.Screening_Textbox_ScreeningInfoId = new System.Windows.Forms.NumericUpDown();
            this.Screenings_Button_Clear = new System.Windows.Forms.Button();
            this.Screenings_Button_Update = new System.Windows.Forms.Button();
            this.Screening_Label_ScreeningDate = new System.Windows.Forms.Label();
            this.Screening_Label_ScreeningInfoId = new System.Windows.Forms.Label();
            this.Screening_Textbox_ID = new System.Windows.Forms.TextBox();
            this.Screening_Label_ID = new System.Windows.Forms.Label();
            this.Grid_Screening = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreeningInfoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreeningDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabs_Movies = new System.Windows.Forms.TabPage();
            this.MoviesPanel_Tabs = new System.Windows.Forms.TabControl();
            this.MoviesInfo = new System.Windows.Forms.TabPage();
            this.MovieInfo_Button_Insert = new System.Windows.Forms.Button();
            this.MovieInfo_Button_Clear = new System.Windows.Forms.Button();
            this.MovieInfo_Button_Update = new System.Windows.Forms.Button();
            this.Movieinfo_Textbox_LenghtTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieInfo_DatePicker_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.MovieInfo_Label_ReleaseDate = new System.Windows.Forms.Label();
            this.MovieInfo_Combobox_AgeRestriction = new System.Windows.Forms.ComboBox();
            this.MovieInfo_Label_AgeRestriction = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Genre = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Genre = new System.Windows.Forms.Label();
            this.Movieinfo_Label_LenghtTime = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Actors = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Actors = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Directors = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Directors = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Description = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Description = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Title = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Title = new System.Windows.Forms.Label();
            this.MovieInfo_Textbox_Id = new System.Windows.Forms.TextBox();
            this.MovieInfo_Label_Id = new System.Windows.Forms.Label();
            this.Grid_MovieInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LenghtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeRestriction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies = new System.Windows.Forms.TabPage();
            this.Movie_Button_Insert = new System.Windows.Forms.Button();
            this.Movie_Button_Update = new System.Windows.Forms.Button();
            this.Movie_Textbox_MovieInfoId = new System.Windows.Forms.NumericUpDown();
            this.Movie_Button_Clear = new System.Windows.Forms.Button();
            this.Movie_CheckBox_Is3D = new System.Windows.Forms.CheckBox();
            this.Movie_Label_3D = new System.Windows.Forms.Label();
            this.Movie_Label_MovieInfoId = new System.Windows.Forms.Label();
            this.Movie_Textbox_Id = new System.Windows.Forms.TextBox();
            this.Movie_Label_Id = new System.Windows.Forms.Label();
            this.Grid_Movie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is3D = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Tabs_Users = new System.Windows.Forms.TabPage();
            this.Users_Panel_UpdatePanel = new System.Windows.Forms.Panel();
            this.Users_Checkbox_IsDeleted = new System.Windows.Forms.CheckBox();
            this.Users_Label_IsDeleted = new System.Windows.Forms.Label();
            this.Users_Combobox_AccessLevel = new System.Windows.Forms.ComboBox();
            this.Users_Label_AccessLevel = new System.Windows.Forms.Label();
            this.Users_Panel_Password = new System.Windows.Forms.Panel();
            this.Users_Textbox_Password = new System.Windows.Forms.TextBox();
            this.Users_Textbox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Users_Label_Password = new System.Windows.Forms.Label();
            this.Users_Label_ConfirmPassword = new System.Windows.Forms.Label();
            this.Users_Textbox_LastLogin = new System.Windows.Forms.TextBox();
            this.Users_Textbox_CreatedOn = new System.Windows.Forms.TextBox();
            this.Users_Textbox_UpdatedOn = new System.Windows.Forms.TextBox();
            this.Users_Label_LastLogin = new System.Windows.Forms.Label();
            this.Users_Label_UpdatedOn = new System.Windows.Forms.Label();
            this.Users_Textbox_UpdatedBy = new System.Windows.Forms.TextBox();
            this.Users_Label_UpdatedBy = new System.Windows.Forms.Label();
            this.Users_Textbox_LastName = new System.Windows.Forms.TextBox();
            this.Users_Button_Insert = new System.Windows.Forms.Button();
            this.Users_Button_Clear = new System.Windows.Forms.Button();
            this.Users_Button_Update = new System.Windows.Forms.Button();
            this.Users_Label_CreatedOn = new System.Windows.Forms.Label();
            this.Users_Textbox_CreatedBy = new System.Windows.Forms.TextBox();
            this.Users_Label_CreatedBy = new System.Windows.Forms.Label();
            this.Users_Textbox_Phone = new System.Windows.Forms.TextBox();
            this.Users_Label_Phone = new System.Windows.Forms.Label();
            this.Users_Textbox_Email = new System.Windows.Forms.TextBox();
            this.Users_Label_Email = new System.Windows.Forms.Label();
            this.Users_Label_LastName = new System.Windows.Forms.Label();
            this.Users_Textbox_FirstName = new System.Windows.Forms.TextBox();
            this.Users_Label_FirstName = new System.Windows.Forms.Label();
            this.Users_Textbox_ID = new System.Windows.Forms.TextBox();
            this.Users_Label_ID = new System.Windows.Forms.Label();
            this.Grid_Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPasswordError)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Loading)).BeginInit();
            this.Tabs_TickeTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketType_Textbox_Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TicketType)).BeginInit();
            this.Tabs_Bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Booking_Textbox_Screening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Booking)).BeginInit();
            this.Tabs_Halls.SuspendLayout();
            this.Hall_Seat_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Hall)).BeginInit();
            this.Tabs_Screenings.SuspendLayout();
            this.ScreeningsPanel_Tabs.SuspendLayout();
            this.ScreeningInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreeningInfo_Textbox_MovieId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreeningInfo_Textbox_HallId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ScreeningInfo)).BeginInit();
            this.Screenings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screening_Textbox_ScreeningInfoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Screening)).BeginInit();
            this.Tabs_Movies.SuspendLayout();
            this.MoviesPanel_Tabs.SuspendLayout();
            this.MoviesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movieinfo_Textbox_LenghtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MovieInfo)).BeginInit();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Textbox_MovieInfoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Movie)).BeginInit();
            this.Tabs.SuspendLayout();
            this.Tabs_Users.SuspendLayout();
            this.Users_Panel_UpdatePanel.SuspendLayout();
            this.Users_Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.LoginPasswordTextbox);
            this.LoginPanel.Controls.Add(this.LoginEmailTextbox);
            this.LoginPanel.Controls.Add(this.LoginPasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginEmailPhoneLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(-1, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(945, 584);
            this.LoginPanel.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Green;
            this.LoginButton.Location = new System.Drawing.Point(676, 281);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(104, 61);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPasswordTextbox
            // 
            this.LoginPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordTextbox.Location = new System.Drawing.Point(454, 218);
            this.LoginPasswordTextbox.Name = "LoginPasswordTextbox";
            this.LoginPasswordTextbox.Size = new System.Drawing.Size(326, 35);
            this.LoginPasswordTextbox.TabIndex = 4;
            this.LoginPasswordTextbox.Text = "Str0ngpass";
            this.LoginPasswordTextbox.UseSystemPasswordChar = true;
            this.LoginPasswordTextbox.TextChanged += new System.EventHandler(this.LoginPasswordTextbox_TextChanged);
            // 
            // LoginEmailTextbox
            // 
            this.LoginEmailTextbox.BackColor = System.Drawing.Color.White;
            this.LoginEmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmailTextbox.Location = new System.Drawing.Point(454, 160);
            this.LoginEmailTextbox.Name = "LoginEmailTextbox";
            this.LoginEmailTextbox.Size = new System.Drawing.Size(326, 35);
            this.LoginEmailTextbox.TabIndex = 3;
            this.LoginEmailTextbox.Text = "system-dmai0913@ucn.dk";
            this.LoginEmailTextbox.TextChanged += new System.EventHandler(this.LoginEmailTextbox_TextChanged);
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginPasswordLabel.Location = new System.Drawing.Point(243, 222);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(134, 31);
            this.LoginPasswordLabel.TabIndex = 2;
            this.LoginPasswordLabel.Text = "Password";
            // 
            // LoginEmailPhoneLabel
            // 
            this.LoginEmailPhoneLabel.AutoSize = true;
            this.LoginEmailPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmailPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginEmailPhoneLabel.Location = new System.Drawing.Point(197, 164);
            this.LoginEmailPhoneLabel.Name = "LoginEmailPhoneLabel";
            this.LoginEmailPhoneLabel.Size = new System.Drawing.Size(197, 31);
            this.LoginEmailPhoneLabel.TabIndex = 1;
            this.LoginEmailPhoneLabel.Text = "Email or Phone";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginLabel.Location = new System.Drawing.Point(400, 25);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(165, 63);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // LoginEmailError
            // 
            this.LoginEmailError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LoginEmailError.ContainerControl = this;
            // 
            // LoginPasswordError
            // 
            this.LoginPasswordError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LoginPasswordError.ContainerControl = this;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.Controls.Add(this.InfoPanel_Right);
            this.InfoPanel.Controls.Add(this.InfoPanel_Wrong);
            this.InfoPanel.Controls.Add(this.InfoPanel_Text);
            this.InfoPanel.Controls.Add(this.InfoPanel_Loading);
            this.InfoPanel.Location = new System.Drawing.Point(-1, 619);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(661, 38);
            this.InfoPanel.TabIndex = 4;
            this.InfoPanel.Visible = false;
            // 
            // InfoPanel_Right
            // 
            this.InfoPanel_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoPanel_Right.Image = global::DedicatedClient.Properties.Resources.right;
            this.InfoPanel_Right.Location = new System.Drawing.Point(4, 0);
            this.InfoPanel_Right.Name = "InfoPanel_Right";
            this.InfoPanel_Right.Size = new System.Drawing.Size(40, 35);
            this.InfoPanel_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPanel_Right.TabIndex = 3;
            this.InfoPanel_Right.TabStop = false;
            this.InfoPanel_Right.Visible = false;
            // 
            // InfoPanel_Wrong
            // 
            this.InfoPanel_Wrong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoPanel_Wrong.Image = global::DedicatedClient.Properties.Resources.wrong;
            this.InfoPanel_Wrong.Location = new System.Drawing.Point(4, 0);
            this.InfoPanel_Wrong.Name = "InfoPanel_Wrong";
            this.InfoPanel_Wrong.Size = new System.Drawing.Size(40, 35);
            this.InfoPanel_Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPanel_Wrong.TabIndex = 2;
            this.InfoPanel_Wrong.TabStop = false;
            this.InfoPanel_Wrong.Visible = false;
            // 
            // InfoPanel_Text
            // 
            this.InfoPanel_Text.AutoSize = true;
            this.InfoPanel_Text.Location = new System.Drawing.Point(55, 12);
            this.InfoPanel_Text.Name = "InfoPanel_Text";
            this.InfoPanel_Text.Size = new System.Drawing.Size(152, 13);
            this.InfoPanel_Text.TabIndex = 1;
            this.InfoPanel_Text.Text = "An error occurred. Please wait.";
            // 
            // InfoPanel_Loading
            // 
            this.InfoPanel_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoPanel_Loading.Image = global::DedicatedClient.Properties.Resources.loading;
            this.InfoPanel_Loading.Location = new System.Drawing.Point(4, 0);
            this.InfoPanel_Loading.Name = "InfoPanel_Loading";
            this.InfoPanel_Loading.Size = new System.Drawing.Size(40, 35);
            this.InfoPanel_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPanel_Loading.TabIndex = 0;
            this.InfoPanel_Loading.TabStop = false;
            // 
            // Label_LoggedInAs
            // 
            this.Label_LoggedInAs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label_LoggedInAs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoggedInAs.Location = new System.Drawing.Point(660, 623);
            this.Label_LoggedInAs.Name = "Label_LoggedInAs";
            this.Label_LoggedInAs.Size = new System.Drawing.Size(280, 28);
            this.Label_LoggedInAs.TabIndex = 4;
            this.Label_LoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tabs_TickeTypes
            // 
            this.Tabs_TickeTypes.Controls.Add(this.label2);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Textbox_Discount);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Button_Insert);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Button_Clear);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Button_Update);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Textbox_TicketType);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Textbox_ID);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Label_TicketType);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Label_Discount);
            this.Tabs_TickeTypes.Controls.Add(this.TicketType_Label_ID);
            this.Tabs_TickeTypes.Controls.Add(this.Grid_TicketType);
            this.Tabs_TickeTypes.Location = new System.Drawing.Point(4, 25);
            this.Tabs_TickeTypes.Name = "Tabs_TickeTypes";
            this.Tabs_TickeTypes.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_TickeTypes.Size = new System.Drawing.Size(937, 584);
            this.Tabs_TickeTypes.TabIndex = 7;
            this.Tabs_TickeTypes.Text = "Ticket Types";
            this.Tabs_TickeTypes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "%";
            // 
            // TicketType_Textbox_Discount
            // 
            this.TicketType_Textbox_Discount.Location = new System.Drawing.Point(121, 96);
            this.TicketType_Textbox_Discount.Name = "TicketType_Textbox_Discount";
            this.TicketType_Textbox_Discount.Size = new System.Drawing.Size(74, 21);
            this.TicketType_Textbox_Discount.TabIndex = 24;
            // 
            // TicketType_Button_Insert
            // 
            this.TicketType_Button_Insert.BackColor = System.Drawing.Color.White;
            this.TicketType_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Button_Insert.Location = new System.Drawing.Point(837, 156);
            this.TicketType_Button_Insert.Name = "TicketType_Button_Insert";
            this.TicketType_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.TicketType_Button_Insert.TabIndex = 21;
            this.TicketType_Button_Insert.Text = "Insert";
            this.TicketType_Button_Insert.UseVisualStyleBackColor = false;
            this.TicketType_Button_Insert.Click += new System.EventHandler(this.TicketType_Button_Insert_Click);
            // 
            // TicketType_Button_Clear
            // 
            this.TicketType_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TicketType_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Button_Clear.Location = new System.Drawing.Point(731, 156);
            this.TicketType_Button_Clear.Name = "TicketType_Button_Clear";
            this.TicketType_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.TicketType_Button_Clear.TabIndex = 23;
            this.TicketType_Button_Clear.Text = "Clear";
            this.TicketType_Button_Clear.UseVisualStyleBackColor = false;
            this.TicketType_Button_Clear.Click += new System.EventHandler(this.TicketType_Button_Clear_Click);
            // 
            // TicketType_Button_Update
            // 
            this.TicketType_Button_Update.BackColor = System.Drawing.Color.White;
            this.TicketType_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Button_Update.Location = new System.Drawing.Point(837, 156);
            this.TicketType_Button_Update.Name = "TicketType_Button_Update";
            this.TicketType_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.TicketType_Button_Update.TabIndex = 22;
            this.TicketType_Button_Update.Text = "Update";
            this.TicketType_Button_Update.UseVisualStyleBackColor = false;
            this.TicketType_Button_Update.Visible = false;
            this.TicketType_Button_Update.Click += new System.EventHandler(this.TicketType_Button_Update_Click);
            // 
            // TicketType_Textbox_TicketType
            // 
            this.TicketType_Textbox_TicketType.Location = new System.Drawing.Point(121, 58);
            this.TicketType_Textbox_TicketType.Name = "TicketType_Textbox_TicketType";
            this.TicketType_Textbox_TicketType.Size = new System.Drawing.Size(149, 21);
            this.TicketType_Textbox_TicketType.TabIndex = 23;
            // 
            // TicketType_Textbox_ID
            // 
            this.TicketType_Textbox_ID.Location = new System.Drawing.Point(121, 18);
            this.TicketType_Textbox_ID.Name = "TicketType_Textbox_ID";
            this.TicketType_Textbox_ID.ReadOnly = true;
            this.TicketType_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.TicketType_Textbox_ID.TabIndex = 22;
            this.TicketType_Textbox_ID.Text = "auto";
            // 
            // TicketType_Label_TicketType
            // 
            this.TicketType_Label_TicketType.AutoSize = true;
            this.TicketType_Label_TicketType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Label_TicketType.Location = new System.Drawing.Point(19, 62);
            this.TicketType_Label_TicketType.Name = "TicketType_Label_TicketType";
            this.TicketType_Label_TicketType.Size = new System.Drawing.Size(87, 17);
            this.TicketType_Label_TicketType.TabIndex = 7;
            this.TicketType_Label_TicketType.Text = "Ticket Type";
            // 
            // TicketType_Label_Discount
            // 
            this.TicketType_Label_Discount.AutoSize = true;
            this.TicketType_Label_Discount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Label_Discount.Location = new System.Drawing.Point(36, 100);
            this.TicketType_Label_Discount.Name = "TicketType_Label_Discount";
            this.TicketType_Label_Discount.Size = new System.Drawing.Size(70, 17);
            this.TicketType_Label_Discount.TabIndex = 3;
            this.TicketType_Label_Discount.Text = "Discount";
            // 
            // TicketType_Label_ID
            // 
            this.TicketType_Label_ID.AutoSize = true;
            this.TicketType_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketType_Label_ID.Location = new System.Drawing.Point(84, 22);
            this.TicketType_Label_ID.Name = "TicketType_Label_ID";
            this.TicketType_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.TicketType_Label_ID.TabIndex = 1;
            this.TicketType_Label_ID.Text = "Id";
            // 
            // Grid_TicketType
            // 
            this.Grid_TicketType.AllowUserToAddRows = false;
            this.Grid_TicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_TicketType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_TicketType.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_TicketType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TicketType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Type,
            this.Discount});
            this.Grid_TicketType.Location = new System.Drawing.Point(0, 218);
            this.Grid_TicketType.MultiSelect = false;
            this.Grid_TicketType.Name = "Grid_TicketType";
            this.Grid_TicketType.ReadOnly = true;
            this.Grid_TicketType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_TicketType.Size = new System.Drawing.Size(936, 342);
            this.Grid_TicketType.TabIndex = 0;
            this.Grid_TicketType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_TicketType_CellClick);
            this.Grid_TicketType.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_TicketType_RowsAdded);
            this.Grid_TicketType.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_TicketType_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Tabs_Bookings
            // 
            this.Tabs_Bookings.Controls.Add(this.Booking_Button_ShowSuggestions);
            this.Tabs_Bookings.Controls.Add(this.label4);
            this.Tabs_Bookings.Controls.Add(this.Booking_Tickets_TicketTypes);
            this.Tabs_Bookings.Controls.Add(this.Booking_Button_ChooseTickets);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_Screening);
            this.Tabs_Bookings.Controls.Add(this.label3);
            this.Tabs_Bookings.Controls.Add(this.Grid_Tickets);
            this.Tabs_Bookings.Controls.Add(this.Booking_Button_Insert);
            this.Tabs_Bookings.Controls.Add(this.Booking_Button_Clear);
            this.Tabs_Bookings.Controls.Add(this.Booking_Checkbox_Canceled);
            this.Tabs_Bookings.Controls.Add(this.Booking_Checkbox_Paid);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_CreatedOn);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_CreatedBy);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_TotalPrice);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_Customer);
            this.Tabs_Bookings.Controls.Add(this.Booking_Textbox_ID);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_CreatedOn);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_CreatedBy);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_Canceled);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_Paid);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_TotalPrice);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_Screening);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_Customer);
            this.Tabs_Bookings.Controls.Add(this.Booking_Label_ID);
            this.Tabs_Bookings.Controls.Add(this.Grid_Booking);
            this.Tabs_Bookings.Location = new System.Drawing.Point(4, 25);
            this.Tabs_Bookings.Name = "Tabs_Bookings";
            this.Tabs_Bookings.Size = new System.Drawing.Size(937, 584);
            this.Tabs_Bookings.TabIndex = 3;
            this.Tabs_Bookings.Text = "Bookings";
            this.Tabs_Bookings.UseVisualStyleBackColor = true;
            // 
            // Booking_Button_ShowSuggestions
            // 
            this.Booking_Button_ShowSuggestions.BackColor = System.Drawing.Color.White;
            this.Booking_Button_ShowSuggestions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Button_ShowSuggestions.Location = new System.Drawing.Point(782, 153);
            this.Booking_Button_ShowSuggestions.Name = "Booking_Button_ShowSuggestions";
            this.Booking_Button_ShowSuggestions.Size = new System.Drawing.Size(120, 51);
            this.Booking_Button_ShowSuggestions.TabIndex = 33;
            this.Booking_Button_ShowSuggestions.Text = "Show Suggestion";
            this.Booking_Button_ShowSuggestions.UseVisualStyleBackColor = false;
            this.Booking_Button_ShowSuggestions.Click += new System.EventHandler(this.Booking_Button_ShowSuggestions_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ticket Types";
            // 
            // Booking_Tickets_TicketTypes
            // 
            this.Booking_Tickets_TicketTypes.AutoSize = true;
            this.Booking_Tickets_TicketTypes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Booking_Tickets_TicketTypes.Location = new System.Drawing.Point(598, 41);
            this.Booking_Tickets_TicketTypes.Name = "Booking_Tickets_TicketTypes";
            this.Booking_Tickets_TicketTypes.Size = new System.Drawing.Size(178, 163);
            this.Booking_Tickets_TicketTypes.TabIndex = 31;
            // 
            // Booking_Button_ChooseTickets
            // 
            this.Booking_Button_ChooseTickets.BackColor = System.Drawing.Color.White;
            this.Booking_Button_ChooseTickets.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Button_ChooseTickets.Location = new System.Drawing.Point(21, 133);
            this.Booking_Button_ChooseTickets.Name = "Booking_Button_ChooseTickets";
            this.Booking_Button_ChooseTickets.Size = new System.Drawing.Size(139, 37);
            this.Booking_Button_ChooseTickets.TabIndex = 30;
            this.Booking_Button_ChooseTickets.Text = "Choose tickets";
            this.Booking_Button_ChooseTickets.UseVisualStyleBackColor = false;
            this.Booking_Button_ChooseTickets.Click += new System.EventHandler(this.Booking_Button_ChooseTickets_Click);
            // 
            // Booking_Textbox_Screening
            // 
            this.Booking_Textbox_Screening.Location = new System.Drawing.Point(110, 95);
            this.Booking_Textbox_Screening.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Booking_Textbox_Screening.Name = "Booking_Textbox_Screening";
            this.Booking_Textbox_Screening.Size = new System.Drawing.Size(74, 21);
            this.Booking_Textbox_Screening.TabIndex = 27;
            this.Booking_Textbox_Screening.ValueChanged += new System.EventHandler(this.Booking_Textbox_Screening_ValueChanged);
            this.Booking_Textbox_Screening.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Booking_Textbox_Screening_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tickets";
            // 
            // Grid_Tickets
            // 
            this.Grid_Tickets.AllowUserToAddRows = false;
            this.Grid_Tickets.AllowUserToDeleteRows = false;
            this.Grid_Tickets.AllowUserToResizeColumns = false;
            this.Grid_Tickets.AllowUserToResizeRows = false;
            this.Grid_Tickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_Tickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grid_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Tickets.ColumnHeadersVisible = false;
            this.Grid_Tickets.GridColor = System.Drawing.Color.White;
            this.Grid_Tickets.Location = new System.Drawing.Point(407, 209);
            this.Grid_Tickets.MultiSelect = false;
            this.Grid_Tickets.Name = "Grid_Tickets";
            this.Grid_Tickets.ReadOnly = true;
            this.Grid_Tickets.RowHeadersVisible = false;
            this.Grid_Tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Tickets.Size = new System.Drawing.Size(527, 372);
            this.Grid_Tickets.TabIndex = 27;
            this.Grid_Tickets.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Tickets_CellMouseClick);
            this.Grid_Tickets.SelectionChanged += new System.EventHandler(this.Grid_Tickets_SelectionChanged);
            // 
            // Booking_Button_Insert
            // 
            this.Booking_Button_Insert.BackColor = System.Drawing.Color.White;
            this.Booking_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Button_Insert.Location = new System.Drawing.Point(21, 133);
            this.Booking_Button_Insert.Name = "Booking_Button_Insert";
            this.Booking_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.Booking_Button_Insert.TabIndex = 24;
            this.Booking_Button_Insert.Text = "Insert";
            this.Booking_Button_Insert.UseVisualStyleBackColor = false;
            this.Booking_Button_Insert.Click += new System.EventHandler(this.Booking_Button_Insert_Click);
            // 
            // Booking_Button_Clear
            // 
            this.Booking_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Booking_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Button_Clear.Location = new System.Drawing.Point(175, 133);
            this.Booking_Button_Clear.Name = "Booking_Button_Clear";
            this.Booking_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.Booking_Button_Clear.TabIndex = 25;
            this.Booking_Button_Clear.Text = "Clear";
            this.Booking_Button_Clear.UseVisualStyleBackColor = false;
            this.Booking_Button_Clear.Click += new System.EventHandler(this.Booking_Button_Clear_Click);
            // 
            // Booking_Checkbox_Canceled
            // 
            this.Booking_Checkbox_Canceled.AutoSize = true;
            this.Booking_Checkbox_Canceled.Location = new System.Drawing.Point(485, 135);
            this.Booking_Checkbox_Canceled.Name = "Booking_Checkbox_Canceled";
            this.Booking_Checkbox_Canceled.Size = new System.Drawing.Size(15, 14);
            this.Booking_Checkbox_Canceled.TabIndex = 32;
            this.Booking_Checkbox_Canceled.UseVisualStyleBackColor = true;
            // 
            // Booking_Checkbox_Paid
            // 
            this.Booking_Checkbox_Paid.AutoSize = true;
            this.Booking_Checkbox_Paid.Location = new System.Drawing.Point(362, 136);
            this.Booking_Checkbox_Paid.Name = "Booking_Checkbox_Paid";
            this.Booking_Checkbox_Paid.Size = new System.Drawing.Size(15, 14);
            this.Booking_Checkbox_Paid.TabIndex = 31;
            this.Booking_Checkbox_Paid.UseVisualStyleBackColor = true;
            // 
            // Booking_Textbox_CreatedOn
            // 
            this.Booking_Textbox_CreatedOn.Location = new System.Drawing.Point(412, 51);
            this.Booking_Textbox_CreatedOn.Name = "Booking_Textbox_CreatedOn";
            this.Booking_Textbox_CreatedOn.ReadOnly = true;
            this.Booking_Textbox_CreatedOn.Size = new System.Drawing.Size(149, 21);
            this.Booking_Textbox_CreatedOn.TabIndex = 29;
            // 
            // Booking_Textbox_CreatedBy
            // 
            this.Booking_Textbox_CreatedBy.Location = new System.Drawing.Point(412, 18);
            this.Booking_Textbox_CreatedBy.Name = "Booking_Textbox_CreatedBy";
            this.Booking_Textbox_CreatedBy.ReadOnly = true;
            this.Booking_Textbox_CreatedBy.Size = new System.Drawing.Size(149, 21);
            this.Booking_Textbox_CreatedBy.TabIndex = 28;
            // 
            // Booking_Textbox_TotalPrice
            // 
            this.Booking_Textbox_TotalPrice.Location = new System.Drawing.Point(412, 91);
            this.Booking_Textbox_TotalPrice.Name = "Booking_Textbox_TotalPrice";
            this.Booking_Textbox_TotalPrice.ReadOnly = true;
            this.Booking_Textbox_TotalPrice.Size = new System.Drawing.Size(149, 21);
            this.Booking_Textbox_TotalPrice.TabIndex = 30;
            // 
            // Booking_Textbox_Customer
            // 
            this.Booking_Textbox_Customer.Location = new System.Drawing.Point(110, 54);
            this.Booking_Textbox_Customer.Name = "Booking_Textbox_Customer";
            this.Booking_Textbox_Customer.Size = new System.Drawing.Size(149, 21);
            this.Booking_Textbox_Customer.TabIndex = 26;
            // 
            // Booking_Textbox_ID
            // 
            this.Booking_Textbox_ID.Location = new System.Drawing.Point(110, 21);
            this.Booking_Textbox_ID.Name = "Booking_Textbox_ID";
            this.Booking_Textbox_ID.ReadOnly = true;
            this.Booking_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.Booking_Textbox_ID.TabIndex = 25;
            this.Booking_Textbox_ID.Text = "auto";
            // 
            // Booking_Label_CreatedOn
            // 
            this.Booking_Label_CreatedOn.AutoSize = true;
            this.Booking_Label_CreatedOn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_CreatedOn.Location = new System.Drawing.Point(320, 55);
            this.Booking_Label_CreatedOn.Name = "Booking_Label_CreatedOn";
            this.Booking_Label_CreatedOn.Size = new System.Drawing.Size(88, 17);
            this.Booking_Label_CreatedOn.TabIndex = 19;
            this.Booking_Label_CreatedOn.Text = "Created On";
            // 
            // Booking_Label_CreatedBy
            // 
            this.Booking_Label_CreatedBy.AutoSize = true;
            this.Booking_Label_CreatedBy.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_CreatedBy.Location = new System.Drawing.Point(320, 22);
            this.Booking_Label_CreatedBy.Name = "Booking_Label_CreatedBy";
            this.Booking_Label_CreatedBy.Size = new System.Drawing.Size(86, 17);
            this.Booking_Label_CreatedBy.TabIndex = 17;
            this.Booking_Label_CreatedBy.Text = "Created By";
            // 
            // Booking_Label_Canceled
            // 
            this.Booking_Label_Canceled.AutoSize = true;
            this.Booking_Label_Canceled.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_Canceled.Location = new System.Drawing.Point(409, 134);
            this.Booking_Label_Canceled.Name = "Booking_Label_Canceled";
            this.Booking_Label_Canceled.Size = new System.Drawing.Size(70, 17);
            this.Booking_Label_Canceled.TabIndex = 16;
            this.Booking_Label_Canceled.Text = "Canceled";
            // 
            // Booking_Label_Paid
            // 
            this.Booking_Label_Paid.AutoSize = true;
            this.Booking_Label_Paid.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_Paid.Location = new System.Drawing.Point(320, 133);
            this.Booking_Label_Paid.Name = "Booking_Label_Paid";
            this.Booking_Label_Paid.Size = new System.Drawing.Size(36, 17);
            this.Booking_Label_Paid.TabIndex = 15;
            this.Booking_Label_Paid.Text = "Paid";
            // 
            // Booking_Label_TotalPrice
            // 
            this.Booking_Label_TotalPrice.AutoSize = true;
            this.Booking_Label_TotalPrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_TotalPrice.Location = new System.Drawing.Point(320, 95);
            this.Booking_Label_TotalPrice.Name = "Booking_Label_TotalPrice";
            this.Booking_Label_TotalPrice.Size = new System.Drawing.Size(78, 17);
            this.Booking_Label_TotalPrice.TabIndex = 13;
            this.Booking_Label_TotalPrice.Text = "Total Price";
            // 
            // Booking_Label_Screening
            // 
            this.Booking_Label_Screening.AutoSize = true;
            this.Booking_Label_Screening.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_Screening.Location = new System.Drawing.Point(18, 95);
            this.Booking_Label_Screening.Name = "Booking_Label_Screening";
            this.Booking_Label_Screening.Size = new System.Drawing.Size(77, 17);
            this.Booking_Label_Screening.TabIndex = 11;
            this.Booking_Label_Screening.Text = "Screening";
            // 
            // Booking_Label_Customer
            // 
            this.Booking_Label_Customer.AutoSize = true;
            this.Booking_Label_Customer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_Customer.Location = new System.Drawing.Point(18, 58);
            this.Booking_Label_Customer.Name = "Booking_Label_Customer";
            this.Booking_Label_Customer.Size = new System.Drawing.Size(77, 17);
            this.Booking_Label_Customer.TabIndex = 9;
            this.Booking_Label_Customer.Text = "Customer";
            // 
            // Booking_Label_ID
            // 
            this.Booking_Label_ID.AutoSize = true;
            this.Booking_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label_ID.Location = new System.Drawing.Point(73, 25);
            this.Booking_Label_ID.Name = "Booking_Label_ID";
            this.Booking_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.Booking_Label_ID.TabIndex = 3;
            this.Booking_Label_ID.Text = "Id";
            // 
            // Grid_Booking
            // 
            this.Grid_Booking.AllowUserToAddRows = false;
            this.Grid_Booking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Grid_Booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.BookingCustomer,
            this.Booking_Screening});
            this.Grid_Booking.Location = new System.Drawing.Point(0, 226);
            this.Grid_Booking.MultiSelect = false;
            this.Grid_Booking.Name = "Grid_Booking";
            this.Grid_Booking.ReadOnly = true;
            this.Grid_Booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Booking.Size = new System.Drawing.Size(342, 358);
            this.Grid_Booking.TabIndex = 0;
            this.Grid_Booking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Booking_CellClick);
            this.Grid_Booking.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_Booking_RowsAdded);
            this.Grid_Booking.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_Booking_UserDeletingRow);
            // 
            // BookingId
            // 
            this.BookingId.HeaderText = "ID";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            // 
            // BookingCustomer
            // 
            this.BookingCustomer.HeaderText = "Customer";
            this.BookingCustomer.Name = "BookingCustomer";
            this.BookingCustomer.ReadOnly = true;
            // 
            // Booking_Screening
            // 
            this.Booking_Screening.HeaderText = "Screening";
            this.Booking_Screening.Name = "Booking_Screening";
            this.Booking_Screening.ReadOnly = true;
            // 
            // Tabs_Halls
            // 
            this.Tabs_Halls.Controls.Add(this.Hall_Seat_Panel);
            this.Tabs_Halls.Controls.Add(this.Hall_Textbox_Name);
            this.Tabs_Halls.Controls.Add(this.Hall_Textbox_ID);
            this.Tabs_Halls.Controls.Add(this.Hall_Button_Insert);
            this.Tabs_Halls.Controls.Add(this.Hall_Button_Clear);
            this.Tabs_Halls.Controls.Add(this.Hall_Button_Update);
            this.Tabs_Halls.Controls.Add(this.Hall_Label_Name);
            this.Tabs_Halls.Controls.Add(this.Hall_Label_ID);
            this.Tabs_Halls.Controls.Add(this.Grid_Hall);
            this.Tabs_Halls.Location = new System.Drawing.Point(4, 25);
            this.Tabs_Halls.Name = "Tabs_Halls";
            this.Tabs_Halls.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_Halls.Size = new System.Drawing.Size(937, 584);
            this.Tabs_Halls.TabIndex = 5;
            this.Tabs_Halls.Text = "Halls";
            this.Tabs_Halls.UseVisualStyleBackColor = true;
            // 
            // Hall_Seat_Panel
            // 
            this.Hall_Seat_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hall_Seat_Panel.Controls.Add(this.Grid_Seats);
            this.Hall_Seat_Panel.Controls.Add(this.Hall_Seat_Legend_HowToUse);
            this.Hall_Seat_Panel.Controls.Add(this.Hall_Seat_Seats_Legend);
            this.Hall_Seat_Panel.Controls.Add(this.Hall_Seat_Title);
            this.Hall_Seat_Panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Hall_Seat_Panel.Location = new System.Drawing.Point(312, 6);
            this.Hall_Seat_Panel.Name = "Hall_Seat_Panel";
            this.Hall_Seat_Panel.Size = new System.Drawing.Size(622, 583);
            this.Hall_Seat_Panel.TabIndex = 25;
            // 
            // Grid_Seats
            // 
            this.Grid_Seats.AllowUserToAddRows = false;
            this.Grid_Seats.AllowUserToDeleteRows = false;
            this.Grid_Seats.AllowUserToResizeColumns = false;
            this.Grid_Seats.AllowUserToResizeRows = false;
            this.Grid_Seats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Seats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_Seats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grid_Seats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Seats.ColumnHeadersVisible = false;
            this.Grid_Seats.GridColor = System.Drawing.Color.White;
            this.Grid_Seats.Location = new System.Drawing.Point(4, 60);
            this.Grid_Seats.MultiSelect = false;
            this.Grid_Seats.Name = "Grid_Seats";
            this.Grid_Seats.ReadOnly = true;
            this.Grid_Seats.RowHeadersVisible = false;
            this.Grid_Seats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Seats.Size = new System.Drawing.Size(617, 431);
            this.Grid_Seats.TabIndex = 0;
            this.Grid_Seats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Seats_CellClick);
            this.Grid_Seats.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Seats_CellMouseEnter);
            this.Grid_Seats.SelectionChanged += new System.EventHandler(this.Grid_Seats_SelectionChanged);
            this.Grid_Seats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_Seats_MouseDown);
            this.Grid_Seats.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Grid_Seats_MouseUp);
            // 
            // Hall_Seat_Legend_HowToUse
            // 
            this.Hall_Seat_Legend_HowToUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hall_Seat_Legend_HowToUse.AutoSize = true;
            this.Hall_Seat_Legend_HowToUse.Location = new System.Drawing.Point(335, 44);
            this.Hall_Seat_Legend_HowToUse.Name = "Hall_Seat_Legend_HowToUse";
            this.Hall_Seat_Legend_HowToUse.Size = new System.Drawing.Size(284, 13);
            this.Hall_Seat_Legend_HowToUse.TabIndex = 0;
            this.Hall_Seat_Legend_HowToUse.Text = "Select a color from legend and design the seats.";
            // 
            // Hall_Seat_Seats_Legend
            // 
            this.Hall_Seat_Seats_Legend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hall_Seat_Seats_Legend.Location = new System.Drawing.Point(5, 497);
            this.Hall_Seat_Seats_Legend.Name = "Hall_Seat_Seats_Legend";
            this.Hall_Seat_Seats_Legend.Size = new System.Drawing.Size(616, 65);
            this.Hall_Seat_Seats_Legend.TabIndex = 2;
            // 
            // Hall_Seat_Title
            // 
            this.Hall_Seat_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Hall_Seat_Title.AutoSize = true;
            this.Hall_Seat_Title.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Seat_Title.Location = new System.Drawing.Point(225, 5);
            this.Hall_Seat_Title.Name = "Hall_Seat_Title";
            this.Hall_Seat_Title.Size = new System.Drawing.Size(189, 29);
            this.Hall_Seat_Title.TabIndex = 0;
            this.Hall_Seat_Title.Text = "Seats designer";
            // 
            // Hall_Textbox_Name
            // 
            this.Hall_Textbox_Name.Location = new System.Drawing.Point(89, 55);
            this.Hall_Textbox_Name.Name = "Hall_Textbox_Name";
            this.Hall_Textbox_Name.Size = new System.Drawing.Size(149, 21);
            this.Hall_Textbox_Name.TabIndex = 21;
            // 
            // Hall_Textbox_ID
            // 
            this.Hall_Textbox_ID.Location = new System.Drawing.Point(89, 18);
            this.Hall_Textbox_ID.Name = "Hall_Textbox_ID";
            this.Hall_Textbox_ID.ReadOnly = true;
            this.Hall_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.Hall_Textbox_ID.TabIndex = 20;
            this.Hall_Textbox_ID.Text = "auto";
            // 
            // Hall_Button_Insert
            // 
            this.Hall_Button_Insert.BackColor = System.Drawing.Color.White;
            this.Hall_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Button_Insert.Location = new System.Drawing.Point(141, 99);
            this.Hall_Button_Insert.Name = "Hall_Button_Insert";
            this.Hall_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.Hall_Button_Insert.TabIndex = 21;
            this.Hall_Button_Insert.Text = "Insert";
            this.Hall_Button_Insert.UseVisualStyleBackColor = false;
            this.Hall_Button_Insert.Click += new System.EventHandler(this.Hall_Button_Insert_Click);
            // 
            // Hall_Button_Clear
            // 
            this.Hall_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Hall_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Button_Clear.Location = new System.Drawing.Point(23, 99);
            this.Hall_Button_Clear.Name = "Hall_Button_Clear";
            this.Hall_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.Hall_Button_Clear.TabIndex = 23;
            this.Hall_Button_Clear.Text = "Clear";
            this.Hall_Button_Clear.UseVisualStyleBackColor = false;
            this.Hall_Button_Clear.Click += new System.EventHandler(this.Hall_Button_Clear_Click);
            // 
            // Hall_Button_Update
            // 
            this.Hall_Button_Update.BackColor = System.Drawing.Color.White;
            this.Hall_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Button_Update.Location = new System.Drawing.Point(141, 99);
            this.Hall_Button_Update.Name = "Hall_Button_Update";
            this.Hall_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.Hall_Button_Update.TabIndex = 22;
            this.Hall_Button_Update.Text = "Update";
            this.Hall_Button_Update.UseVisualStyleBackColor = false;
            this.Hall_Button_Update.Visible = false;
            this.Hall_Button_Update.Click += new System.EventHandler(this.Hall_Button_Update_Click);
            // 
            // Hall_Label_Name
            // 
            this.Hall_Label_Name.AutoSize = true;
            this.Hall_Label_Name.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Label_Name.Location = new System.Drawing.Point(20, 55);
            this.Hall_Label_Name.Name = "Hall_Label_Name";
            this.Hall_Label_Name.Size = new System.Drawing.Size(47, 17);
            this.Hall_Label_Name.TabIndex = 3;
            this.Hall_Label_Name.Text = "Name";
            // 
            // Hall_Label_ID
            // 
            this.Hall_Label_ID.AutoSize = true;
            this.Hall_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall_Label_ID.Location = new System.Drawing.Point(45, 22);
            this.Hall_Label_ID.Name = "Hall_Label_ID";
            this.Hall_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.Hall_Label_ID.TabIndex = 1;
            this.Hall_Label_ID.Text = "Id";
            // 
            // Grid_Hall
            // 
            this.Grid_Hall.AllowUserToAddRows = false;
            this.Grid_Hall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Grid_Hall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Hall.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_Hall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Hall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.HallName});
            this.Grid_Hall.Location = new System.Drawing.Point(0, 218);
            this.Grid_Hall.MultiSelect = false;
            this.Grid_Hall.Name = "Grid_Hall";
            this.Grid_Hall.ReadOnly = true;
            this.Grid_Hall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Hall.Size = new System.Drawing.Size(306, 371);
            this.Grid_Hall.TabIndex = 0;
            this.Grid_Hall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Hall_CellClick);
            this.Grid_Hall.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_Hall_RowsAdded);
            this.Grid_Hall.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_Hall_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // HallName
            // 
            this.HallName.HeaderText = "Name";
            this.HallName.Name = "HallName";
            this.HallName.ReadOnly = true;
            // 
            // Tabs_Screenings
            // 
            this.Tabs_Screenings.Controls.Add(this.ScreeningsPanel_Tabs);
            this.Tabs_Screenings.Location = new System.Drawing.Point(4, 25);
            this.Tabs_Screenings.Name = "Tabs_Screenings";
            this.Tabs_Screenings.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_Screenings.Size = new System.Drawing.Size(937, 584);
            this.Tabs_Screenings.TabIndex = 1;
            this.Tabs_Screenings.Text = "Screenings";
            this.Tabs_Screenings.UseVisualStyleBackColor = true;
            // 
            // ScreeningsPanel_Tabs
            // 
            this.ScreeningsPanel_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreeningsPanel_Tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.ScreeningsPanel_Tabs.Controls.Add(this.ScreeningInfo);
            this.ScreeningsPanel_Tabs.Controls.Add(this.Screenings);
            this.ScreeningsPanel_Tabs.Location = new System.Drawing.Point(-4, -1);
            this.ScreeningsPanel_Tabs.Name = "ScreeningsPanel_Tabs";
            this.ScreeningsPanel_Tabs.SelectedIndex = 0;
            this.ScreeningsPanel_Tabs.Size = new System.Drawing.Size(945, 556);
            this.ScreeningsPanel_Tabs.TabIndex = 1;
            this.ScreeningsPanel_Tabs.SelectedIndexChanged += new System.EventHandler(this.ScreeningsPanel_Tabs_SelectedIndexChanged);
            // 
            // ScreeningInfo
            // 
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Button_Insert);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Textbox_MovieId);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Button_Clear);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Button_Update);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Textbox_HallId);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Label_HallId);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Textbox_TicketPrice);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Label_TicketPrice);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Label_MovieId);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Textbox_ID);
            this.ScreeningInfo.Controls.Add(this.ScreeningInfo_Label_ID);
            this.ScreeningInfo.Controls.Add(this.Grid_ScreeningInfo);
            this.ScreeningInfo.Location = new System.Drawing.Point(4, 25);
            this.ScreeningInfo.Name = "ScreeningInfo";
            this.ScreeningInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ScreeningInfo.Size = new System.Drawing.Size(937, 527);
            this.ScreeningInfo.TabIndex = 0;
            this.ScreeningInfo.Text = "Screening Information";
            this.ScreeningInfo.UseVisualStyleBackColor = true;
            // 
            // ScreeningInfo_Button_Insert
            // 
            this.ScreeningInfo_Button_Insert.BackColor = System.Drawing.Color.White;
            this.ScreeningInfo_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Button_Insert.Location = new System.Drawing.Point(837, 156);
            this.ScreeningInfo_Button_Insert.Name = "ScreeningInfo_Button_Insert";
            this.ScreeningInfo_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.ScreeningInfo_Button_Insert.TabIndex = 21;
            this.ScreeningInfo_Button_Insert.Text = "Insert";
            this.ScreeningInfo_Button_Insert.UseVisualStyleBackColor = false;
            this.ScreeningInfo_Button_Insert.Click += new System.EventHandler(this.ScreeningInfo_Button_Insert_Click);
            // 
            // ScreeningInfo_Textbox_MovieId
            // 
            this.ScreeningInfo_Textbox_MovieId.Location = new System.Drawing.Point(121, 55);
            this.ScreeningInfo_Textbox_MovieId.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.ScreeningInfo_Textbox_MovieId.Name = "ScreeningInfo_Textbox_MovieId";
            this.ScreeningInfo_Textbox_MovieId.Size = new System.Drawing.Size(74, 21);
            this.ScreeningInfo_Textbox_MovieId.TabIndex = 14;
            // 
            // ScreeningInfo_Button_Clear
            // 
            this.ScreeningInfo_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ScreeningInfo_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Button_Clear.Location = new System.Drawing.Point(731, 156);
            this.ScreeningInfo_Button_Clear.Name = "ScreeningInfo_Button_Clear";
            this.ScreeningInfo_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.ScreeningInfo_Button_Clear.TabIndex = 23;
            this.ScreeningInfo_Button_Clear.Text = "Clear";
            this.ScreeningInfo_Button_Clear.UseVisualStyleBackColor = false;
            this.ScreeningInfo_Button_Clear.Click += new System.EventHandler(this.ScreeningInfo_Button_Clear_Click);
            // 
            // ScreeningInfo_Button_Update
            // 
            this.ScreeningInfo_Button_Update.BackColor = System.Drawing.Color.White;
            this.ScreeningInfo_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Button_Update.Location = new System.Drawing.Point(837, 156);
            this.ScreeningInfo_Button_Update.Name = "ScreeningInfo_Button_Update";
            this.ScreeningInfo_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.ScreeningInfo_Button_Update.TabIndex = 22;
            this.ScreeningInfo_Button_Update.Text = "Update";
            this.ScreeningInfo_Button_Update.UseVisualStyleBackColor = false;
            this.ScreeningInfo_Button_Update.Visible = false;
            this.ScreeningInfo_Button_Update.Click += new System.EventHandler(this.ScreeningInfo_Button_Update_Click);
            // 
            // ScreeningInfo_Textbox_HallId
            // 
            this.ScreeningInfo_Textbox_HallId.Location = new System.Drawing.Point(121, 91);
            this.ScreeningInfo_Textbox_HallId.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.ScreeningInfo_Textbox_HallId.Name = "ScreeningInfo_Textbox_HallId";
            this.ScreeningInfo_Textbox_HallId.Size = new System.Drawing.Size(74, 21);
            this.ScreeningInfo_Textbox_HallId.TabIndex = 15;
            // 
            // ScreeningInfo_Label_HallId
            // 
            this.ScreeningInfo_Label_HallId.AutoSize = true;
            this.ScreeningInfo_Label_HallId.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Label_HallId.Location = new System.Drawing.Point(55, 91);
            this.ScreeningInfo_Label_HallId.Name = "ScreeningInfo_Label_HallId";
            this.ScreeningInfo_Label_HallId.Size = new System.Drawing.Size(51, 17);
            this.ScreeningInfo_Label_HallId.TabIndex = 9;
            this.ScreeningInfo_Label_HallId.Text = "Hall Id";
            // 
            // ScreeningInfo_Textbox_TicketPrice
            // 
            this.ScreeningInfo_Textbox_TicketPrice.Location = new System.Drawing.Point(121, 123);
            this.ScreeningInfo_Textbox_TicketPrice.Name = "ScreeningInfo_Textbox_TicketPrice";
            this.ScreeningInfo_Textbox_TicketPrice.Size = new System.Drawing.Size(149, 21);
            this.ScreeningInfo_Textbox_TicketPrice.TabIndex = 16;
            // 
            // ScreeningInfo_Label_TicketPrice
            // 
            this.ScreeningInfo_Label_TicketPrice.AutoSize = true;
            this.ScreeningInfo_Label_TicketPrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Label_TicketPrice.Location = new System.Drawing.Point(20, 127);
            this.ScreeningInfo_Label_TicketPrice.Name = "ScreeningInfo_Label_TicketPrice";
            this.ScreeningInfo_Label_TicketPrice.Size = new System.Drawing.Size(86, 17);
            this.ScreeningInfo_Label_TicketPrice.TabIndex = 7;
            this.ScreeningInfo_Label_TicketPrice.Text = "Ticket Price";
            // 
            // ScreeningInfo_Label_MovieId
            // 
            this.ScreeningInfo_Label_MovieId.AutoSize = true;
            this.ScreeningInfo_Label_MovieId.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Label_MovieId.Location = new System.Drawing.Point(40, 55);
            this.ScreeningInfo_Label_MovieId.Name = "ScreeningInfo_Label_MovieId";
            this.ScreeningInfo_Label_MovieId.Size = new System.Drawing.Size(66, 17);
            this.ScreeningInfo_Label_MovieId.TabIndex = 3;
            this.ScreeningInfo_Label_MovieId.Text = "Movie Id";
            // 
            // ScreeningInfo_Textbox_ID
            // 
            this.ScreeningInfo_Textbox_ID.Location = new System.Drawing.Point(121, 18);
            this.ScreeningInfo_Textbox_ID.Name = "ScreeningInfo_Textbox_ID";
            this.ScreeningInfo_Textbox_ID.ReadOnly = true;
            this.ScreeningInfo_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.ScreeningInfo_Textbox_ID.TabIndex = 13;
            this.ScreeningInfo_Textbox_ID.Text = "auto";
            // 
            // ScreeningInfo_Label_ID
            // 
            this.ScreeningInfo_Label_ID.AutoSize = true;
            this.ScreeningInfo_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningInfo_Label_ID.Location = new System.Drawing.Point(84, 22);
            this.ScreeningInfo_Label_ID.Name = "ScreeningInfo_Label_ID";
            this.ScreeningInfo_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.ScreeningInfo_Label_ID.TabIndex = 1;
            this.ScreeningInfo_Label_ID.Text = "Id";
            // 
            // Grid_ScreeningInfo
            // 
            this.Grid_ScreeningInfo.AllowUserToAddRows = false;
            this.Grid_ScreeningInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_ScreeningInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ScreeningInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_ScreeningInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ScreeningInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MovieId,
            this.HallId,
            this.TicketPrice});
            this.Grid_ScreeningInfo.Location = new System.Drawing.Point(0, 218);
            this.Grid_ScreeningInfo.MultiSelect = false;
            this.Grid_ScreeningInfo.Name = "Grid_ScreeningInfo";
            this.Grid_ScreeningInfo.ReadOnly = true;
            this.Grid_ScreeningInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ScreeningInfo.Size = new System.Drawing.Size(936, 314);
            this.Grid_ScreeningInfo.TabIndex = 0;
            this.Grid_ScreeningInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ScreeningInfo_CellClick);
            this.Grid_ScreeningInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_ScreeningInfo_RowsAdded);
            this.Grid_ScreeningInfo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_ScreeningInfo_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MovieId
            // 
            this.MovieId.HeaderText = "Movie";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            // 
            // HallId
            // 
            this.HallId.HeaderText = "Hall";
            this.HallId.Name = "HallId";
            this.HallId.ReadOnly = true;
            // 
            // TicketPrice
            // 
            this.TicketPrice.HeaderText = "Ticket Price";
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            // 
            // Screenings
            // 
            this.Screenings.Controls.Add(this.Screenings_Button_Insert);
            this.Screenings.Controls.Add(this.Screening_Date);
            this.Screenings.Controls.Add(this.Screening_Textbox_ScreeningInfoId);
            this.Screenings.Controls.Add(this.Screenings_Button_Clear);
            this.Screenings.Controls.Add(this.Screenings_Button_Update);
            this.Screenings.Controls.Add(this.Screening_Label_ScreeningDate);
            this.Screenings.Controls.Add(this.Screening_Label_ScreeningInfoId);
            this.Screenings.Controls.Add(this.Screening_Textbox_ID);
            this.Screenings.Controls.Add(this.Screening_Label_ID);
            this.Screenings.Controls.Add(this.Grid_Screening);
            this.Screenings.Location = new System.Drawing.Point(4, 25);
            this.Screenings.Name = "Screenings";
            this.Screenings.Padding = new System.Windows.Forms.Padding(3);
            this.Screenings.Size = new System.Drawing.Size(937, 527);
            this.Screenings.TabIndex = 2;
            this.Screenings.Text = "Screenings";
            this.Screenings.UseVisualStyleBackColor = true;
            // 
            // Screenings_Button_Insert
            // 
            this.Screenings_Button_Insert.BackColor = System.Drawing.Color.White;
            this.Screenings_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenings_Button_Insert.Location = new System.Drawing.Point(837, 156);
            this.Screenings_Button_Insert.Name = "Screenings_Button_Insert";
            this.Screenings_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.Screenings_Button_Insert.TabIndex = 21;
            this.Screenings_Button_Insert.Text = "Insert";
            this.Screenings_Button_Insert.UseVisualStyleBackColor = false;
            this.Screenings_Button_Insert.Click += new System.EventHandler(this.Screenings_Button_Insert_Click);
            // 
            // Screening_Date
            // 
            this.Screening_Date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Screening_Date.Location = new System.Drawing.Point(164, 84);
            this.Screening_Date.Name = "Screening_Date";
            this.Screening_Date.Size = new System.Drawing.Size(113, 21);
            this.Screening_Date.TabIndex = 19;
            // 
            // Screening_Textbox_ScreeningInfoId
            // 
            this.Screening_Textbox_ScreeningInfoId.Location = new System.Drawing.Point(164, 51);
            this.Screening_Textbox_ScreeningInfoId.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Screening_Textbox_ScreeningInfoId.Name = "Screening_Textbox_ScreeningInfoId";
            this.Screening_Textbox_ScreeningInfoId.Size = new System.Drawing.Size(74, 21);
            this.Screening_Textbox_ScreeningInfoId.TabIndex = 18;
            // 
            // Screenings_Button_Clear
            // 
            this.Screenings_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Screenings_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenings_Button_Clear.Location = new System.Drawing.Point(731, 156);
            this.Screenings_Button_Clear.Name = "Screenings_Button_Clear";
            this.Screenings_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.Screenings_Button_Clear.TabIndex = 23;
            this.Screenings_Button_Clear.Text = "Clear";
            this.Screenings_Button_Clear.UseVisualStyleBackColor = false;
            this.Screenings_Button_Clear.Click += new System.EventHandler(this.Screenings_Button_Clear_Click);
            // 
            // Screenings_Button_Update
            // 
            this.Screenings_Button_Update.BackColor = System.Drawing.Color.White;
            this.Screenings_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenings_Button_Update.Location = new System.Drawing.Point(837, 156);
            this.Screenings_Button_Update.Name = "Screenings_Button_Update";
            this.Screenings_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.Screenings_Button_Update.TabIndex = 22;
            this.Screenings_Button_Update.Text = "Update";
            this.Screenings_Button_Update.UseVisualStyleBackColor = false;
            this.Screenings_Button_Update.Visible = false;
            this.Screenings_Button_Update.Click += new System.EventHandler(this.Screenings_Button_Update_Click);
            // 
            // Screening_Label_ScreeningDate
            // 
            this.Screening_Label_ScreeningDate.AutoSize = true;
            this.Screening_Label_ScreeningDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screening_Label_ScreeningDate.Location = new System.Drawing.Point(108, 88);
            this.Screening_Label_ScreeningDate.Name = "Screening_Label_ScreeningDate";
            this.Screening_Label_ScreeningDate.Size = new System.Drawing.Size(41, 17);
            this.Screening_Label_ScreeningDate.TabIndex = 9;
            this.Screening_Label_ScreeningDate.Text = "Date";
            // 
            // Screening_Label_ScreeningInfoId
            // 
            this.Screening_Label_ScreeningInfoId.AutoSize = true;
            this.Screening_Label_ScreeningInfoId.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screening_Label_ScreeningInfoId.Location = new System.Drawing.Point(20, 55);
            this.Screening_Label_ScreeningInfoId.Name = "Screening_Label_ScreeningInfoId";
            this.Screening_Label_ScreeningInfoId.Size = new System.Drawing.Size(129, 17);
            this.Screening_Label_ScreeningInfoId.TabIndex = 3;
            this.Screening_Label_ScreeningInfoId.Text = "Screening Info Id";
            // 
            // Screening_Textbox_ID
            // 
            this.Screening_Textbox_ID.Location = new System.Drawing.Point(164, 18);
            this.Screening_Textbox_ID.Name = "Screening_Textbox_ID";
            this.Screening_Textbox_ID.ReadOnly = true;
            this.Screening_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.Screening_Textbox_ID.TabIndex = 17;
            this.Screening_Textbox_ID.Text = "auto";
            // 
            // Screening_Label_ID
            // 
            this.Screening_Label_ID.AutoSize = true;
            this.Screening_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screening_Label_ID.Location = new System.Drawing.Point(127, 22);
            this.Screening_Label_ID.Name = "Screening_Label_ID";
            this.Screening_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.Screening_Label_ID.TabIndex = 1;
            this.Screening_Label_ID.Text = "Id";
            // 
            // Grid_Screening
            // 
            this.Grid_Screening.AllowUserToAddRows = false;
            this.Grid_Screening.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Screening.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Screening.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_Screening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Screening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ScreeningInfoId,
            this.ScreeningDateTime});
            this.Grid_Screening.Location = new System.Drawing.Point(0, 218);
            this.Grid_Screening.MultiSelect = false;
            this.Grid_Screening.Name = "Grid_Screening";
            this.Grid_Screening.ReadOnly = true;
            this.Grid_Screening.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Screening.Size = new System.Drawing.Size(936, 314);
            this.Grid_Screening.TabIndex = 0;
            this.Grid_Screening.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Screening_CellClick);
            this.Grid_Screening.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_Screening_RowsAdded);
            this.Grid_Screening.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_Screening_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ScreeningInfoId
            // 
            this.ScreeningInfoId.HeaderText = "Screening Info Id";
            this.ScreeningInfoId.Name = "ScreeningInfoId";
            this.ScreeningInfoId.ReadOnly = true;
            // 
            // ScreeningDateTime
            // 
            this.ScreeningDateTime.HeaderText = "Screening Date";
            this.ScreeningDateTime.Name = "ScreeningDateTime";
            this.ScreeningDateTime.ReadOnly = true;
            // 
            // Tabs_Movies
            // 
            this.Tabs_Movies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tabs_Movies.Controls.Add(this.MoviesPanel_Tabs);
            this.Tabs_Movies.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs_Movies.Location = new System.Drawing.Point(4, 25);
            this.Tabs_Movies.Name = "Tabs_Movies";
            this.Tabs_Movies.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_Movies.Size = new System.Drawing.Size(937, 584);
            this.Tabs_Movies.TabIndex = 0;
            this.Tabs_Movies.Text = "Movies";
            this.Tabs_Movies.UseVisualStyleBackColor = true;
            // 
            // MoviesPanel_Tabs
            // 
            this.MoviesPanel_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesPanel_Tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.MoviesPanel_Tabs.Controls.Add(this.MoviesInfo);
            this.MoviesPanel_Tabs.Controls.Add(this.Movies);
            this.MoviesPanel_Tabs.Location = new System.Drawing.Point(-4, 2);
            this.MoviesPanel_Tabs.Name = "MoviesPanel_Tabs";
            this.MoviesPanel_Tabs.SelectedIndex = 0;
            this.MoviesPanel_Tabs.Size = new System.Drawing.Size(945, 556);
            this.MoviesPanel_Tabs.TabIndex = 0;
            this.MoviesPanel_Tabs.SelectedIndexChanged += new System.EventHandler(this.MoviesPanel_Tabs_SelectedIndexChanged);
            // 
            // MoviesInfo
            // 
            this.MoviesInfo.Controls.Add(this.MovieInfo_Button_Insert);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Button_Clear);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Button_Update);
            this.MoviesInfo.Controls.Add(this.Movieinfo_Textbox_LenghtTime);
            this.MoviesInfo.Controls.Add(this.label1);
            this.MoviesInfo.Controls.Add(this.MovieInfo_DatePicker_ReleaseDate);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_ReleaseDate);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Combobox_AgeRestriction);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_AgeRestriction);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Genre);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Genre);
            this.MoviesInfo.Controls.Add(this.Movieinfo_Label_LenghtTime);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Actors);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Actors);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Directors);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Directors);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Description);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Description);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Title);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Title);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Textbox_Id);
            this.MoviesInfo.Controls.Add(this.MovieInfo_Label_Id);
            this.MoviesInfo.Controls.Add(this.Grid_MovieInfo);
            this.MoviesInfo.Location = new System.Drawing.Point(4, 25);
            this.MoviesInfo.Name = "MoviesInfo";
            this.MoviesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesInfo.Size = new System.Drawing.Size(937, 527);
            this.MoviesInfo.TabIndex = 0;
            this.MoviesInfo.Text = "Movies Information";
            this.MoviesInfo.UseVisualStyleBackColor = true;
            // 
            // MovieInfo_Button_Insert
            // 
            this.MovieInfo_Button_Insert.BackColor = System.Drawing.Color.White;
            this.MovieInfo_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Button_Insert.Location = new System.Drawing.Point(837, 156);
            this.MovieInfo_Button_Insert.Name = "MovieInfo_Button_Insert";
            this.MovieInfo_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.MovieInfo_Button_Insert.TabIndex = 21;
            this.MovieInfo_Button_Insert.Text = "Insert";
            this.MovieInfo_Button_Insert.UseVisualStyleBackColor = false;
            this.MovieInfo_Button_Insert.Click += new System.EventHandler(this.MovieInfo_Button_Insert_Click);
            // 
            // MovieInfo_Button_Clear
            // 
            this.MovieInfo_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MovieInfo_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Button_Clear.Location = new System.Drawing.Point(731, 156);
            this.MovieInfo_Button_Clear.Name = "MovieInfo_Button_Clear";
            this.MovieInfo_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.MovieInfo_Button_Clear.TabIndex = 23;
            this.MovieInfo_Button_Clear.Text = "Clear";
            this.MovieInfo_Button_Clear.UseVisualStyleBackColor = false;
            this.MovieInfo_Button_Clear.Click += new System.EventHandler(this.MovieInfo_Button_Clear_Click);
            // 
            // MovieInfo_Button_Update
            // 
            this.MovieInfo_Button_Update.BackColor = System.Drawing.Color.White;
            this.MovieInfo_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Button_Update.Location = new System.Drawing.Point(837, 156);
            this.MovieInfo_Button_Update.Name = "MovieInfo_Button_Update";
            this.MovieInfo_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.MovieInfo_Button_Update.TabIndex = 22;
            this.MovieInfo_Button_Update.Text = "Update";
            this.MovieInfo_Button_Update.UseVisualStyleBackColor = false;
            this.MovieInfo_Button_Update.Visible = false;
            this.MovieInfo_Button_Update.Click += new System.EventHandler(this.MovieInfo_Button_Update_Click);
            // 
            // Movieinfo_Textbox_LenghtTime
            // 
            this.Movieinfo_Textbox_LenghtTime.Location = new System.Drawing.Point(532, 156);
            this.Movieinfo_Textbox_LenghtTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Movieinfo_Textbox_LenghtTime.Name = "Movieinfo_Textbox_LenghtTime";
            this.Movieinfo_Textbox_LenghtTime.Size = new System.Drawing.Size(74, 21);
            this.Movieinfo_Textbox_LenghtTime.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "min";
            // 
            // MovieInfo_DatePicker_ReleaseDate
            // 
            this.MovieInfo_DatePicker_ReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MovieInfo_DatePicker_ReleaseDate.Location = new System.Drawing.Point(532, 88);
            this.MovieInfo_DatePicker_ReleaseDate.Name = "MovieInfo_DatePicker_ReleaseDate";
            this.MovieInfo_DatePicker_ReleaseDate.Size = new System.Drawing.Size(113, 21);
            this.MovieInfo_DatePicker_ReleaseDate.TabIndex = 6;
            // 
            // MovieInfo_Label_ReleaseDate
            // 
            this.MovieInfo_Label_ReleaseDate.AutoSize = true;
            this.MovieInfo_Label_ReleaseDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_ReleaseDate.Location = new System.Drawing.Point(427, 92);
            this.MovieInfo_Label_ReleaseDate.Name = "MovieInfo_Label_ReleaseDate";
            this.MovieInfo_Label_ReleaseDate.Size = new System.Drawing.Size(99, 17);
            this.MovieInfo_Label_ReleaseDate.TabIndex = 17;
            this.MovieInfo_Label_ReleaseDate.Text = "Release Date";
            // 
            // MovieInfo_Combobox_AgeRestriction
            // 
            this.MovieInfo_Combobox_AgeRestriction.FormattingEnabled = true;
            this.MovieInfo_Combobox_AgeRestriction.Location = new System.Drawing.Point(532, 124);
            this.MovieInfo_Combobox_AgeRestriction.Name = "MovieInfo_Combobox_AgeRestriction";
            this.MovieInfo_Combobox_AgeRestriction.Size = new System.Drawing.Size(125, 21);
            this.MovieInfo_Combobox_AgeRestriction.TabIndex = 7;
            // 
            // MovieInfo_Label_AgeRestriction
            // 
            this.MovieInfo_Label_AgeRestriction.AutoSize = true;
            this.MovieInfo_Label_AgeRestriction.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_AgeRestriction.Location = new System.Drawing.Point(411, 128);
            this.MovieInfo_Label_AgeRestriction.Name = "MovieInfo_Label_AgeRestriction";
            this.MovieInfo_Label_AgeRestriction.Size = new System.Drawing.Size(115, 17);
            this.MovieInfo_Label_AgeRestriction.TabIndex = 15;
            this.MovieInfo_Label_AgeRestriction.Text = "Age Restriction";
            // 
            // MovieInfo_Textbox_Genre
            // 
            this.MovieInfo_Textbox_Genre.Location = new System.Drawing.Point(772, 17);
            this.MovieInfo_Textbox_Genre.Name = "MovieInfo_Textbox_Genre";
            this.MovieInfo_Textbox_Genre.Size = new System.Drawing.Size(149, 21);
            this.MovieInfo_Textbox_Genre.TabIndex = 9;
            // 
            // MovieInfo_Label_Genre
            // 
            this.MovieInfo_Label_Genre.AutoSize = true;
            this.MovieInfo_Label_Genre.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Genre.Location = new System.Drawing.Point(716, 19);
            this.MovieInfo_Label_Genre.Name = "MovieInfo_Label_Genre";
            this.MovieInfo_Label_Genre.Size = new System.Drawing.Size(50, 17);
            this.MovieInfo_Label_Genre.TabIndex = 13;
            this.MovieInfo_Label_Genre.Text = "Genre";
            // 
            // Movieinfo_Label_LenghtTime
            // 
            this.Movieinfo_Label_LenghtTime.AutoSize = true;
            this.Movieinfo_Label_LenghtTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movieinfo_Label_LenghtTime.Location = new System.Drawing.Point(431, 161);
            this.Movieinfo_Label_LenghtTime.Name = "Movieinfo_Label_LenghtTime";
            this.Movieinfo_Label_LenghtTime.Size = new System.Drawing.Size(95, 17);
            this.Movieinfo_Label_LenghtTime.TabIndex = 11;
            this.Movieinfo_Label_LenghtTime.Text = "Lenght Time";
            // 
            // MovieInfo_Textbox_Actors
            // 
            this.MovieInfo_Textbox_Actors.Location = new System.Drawing.Point(532, 54);
            this.MovieInfo_Textbox_Actors.Name = "MovieInfo_Textbox_Actors";
            this.MovieInfo_Textbox_Actors.Size = new System.Drawing.Size(149, 21);
            this.MovieInfo_Textbox_Actors.TabIndex = 5;
            // 
            // MovieInfo_Label_Actors
            // 
            this.MovieInfo_Label_Actors.AutoSize = true;
            this.MovieInfo_Label_Actors.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Actors.Location = new System.Drawing.Point(472, 55);
            this.MovieInfo_Label_Actors.Name = "MovieInfo_Label_Actors";
            this.MovieInfo_Label_Actors.Size = new System.Drawing.Size(54, 17);
            this.MovieInfo_Label_Actors.TabIndex = 9;
            this.MovieInfo_Label_Actors.Text = "Actors";
            // 
            // MovieInfo_Textbox_Directors
            // 
            this.MovieInfo_Textbox_Directors.Location = new System.Drawing.Point(532, 18);
            this.MovieInfo_Textbox_Directors.Name = "MovieInfo_Textbox_Directors";
            this.MovieInfo_Textbox_Directors.Size = new System.Drawing.Size(149, 21);
            this.MovieInfo_Textbox_Directors.TabIndex = 4;
            // 
            // MovieInfo_Label_Directors
            // 
            this.MovieInfo_Label_Directors.AutoSize = true;
            this.MovieInfo_Label_Directors.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Directors.Location = new System.Drawing.Point(454, 19);
            this.MovieInfo_Label_Directors.Name = "MovieInfo_Label_Directors";
            this.MovieInfo_Label_Directors.Size = new System.Drawing.Size(72, 17);
            this.MovieInfo_Label_Directors.TabIndex = 7;
            this.MovieInfo_Label_Directors.Text = "Directors";
            // 
            // MovieInfo_Textbox_Description
            // 
            this.MovieInfo_Textbox_Description.Location = new System.Drawing.Point(121, 88);
            this.MovieInfo_Textbox_Description.Multiline = true;
            this.MovieInfo_Textbox_Description.Name = "MovieInfo_Textbox_Description";
            this.MovieInfo_Textbox_Description.Size = new System.Drawing.Size(290, 93);
            this.MovieInfo_Textbox_Description.TabIndex = 3;
            // 
            // MovieInfo_Label_Description
            // 
            this.MovieInfo_Label_Description.AutoSize = true;
            this.MovieInfo_Label_Description.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Description.Location = new System.Drawing.Point(19, 92);
            this.MovieInfo_Label_Description.Name = "MovieInfo_Label_Description";
            this.MovieInfo_Label_Description.Size = new System.Drawing.Size(87, 17);
            this.MovieInfo_Label_Description.TabIndex = 5;
            this.MovieInfo_Label_Description.Text = "Description";
            // 
            // MovieInfo_Textbox_Title
            // 
            this.MovieInfo_Textbox_Title.Location = new System.Drawing.Point(121, 54);
            this.MovieInfo_Textbox_Title.Name = "MovieInfo_Textbox_Title";
            this.MovieInfo_Textbox_Title.Size = new System.Drawing.Size(149, 21);
            this.MovieInfo_Textbox_Title.TabIndex = 2;
            // 
            // MovieInfo_Label_Title
            // 
            this.MovieInfo_Label_Title.AutoSize = true;
            this.MovieInfo_Label_Title.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Title.Location = new System.Drawing.Point(69, 58);
            this.MovieInfo_Label_Title.Name = "MovieInfo_Label_Title";
            this.MovieInfo_Label_Title.Size = new System.Drawing.Size(37, 17);
            this.MovieInfo_Label_Title.TabIndex = 3;
            this.MovieInfo_Label_Title.Text = "Title";
            // 
            // MovieInfo_Textbox_Id
            // 
            this.MovieInfo_Textbox_Id.Location = new System.Drawing.Point(121, 18);
            this.MovieInfo_Textbox_Id.Name = "MovieInfo_Textbox_Id";
            this.MovieInfo_Textbox_Id.ReadOnly = true;
            this.MovieInfo_Textbox_Id.Size = new System.Drawing.Size(149, 21);
            this.MovieInfo_Textbox_Id.TabIndex = 1;
            this.MovieInfo_Textbox_Id.Text = "auto";
            // 
            // MovieInfo_Label_Id
            // 
            this.MovieInfo_Label_Id.AutoSize = true;
            this.MovieInfo_Label_Id.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieInfo_Label_Id.Location = new System.Drawing.Point(84, 22);
            this.MovieInfo_Label_Id.Name = "MovieInfo_Label_Id";
            this.MovieInfo_Label_Id.Size = new System.Drawing.Size(22, 17);
            this.MovieInfo_Label_Id.TabIndex = 1;
            this.MovieInfo_Label_Id.Text = "Id";
            // 
            // Grid_MovieInfo
            // 
            this.Grid_MovieInfo.AllowUserToAddRows = false;
            this.Grid_MovieInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_MovieInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_MovieInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_MovieInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_MovieInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Description,
            this.Directors,
            this.Actors,
            this.ReleaseDate,
            this.LenghtTime,
            this.AgeRestriction,
            this.Genre});
            this.Grid_MovieInfo.Location = new System.Drawing.Point(0, 218);
            this.Grid_MovieInfo.MultiSelect = false;
            this.Grid_MovieInfo.Name = "Grid_MovieInfo";
            this.Grid_MovieInfo.ReadOnly = true;
            this.Grid_MovieInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_MovieInfo.Size = new System.Drawing.Size(936, 314);
            this.Grid_MovieInfo.TabIndex = 0;
            this.Grid_MovieInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_MovieInfo_CellClick);
            this.Grid_MovieInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_MovieInfo_RowsAdded);
            this.Grid_MovieInfo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_MovieInfo_UserDeletingRow);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Directors
            // 
            this.Directors.HeaderText = "Directors";
            this.Directors.Name = "Directors";
            this.Directors.ReadOnly = true;
            // 
            // Actors
            // 
            this.Actors.HeaderText = "Actors";
            this.Actors.Name = "Actors";
            this.Actors.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // LenghtTime
            // 
            this.LenghtTime.HeaderText = "LenghtTime";
            this.LenghtTime.Name = "LenghtTime";
            this.LenghtTime.ReadOnly = true;
            // 
            // AgeRestriction
            // 
            this.AgeRestriction.HeaderText = "AgeRestriction";
            this.AgeRestriction.Name = "AgeRestriction";
            this.AgeRestriction.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.Movie_Button_Insert);
            this.Movies.Controls.Add(this.Movie_Button_Update);
            this.Movies.Controls.Add(this.Movie_Textbox_MovieInfoId);
            this.Movies.Controls.Add(this.Movie_Button_Clear);
            this.Movies.Controls.Add(this.Movie_CheckBox_Is3D);
            this.Movies.Controls.Add(this.Movie_Label_3D);
            this.Movies.Controls.Add(this.Movie_Label_MovieInfoId);
            this.Movies.Controls.Add(this.Movie_Textbox_Id);
            this.Movies.Controls.Add(this.Movie_Label_Id);
            this.Movies.Controls.Add(this.Grid_Movie);
            this.Movies.Location = new System.Drawing.Point(4, 25);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(3);
            this.Movies.Size = new System.Drawing.Size(937, 527);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // Movie_Button_Insert
            // 
            this.Movie_Button_Insert.BackColor = System.Drawing.Color.White;
            this.Movie_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Button_Insert.Location = new System.Drawing.Point(843, 164);
            this.Movie_Button_Insert.Name = "Movie_Button_Insert";
            this.Movie_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.Movie_Button_Insert.TabIndex = 26;
            this.Movie_Button_Insert.Text = "Insert";
            this.Movie_Button_Insert.UseVisualStyleBackColor = false;
            this.Movie_Button_Insert.Click += new System.EventHandler(this.Movie_Button_Insert_Click);
            // 
            // Movie_Button_Update
            // 
            this.Movie_Button_Update.BackColor = System.Drawing.Color.White;
            this.Movie_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Button_Update.Location = new System.Drawing.Point(843, 164);
            this.Movie_Button_Update.Name = "Movie_Button_Update";
            this.Movie_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.Movie_Button_Update.TabIndex = 24;
            this.Movie_Button_Update.Text = "Update";
            this.Movie_Button_Update.UseVisualStyleBackColor = false;
            this.Movie_Button_Update.Visible = false;
            this.Movie_Button_Update.Click += new System.EventHandler(this.Movie_Button_Update_Click);
            // 
            // Movie_Textbox_MovieInfoId
            // 
            this.Movie_Textbox_MovieInfoId.Location = new System.Drawing.Point(130, 63);
            this.Movie_Textbox_MovieInfoId.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.Movie_Textbox_MovieInfoId.Name = "Movie_Textbox_MovieInfoId";
            this.Movie_Textbox_MovieInfoId.Size = new System.Drawing.Size(74, 21);
            this.Movie_Textbox_MovieInfoId.TabIndex = 11;
            // 
            // Movie_Button_Clear
            // 
            this.Movie_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Movie_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Button_Clear.Location = new System.Drawing.Point(737, 164);
            this.Movie_Button_Clear.Name = "Movie_Button_Clear";
            this.Movie_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.Movie_Button_Clear.TabIndex = 25;
            this.Movie_Button_Clear.Text = "Clear";
            this.Movie_Button_Clear.UseVisualStyleBackColor = false;
            this.Movie_Button_Clear.Click += new System.EventHandler(this.Movie_Button_Clear_Click);
            // 
            // Movie_CheckBox_Is3D
            // 
            this.Movie_CheckBox_Is3D.AutoSize = true;
            this.Movie_CheckBox_Is3D.Location = new System.Drawing.Point(130, 108);
            this.Movie_CheckBox_Is3D.Name = "Movie_CheckBox_Is3D";
            this.Movie_CheckBox_Is3D.Size = new System.Drawing.Size(15, 14);
            this.Movie_CheckBox_Is3D.TabIndex = 12;
            this.Movie_CheckBox_Is3D.UseVisualStyleBackColor = true;
            // 
            // Movie_Label_3D
            // 
            this.Movie_Label_3D.AutoSize = true;
            this.Movie_Label_3D.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Label_3D.Location = new System.Drawing.Point(68, 108);
            this.Movie_Label_3D.Name = "Movie_Label_3D";
            this.Movie_Label_3D.Size = new System.Drawing.Size(46, 17);
            this.Movie_Label_3D.TabIndex = 9;
            this.Movie_Label_3D.Text = "Is 3D";
            // 
            // Movie_Label_MovieInfoId
            // 
            this.Movie_Label_MovieInfoId.AutoSize = true;
            this.Movie_Label_MovieInfoId.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Label_MovieInfoId.Location = new System.Drawing.Point(17, 67);
            this.Movie_Label_MovieInfoId.Name = "Movie_Label_MovieInfoId";
            this.Movie_Label_MovieInfoId.Size = new System.Drawing.Size(99, 17);
            this.Movie_Label_MovieInfoId.TabIndex = 7;
            this.Movie_Label_MovieInfoId.Text = "Movie Info Id";
            // 
            // Movie_Textbox_Id
            // 
            this.Movie_Textbox_Id.Location = new System.Drawing.Point(130, 28);
            this.Movie_Textbox_Id.Name = "Movie_Textbox_Id";
            this.Movie_Textbox_Id.ReadOnly = true;
            this.Movie_Textbox_Id.Size = new System.Drawing.Size(149, 21);
            this.Movie_Textbox_Id.TabIndex = 10;
            this.Movie_Textbox_Id.Text = "auto";
            // 
            // Movie_Label_Id
            // 
            this.Movie_Label_Id.AutoSize = true;
            this.Movie_Label_Id.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Label_Id.Location = new System.Drawing.Point(92, 29);
            this.Movie_Label_Id.Name = "Movie_Label_Id";
            this.Movie_Label_Id.Size = new System.Drawing.Size(22, 17);
            this.Movie_Label_Id.TabIndex = 3;
            this.Movie_Label_Id.Text = "Id";
            // 
            // Grid_Movie
            // 
            this.Grid_Movie.AllowUserToAddRows = false;
            this.Grid_Movie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Movie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Movie.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.MovieInfo,
            this.Is3D});
            this.Grid_Movie.Location = new System.Drawing.Point(0, 217);
            this.Grid_Movie.MultiSelect = false;
            this.Grid_Movie.Name = "Grid_Movie";
            this.Grid_Movie.ReadOnly = true;
            this.Grid_Movie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Movie.Size = new System.Drawing.Size(936, 314);
            this.Grid_Movie.TabIndex = 1;
            this.Grid_Movie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Movie_CellClick);
            this.Grid_Movie.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_Movie_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MovieInfo
            // 
            this.MovieInfo.HeaderText = "Movie Info";
            this.MovieInfo.Name = "MovieInfo";
            this.MovieInfo.ReadOnly = true;
            // 
            // Is3D
            // 
            this.Is3D.HeaderText = "3D";
            this.Is3D.Name = "Is3D";
            this.Is3D.ReadOnly = true;
            this.Is3D.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Is3D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tabs.Controls.Add(this.Tabs_Movies);
            this.Tabs.Controls.Add(this.Tabs_Screenings);
            this.Tabs.Controls.Add(this.Tabs_Halls);
            this.Tabs.Controls.Add(this.Tabs_TickeTypes);
            this.Tabs.Controls.Add(this.Tabs_Bookings);
            this.Tabs.Controls.Add(this.Tabs_Users);
            this.Tabs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.HotTrack = true;
            this.Tabs.Location = new System.Drawing.Point(-1, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(945, 613);
            this.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs.TabIndex = 0;
            this.Tabs.Visible = false;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            this.Tabs.VisibleChanged += new System.EventHandler(this.Tabs_VisibleChanged);
            // 
            // Tabs_Users
            // 
            this.Tabs_Users.Controls.Add(this.Users_Panel_UpdatePanel);
            this.Tabs_Users.Controls.Add(this.Users_Panel_Password);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_LastLogin);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_CreatedOn);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_UpdatedOn);
            this.Tabs_Users.Controls.Add(this.Users_Label_LastLogin);
            this.Tabs_Users.Controls.Add(this.Users_Label_UpdatedOn);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_UpdatedBy);
            this.Tabs_Users.Controls.Add(this.Users_Label_UpdatedBy);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_LastName);
            this.Tabs_Users.Controls.Add(this.Users_Button_Insert);
            this.Tabs_Users.Controls.Add(this.Users_Button_Clear);
            this.Tabs_Users.Controls.Add(this.Users_Button_Update);
            this.Tabs_Users.Controls.Add(this.Users_Label_CreatedOn);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_CreatedBy);
            this.Tabs_Users.Controls.Add(this.Users_Label_CreatedBy);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_Phone);
            this.Tabs_Users.Controls.Add(this.Users_Label_Phone);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_Email);
            this.Tabs_Users.Controls.Add(this.Users_Label_Email);
            this.Tabs_Users.Controls.Add(this.Users_Label_LastName);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_FirstName);
            this.Tabs_Users.Controls.Add(this.Users_Label_FirstName);
            this.Tabs_Users.Controls.Add(this.Users_Textbox_ID);
            this.Tabs_Users.Controls.Add(this.Users_Label_ID);
            this.Tabs_Users.Controls.Add(this.Grid_Users);
            this.Tabs_Users.Location = new System.Drawing.Point(4, 25);
            this.Tabs_Users.Name = "Tabs_Users";
            this.Tabs_Users.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_Users.Size = new System.Drawing.Size(937, 584);
            this.Tabs_Users.TabIndex = 8;
            this.Tabs_Users.Text = "Users";
            this.Tabs_Users.UseVisualStyleBackColor = true;
            // 
            // Users_Panel_UpdatePanel
            // 
            this.Users_Panel_UpdatePanel.Controls.Add(this.Users_Checkbox_IsDeleted);
            this.Users_Panel_UpdatePanel.Controls.Add(this.Users_Label_IsDeleted);
            this.Users_Panel_UpdatePanel.Controls.Add(this.Users_Combobox_AccessLevel);
            this.Users_Panel_UpdatePanel.Controls.Add(this.Users_Label_AccessLevel);
            this.Users_Panel_UpdatePanel.Location = new System.Drawing.Point(279, 14);
            this.Users_Panel_UpdatePanel.Name = "Users_Panel_UpdatePanel";
            this.Users_Panel_UpdatePanel.Size = new System.Drawing.Size(315, 64);
            this.Users_Panel_UpdatePanel.TabIndex = 41;
            this.Users_Panel_UpdatePanel.Visible = false;
            // 
            // Users_Checkbox_IsDeleted
            // 
            this.Users_Checkbox_IsDeleted.AutoSize = true;
            this.Users_Checkbox_IsDeleted.Location = new System.Drawing.Point(167, 44);
            this.Users_Checkbox_IsDeleted.Name = "Users_Checkbox_IsDeleted";
            this.Users_Checkbox_IsDeleted.Size = new System.Drawing.Size(15, 14);
            this.Users_Checkbox_IsDeleted.TabIndex = 39;
            this.Users_Checkbox_IsDeleted.UseVisualStyleBackColor = true;
            // 
            // Users_Label_IsDeleted
            // 
            this.Users_Label_IsDeleted.AutoSize = true;
            this.Users_Label_IsDeleted.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_IsDeleted.Location = new System.Drawing.Point(88, 42);
            this.Users_Label_IsDeleted.Name = "Users_Label_IsDeleted";
            this.Users_Label_IsDeleted.Size = new System.Drawing.Size(61, 17);
            this.Users_Label_IsDeleted.TabIndex = 31;
            this.Users_Label_IsDeleted.Text = "Deleted";
            // 
            // Users_Combobox_AccessLevel
            // 
            this.Users_Combobox_AccessLevel.FormattingEnabled = true;
            this.Users_Combobox_AccessLevel.Location = new System.Drawing.Point(167, 4);
            this.Users_Combobox_AccessLevel.Name = "Users_Combobox_AccessLevel";
            this.Users_Combobox_AccessLevel.Size = new System.Drawing.Size(125, 21);
            this.Users_Combobox_AccessLevel.TabIndex = 38;
            // 
            // Users_Label_AccessLevel
            // 
            this.Users_Label_AccessLevel.AutoSize = true;
            this.Users_Label_AccessLevel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_AccessLevel.Location = new System.Drawing.Point(53, 4);
            this.Users_Label_AccessLevel.Name = "Users_Label_AccessLevel";
            this.Users_Label_AccessLevel.Size = new System.Drawing.Size(96, 17);
            this.Users_Label_AccessLevel.TabIndex = 15;
            this.Users_Label_AccessLevel.Text = "Access Level";
            // 
            // Users_Panel_Password
            // 
            this.Users_Panel_Password.Controls.Add(this.Users_Textbox_Password);
            this.Users_Panel_Password.Controls.Add(this.Users_Textbox_ConfirmPassword);
            this.Users_Panel_Password.Controls.Add(this.Users_Label_Password);
            this.Users_Panel_Password.Controls.Add(this.Users_Label_ConfirmPassword);
            this.Users_Panel_Password.Location = new System.Drawing.Point(276, 85);
            this.Users_Panel_Password.Name = "Users_Panel_Password";
            this.Users_Panel_Password.Size = new System.Drawing.Size(322, 60);
            this.Users_Panel_Password.TabIndex = 40;
            // 
            // Users_Textbox_Password
            // 
            this.Users_Textbox_Password.Location = new System.Drawing.Point(170, 5);
            this.Users_Textbox_Password.Name = "Users_Textbox_Password";
            this.Users_Textbox_Password.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_Password.TabIndex = 38;
            this.Users_Textbox_Password.UseSystemPasswordChar = true;
            // 
            // Users_Textbox_ConfirmPassword
            // 
            this.Users_Textbox_ConfirmPassword.Location = new System.Drawing.Point(170, 32);
            this.Users_Textbox_ConfirmPassword.Name = "Users_Textbox_ConfirmPassword";
            this.Users_Textbox_ConfirmPassword.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_ConfirmPassword.TabIndex = 39;
            this.Users_Textbox_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // Users_Label_Password
            // 
            this.Users_Label_Password.AutoSize = true;
            this.Users_Label_Password.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_Password.Location = new System.Drawing.Point(77, 6);
            this.Users_Label_Password.Name = "Users_Label_Password";
            this.Users_Label_Password.Size = new System.Drawing.Size(75, 17);
            this.Users_Label_Password.TabIndex = 36;
            this.Users_Label_Password.Text = "Password";
            // 
            // Users_Label_ConfirmPassword
            // 
            this.Users_Label_ConfirmPassword.AutoSize = true;
            this.Users_Label_ConfirmPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_ConfirmPassword.Location = new System.Drawing.Point(17, 36);
            this.Users_Label_ConfirmPassword.Name = "Users_Label_ConfirmPassword";
            this.Users_Label_ConfirmPassword.Size = new System.Drawing.Size(135, 17);
            this.Users_Label_ConfirmPassword.TabIndex = 38;
            this.Users_Label_ConfirmPassword.Text = "Confirm Password";
            // 
            // Users_Textbox_LastLogin
            // 
            this.Users_Textbox_LastLogin.Location = new System.Drawing.Point(761, 22);
            this.Users_Textbox_LastLogin.Name = "Users_Textbox_LastLogin";
            this.Users_Textbox_LastLogin.ReadOnly = true;
            this.Users_Textbox_LastLogin.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_LastLogin.TabIndex = 40;
            // 
            // Users_Textbox_CreatedOn
            // 
            this.Users_Textbox_CreatedOn.Location = new System.Drawing.Point(761, 93);
            this.Users_Textbox_CreatedOn.Name = "Users_Textbox_CreatedOn";
            this.Users_Textbox_CreatedOn.ReadOnly = true;
            this.Users_Textbox_CreatedOn.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_CreatedOn.TabIndex = 42;
            // 
            // Users_Textbox_UpdatedOn
            // 
            this.Users_Textbox_UpdatedOn.Location = new System.Drawing.Point(761, 157);
            this.Users_Textbox_UpdatedOn.Name = "Users_Textbox_UpdatedOn";
            this.Users_Textbox_UpdatedOn.ReadOnly = true;
            this.Users_Textbox_UpdatedOn.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_UpdatedOn.TabIndex = 44;
            // 
            // Users_Label_LastLogin
            // 
            this.Users_Label_LastLogin.AutoSize = true;
            this.Users_Label_LastLogin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_LastLogin.Location = new System.Drawing.Point(657, 23);
            this.Users_Label_LastLogin.Name = "Users_Label_LastLogin";
            this.Users_Label_LastLogin.Size = new System.Drawing.Size(81, 17);
            this.Users_Label_LastLogin.TabIndex = 29;
            this.Users_Label_LastLogin.Text = "Last Login";
            // 
            // Users_Label_UpdatedOn
            // 
            this.Users_Label_UpdatedOn.AutoSize = true;
            this.Users_Label_UpdatedOn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_UpdatedOn.Location = new System.Drawing.Point(646, 164);
            this.Users_Label_UpdatedOn.Name = "Users_Label_UpdatedOn";
            this.Users_Label_UpdatedOn.Size = new System.Drawing.Size(92, 17);
            this.Users_Label_UpdatedOn.TabIndex = 27;
            this.Users_Label_UpdatedOn.Text = "Updated On";
            // 
            // Users_Textbox_UpdatedBy
            // 
            this.Users_Textbox_UpdatedBy.Location = new System.Drawing.Point(761, 124);
            this.Users_Textbox_UpdatedBy.Name = "Users_Textbox_UpdatedBy";
            this.Users_Textbox_UpdatedBy.ReadOnly = true;
            this.Users_Textbox_UpdatedBy.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_UpdatedBy.TabIndex = 43;
            // 
            // Users_Label_UpdatedBy
            // 
            this.Users_Label_UpdatedBy.AutoSize = true;
            this.Users_Label_UpdatedBy.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_UpdatedBy.Location = new System.Drawing.Point(648, 128);
            this.Users_Label_UpdatedBy.Name = "Users_Label_UpdatedBy";
            this.Users_Label_UpdatedBy.Size = new System.Drawing.Size(90, 17);
            this.Users_Label_UpdatedBy.TabIndex = 25;
            this.Users_Label_UpdatedBy.Text = "Updated By";
            // 
            // Users_Textbox_LastName
            // 
            this.Users_Textbox_LastName.Location = new System.Drawing.Point(121, 92);
            this.Users_Textbox_LastName.Name = "Users_Textbox_LastName";
            this.Users_Textbox_LastName.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_LastName.TabIndex = 35;
            // 
            // Users_Button_Insert
            // 
            this.Users_Button_Insert.BackColor = System.Drawing.Color.White;
            this.Users_Button_Insert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Button_Insert.Location = new System.Drawing.Point(494, 164);
            this.Users_Button_Insert.Name = "Users_Button_Insert";
            this.Users_Button_Insert.Size = new System.Drawing.Size(84, 37);
            this.Users_Button_Insert.TabIndex = 21;
            this.Users_Button_Insert.Text = "Insert";
            this.Users_Button_Insert.UseVisualStyleBackColor = false;
            this.Users_Button_Insert.Click += new System.EventHandler(this.Users_Button_Insert_Click);
            // 
            // Users_Button_Clear
            // 
            this.Users_Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Users_Button_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Button_Clear.Location = new System.Drawing.Point(327, 164);
            this.Users_Button_Clear.Name = "Users_Button_Clear";
            this.Users_Button_Clear.Size = new System.Drawing.Size(84, 37);
            this.Users_Button_Clear.TabIndex = 23;
            this.Users_Button_Clear.Text = "Clear";
            this.Users_Button_Clear.UseVisualStyleBackColor = false;
            this.Users_Button_Clear.Click += new System.EventHandler(this.Users_Button_Clear_Click);
            // 
            // Users_Button_Update
            // 
            this.Users_Button_Update.BackColor = System.Drawing.Color.White;
            this.Users_Button_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Button_Update.Location = new System.Drawing.Point(494, 164);
            this.Users_Button_Update.Name = "Users_Button_Update";
            this.Users_Button_Update.Size = new System.Drawing.Size(84, 37);
            this.Users_Button_Update.TabIndex = 22;
            this.Users_Button_Update.Text = "Update";
            this.Users_Button_Update.UseVisualStyleBackColor = false;
            this.Users_Button_Update.Visible = false;
            this.Users_Button_Update.Click += new System.EventHandler(this.Users_Button_Update_Click);
            // 
            // Users_Label_CreatedOn
            // 
            this.Users_Label_CreatedOn.AutoSize = true;
            this.Users_Label_CreatedOn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_CreatedOn.Location = new System.Drawing.Point(650, 93);
            this.Users_Label_CreatedOn.Name = "Users_Label_CreatedOn";
            this.Users_Label_CreatedOn.Size = new System.Drawing.Size(88, 17);
            this.Users_Label_CreatedOn.TabIndex = 17;
            this.Users_Label_CreatedOn.Text = "Created On";
            // 
            // Users_Textbox_CreatedBy
            // 
            this.Users_Textbox_CreatedBy.Location = new System.Drawing.Point(761, 58);
            this.Users_Textbox_CreatedBy.Name = "Users_Textbox_CreatedBy";
            this.Users_Textbox_CreatedBy.ReadOnly = true;
            this.Users_Textbox_CreatedBy.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_CreatedBy.TabIndex = 41;
            // 
            // Users_Label_CreatedBy
            // 
            this.Users_Label_CreatedBy.AutoSize = true;
            this.Users_Label_CreatedBy.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_CreatedBy.Location = new System.Drawing.Point(652, 59);
            this.Users_Label_CreatedBy.Name = "Users_Label_CreatedBy";
            this.Users_Label_CreatedBy.Size = new System.Drawing.Size(86, 17);
            this.Users_Label_CreatedBy.TabIndex = 13;
            this.Users_Label_CreatedBy.Text = "Created By";
            // 
            // Users_Textbox_Phone
            // 
            this.Users_Textbox_Phone.Location = new System.Drawing.Point(121, 160);
            this.Users_Textbox_Phone.Name = "Users_Textbox_Phone";
            this.Users_Textbox_Phone.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_Phone.TabIndex = 37;
            // 
            // Users_Label_Phone
            // 
            this.Users_Label_Phone.AutoSize = true;
            this.Users_Label_Phone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_Phone.Location = new System.Drawing.Point(54, 161);
            this.Users_Label_Phone.Name = "Users_Label_Phone";
            this.Users_Label_Phone.Size = new System.Drawing.Size(51, 17);
            this.Users_Label_Phone.TabIndex = 9;
            this.Users_Label_Phone.Text = "Phone";
            // 
            // Users_Textbox_Email
            // 
            this.Users_Textbox_Email.Location = new System.Drawing.Point(121, 124);
            this.Users_Textbox_Email.Name = "Users_Textbox_Email";
            this.Users_Textbox_Email.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_Email.TabIndex = 36;
            // 
            // Users_Label_Email
            // 
            this.Users_Label_Email.AutoSize = true;
            this.Users_Label_Email.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_Email.Location = new System.Drawing.Point(61, 124);
            this.Users_Label_Email.Name = "Users_Label_Email";
            this.Users_Label_Email.Size = new System.Drawing.Size(44, 17);
            this.Users_Label_Email.TabIndex = 7;
            this.Users_Label_Email.Text = "Email";
            // 
            // Users_Label_LastName
            // 
            this.Users_Label_LastName.AutoSize = true;
            this.Users_Label_LastName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_LastName.Location = new System.Drawing.Point(24, 92);
            this.Users_Label_LastName.Name = "Users_Label_LastName";
            this.Users_Label_LastName.Size = new System.Drawing.Size(82, 17);
            this.Users_Label_LastName.TabIndex = 5;
            this.Users_Label_LastName.Text = "Last Name";
            // 
            // Users_Textbox_FirstName
            // 
            this.Users_Textbox_FirstName.Location = new System.Drawing.Point(121, 54);
            this.Users_Textbox_FirstName.Name = "Users_Textbox_FirstName";
            this.Users_Textbox_FirstName.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_FirstName.TabIndex = 34;
            // 
            // Users_Label_FirstName
            // 
            this.Users_Label_FirstName.AutoSize = true;
            this.Users_Label_FirstName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_FirstName.Location = new System.Drawing.Point(22, 58);
            this.Users_Label_FirstName.Name = "Users_Label_FirstName";
            this.Users_Label_FirstName.Size = new System.Drawing.Size(83, 17);
            this.Users_Label_FirstName.TabIndex = 3;
            this.Users_Label_FirstName.Text = "First Name";
            // 
            // Users_Textbox_ID
            // 
            this.Users_Textbox_ID.Location = new System.Drawing.Point(121, 18);
            this.Users_Textbox_ID.Name = "Users_Textbox_ID";
            this.Users_Textbox_ID.ReadOnly = true;
            this.Users_Textbox_ID.Size = new System.Drawing.Size(149, 21);
            this.Users_Textbox_ID.TabIndex = 33;
            this.Users_Textbox_ID.Text = "auto";
            // 
            // Users_Label_ID
            // 
            this.Users_Label_ID.AutoSize = true;
            this.Users_Label_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Label_ID.Location = new System.Drawing.Point(83, 22);
            this.Users_Label_ID.Name = "Users_Label_ID";
            this.Users_Label_ID.Size = new System.Drawing.Size(22, 17);
            this.Users_Label_ID.TabIndex = 1;
            this.Users_Label_ID.Text = "Id";
            // 
            // Grid_Users
            // 
            this.Grid_Users.AllowUserToAddRows = false;
            this.Grid_Users.AllowUserToDeleteRows = false;
            this.Grid_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Users.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.UserName,
            this.UserEmail,
            this.UserPhone,
            this.IsDeleted});
            this.Grid_Users.Location = new System.Drawing.Point(0, 218);
            this.Grid_Users.MultiSelect = false;
            this.Grid_Users.Name = "Grid_Users";
            this.Grid_Users.ReadOnly = true;
            this.Grid_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Users.Size = new System.Drawing.Size(936, 371);
            this.Grid_Users.TabIndex = 0;
            this.Grid_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Users_CellClick);
            this.Grid_Users.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_Users_RowsAdded);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.HeaderText = "Email";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.HeaderText = "Phone";
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.HeaderText = "Deleted";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataSource = typeof(DedicatedClient.CinemaService.Booking);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(DedicatedClient.CinemaService.Booking);
            // 
            // movieInfoBindingSource
            // 
            this.movieInfoBindingSource.DataSource = typeof(DedicatedClient.CinemaService.MovieInfo);
            // 
            // CinemaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 657);
            this.Controls.Add(this.Label_LoggedInAs);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.LoginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CinemaApp";
            this.Text = "Cinema Booking System";
            this.Load += new System.EventHandler(this.CinemaApp_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPasswordError)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanel_Loading)).EndInit();
            this.Tabs_TickeTypes.ResumeLayout(false);
            this.Tabs_TickeTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketType_Textbox_Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TicketType)).EndInit();
            this.Tabs_Bookings.ResumeLayout(false);
            this.Tabs_Bookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Booking_Textbox_Screening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Booking)).EndInit();
            this.Tabs_Halls.ResumeLayout(false);
            this.Tabs_Halls.PerformLayout();
            this.Hall_Seat_Panel.ResumeLayout(false);
            this.Hall_Seat_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Hall)).EndInit();
            this.Tabs_Screenings.ResumeLayout(false);
            this.ScreeningsPanel_Tabs.ResumeLayout(false);
            this.ScreeningInfo.ResumeLayout(false);
            this.ScreeningInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreeningInfo_Textbox_MovieId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreeningInfo_Textbox_HallId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ScreeningInfo)).EndInit();
            this.Screenings.ResumeLayout(false);
            this.Screenings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screening_Textbox_ScreeningInfoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Screening)).EndInit();
            this.Tabs_Movies.ResumeLayout(false);
            this.MoviesPanel_Tabs.ResumeLayout(false);
            this.MoviesInfo.ResumeLayout(false);
            this.MoviesInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movieinfo_Textbox_LenghtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MovieInfo)).EndInit();
            this.Movies.ResumeLayout(false);
            this.Movies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Textbox_MovieInfoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Movie)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.Tabs_Users.ResumeLayout(false);
            this.Tabs_Users.PerformLayout();
            this.Users_Panel_UpdatePanel.ResumeLayout(false);
            this.Users_Panel_UpdatePanel.PerformLayout();
            this.Users_Panel_Password.ResumeLayout(false);
            this.Users_Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label LoginEmailPhoneLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.TextBox LoginPasswordTextbox;
        private System.Windows.Forms.TextBox LoginEmailTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ErrorProvider LoginEmailError;
        private System.Windows.Forms.ErrorProvider LoginPasswordError;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox InfoPanel_Loading;
        private System.Windows.Forms.Label InfoPanel_Text;
        private System.Windows.Forms.PictureBox InfoPanel_Wrong;
        private System.Windows.Forms.PictureBox InfoPanel_Right;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource movieInfoBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Tabs_Movies;
        private System.Windows.Forms.TabControl MoviesPanel_Tabs;
        private System.Windows.Forms.TabPage MoviesInfo;
        private System.Windows.Forms.Button MovieInfo_Button_Insert;
        private System.Windows.Forms.Button MovieInfo_Button_Clear;
        private System.Windows.Forms.Button MovieInfo_Button_Update;
        private System.Windows.Forms.NumericUpDown Movieinfo_Textbox_LenghtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MovieInfo_DatePicker_ReleaseDate;
        private System.Windows.Forms.Label MovieInfo_Label_ReleaseDate;
        private System.Windows.Forms.ComboBox MovieInfo_Combobox_AgeRestriction;
        private System.Windows.Forms.Label MovieInfo_Label_AgeRestriction;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Genre;
        private System.Windows.Forms.Label MovieInfo_Label_Genre;
        private System.Windows.Forms.Label Movieinfo_Label_LenghtTime;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Actors;
        private System.Windows.Forms.Label MovieInfo_Label_Actors;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Directors;
        private System.Windows.Forms.Label MovieInfo_Label_Directors;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Description;
        private System.Windows.Forms.Label MovieInfo_Label_Description;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Title;
        private System.Windows.Forms.Label MovieInfo_Label_Title;
        private System.Windows.Forms.TextBox MovieInfo_Textbox_Id;
        private System.Windows.Forms.Label MovieInfo_Label_Id;
        private System.Windows.Forms.DataGridView Grid_MovieInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LenghtTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeRestriction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.Button Movie_Button_Insert;
        private System.Windows.Forms.Button Movie_Button_Update;
        private System.Windows.Forms.NumericUpDown Movie_Textbox_MovieInfoId;
        private System.Windows.Forms.Button Movie_Button_Clear;
        private System.Windows.Forms.CheckBox Movie_CheckBox_Is3D;
        private System.Windows.Forms.Label Movie_Label_3D;
        private System.Windows.Forms.Label Movie_Label_MovieInfoId;
        private System.Windows.Forms.TextBox Movie_Textbox_Id;
        private System.Windows.Forms.Label Movie_Label_Id;
        private System.Windows.Forms.DataGridView Grid_Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is3D;
        private System.Windows.Forms.TabPage Tabs_Screenings;
        private System.Windows.Forms.TabControl ScreeningsPanel_Tabs;
        private System.Windows.Forms.TabPage ScreeningInfo;
        private System.Windows.Forms.Button ScreeningInfo_Button_Insert;
        private System.Windows.Forms.NumericUpDown ScreeningInfo_Textbox_MovieId;
        private System.Windows.Forms.Button ScreeningInfo_Button_Clear;
        private System.Windows.Forms.Button ScreeningInfo_Button_Update;
        private System.Windows.Forms.NumericUpDown ScreeningInfo_Textbox_HallId;
        private System.Windows.Forms.Label ScreeningInfo_Label_HallId;
        private System.Windows.Forms.TextBox ScreeningInfo_Textbox_TicketPrice;
        private System.Windows.Forms.Label ScreeningInfo_Label_TicketPrice;
        private System.Windows.Forms.Label ScreeningInfo_Label_MovieId;
        private System.Windows.Forms.TextBox ScreeningInfo_Textbox_ID;
        private System.Windows.Forms.Label ScreeningInfo_Label_ID;
        private System.Windows.Forms.DataGridView Grid_ScreeningInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.TabPage Screenings;
        private System.Windows.Forms.Button Screenings_Button_Insert;
        private System.Windows.Forms.DateTimePicker Screening_Date;
        private System.Windows.Forms.NumericUpDown Screening_Textbox_ScreeningInfoId;
        private System.Windows.Forms.Button Screenings_Button_Clear;
        private System.Windows.Forms.Button Screenings_Button_Update;
        private System.Windows.Forms.Label Screening_Label_ScreeningDate;
        private System.Windows.Forms.Label Screening_Label_ScreeningInfoId;
        private System.Windows.Forms.TextBox Screening_Textbox_ID;
        private System.Windows.Forms.Label Screening_Label_ID;
        private System.Windows.Forms.DataGridView Grid_Screening;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreeningInfoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreeningDateTime;
        private System.Windows.Forms.TabPage Tabs_Halls;
        private System.Windows.Forms.Panel Hall_Seat_Panel;
        private System.Windows.Forms.DataGridView Grid_Seats;
        private System.Windows.Forms.Label Hall_Seat_Legend_HowToUse;
        private System.Windows.Forms.FlowLayoutPanel Hall_Seat_Seats_Legend;
        private System.Windows.Forms.Label Hall_Seat_Title;
        private System.Windows.Forms.TextBox Hall_Textbox_Name;
        private System.Windows.Forms.TextBox Hall_Textbox_ID;
        private System.Windows.Forms.Button Hall_Button_Insert;
        private System.Windows.Forms.Button Hall_Button_Clear;
        private System.Windows.Forms.Button Hall_Button_Update;
        private System.Windows.Forms.Label Hall_Label_Name;
        private System.Windows.Forms.Label Hall_Label_ID;
        private System.Windows.Forms.DataGridView Grid_Hall;
        private System.Windows.Forms.TabPage Tabs_Bookings;
        private System.Windows.Forms.Button Booking_Button_Insert;
        private System.Windows.Forms.Button Booking_Button_Clear;
        private System.Windows.Forms.CheckBox Booking_Checkbox_Canceled;
        private System.Windows.Forms.CheckBox Booking_Checkbox_Paid;
        private System.Windows.Forms.TextBox Booking_Textbox_CreatedOn;
        private System.Windows.Forms.TextBox Booking_Textbox_CreatedBy;
        private System.Windows.Forms.TextBox Booking_Textbox_TotalPrice;
        private System.Windows.Forms.TextBox Booking_Textbox_Customer;
        private System.Windows.Forms.TextBox Booking_Textbox_ID;
        private System.Windows.Forms.Label Booking_Label_CreatedOn;
        private System.Windows.Forms.Label Booking_Label_CreatedBy;
        private System.Windows.Forms.Label Booking_Label_Canceled;
        private System.Windows.Forms.Label Booking_Label_Paid;
        private System.Windows.Forms.Label Booking_Label_TotalPrice;
        private System.Windows.Forms.Label Booking_Label_Screening;
        private System.Windows.Forms.Label Booking_Label_Customer;
        private System.Windows.Forms.Label Booking_Label_ID;
        private System.Windows.Forms.DataGridView Grid_Booking;
        private System.Windows.Forms.TabPage Tabs_TickeTypes;
        private System.Windows.Forms.Button TicketType_Button_Insert;
        private System.Windows.Forms.Button TicketType_Button_Clear;
        private System.Windows.Forms.Button TicketType_Button_Update;
        private System.Windows.Forms.TextBox TicketType_Textbox_TicketType;
        private System.Windows.Forms.TextBox TicketType_Textbox_ID;
        private System.Windows.Forms.Label TicketType_Label_TicketType;
        private System.Windows.Forms.Label TicketType_Label_Discount;
        private System.Windows.Forms.Label TicketType_Label_ID;
        private System.Windows.Forms.DataGridView Grid_TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.NumericUpDown TicketType_Textbox_Discount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_Tickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Booking_Textbox_Screening;
        private System.Windows.Forms.Button Booking_Button_ChooseTickets;
        private System.Windows.Forms.FlowLayoutPanel Booking_Tickets_TicketTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking_Screening;
        private System.Windows.Forms.Button Booking_Button_ShowSuggestions;
        private System.Windows.Forms.TabPage Tabs_Users;
        private System.Windows.Forms.Button Users_Button_Insert;
        private System.Windows.Forms.Button Users_Button_Clear;
        private System.Windows.Forms.Button Users_Button_Update;
        private System.Windows.Forms.Label Users_Label_CreatedOn;
        private System.Windows.Forms.ComboBox Users_Combobox_AccessLevel;
        private System.Windows.Forms.Label Users_Label_AccessLevel;
        private System.Windows.Forms.TextBox Users_Textbox_CreatedBy;
        private System.Windows.Forms.Label Users_Label_CreatedBy;
        private System.Windows.Forms.TextBox Users_Textbox_Phone;
        private System.Windows.Forms.Label Users_Label_Phone;
        private System.Windows.Forms.TextBox Users_Textbox_Email;
        private System.Windows.Forms.Label Users_Label_Email;
        private System.Windows.Forms.Label Users_Label_LastName;
        private System.Windows.Forms.TextBox Users_Textbox_FirstName;
        private System.Windows.Forms.Label Users_Label_FirstName;
        private System.Windows.Forms.TextBox Users_Textbox_ID;
        private System.Windows.Forms.Label Users_Label_ID;
        private System.Windows.Forms.DataGridView Grid_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDeleted;
        private System.Windows.Forms.TextBox Users_Textbox_LastName;
        private System.Windows.Forms.TextBox Users_Textbox_UpdatedBy;
        private System.Windows.Forms.Label Users_Label_UpdatedBy;
        private System.Windows.Forms.Label Users_Label_UpdatedOn;
        private System.Windows.Forms.Label Users_Label_LastLogin;
        private System.Windows.Forms.CheckBox Users_Checkbox_IsDeleted;
        private System.Windows.Forms.Label Users_Label_IsDeleted;
        private System.Windows.Forms.TextBox Users_Textbox_UpdatedOn;
        private System.Windows.Forms.TextBox Users_Textbox_CreatedOn;
        private System.Windows.Forms.TextBox Users_Textbox_LastLogin;
        private System.Windows.Forms.TextBox Users_Textbox_ConfirmPassword;
        private System.Windows.Forms.Label Users_Label_ConfirmPassword;
        private System.Windows.Forms.TextBox Users_Textbox_Password;
        private System.Windows.Forms.Label Users_Label_Password;
        private System.Windows.Forms.Panel Users_Panel_Password;
        private System.Windows.Forms.Panel Users_Panel_UpdatePanel;
        private System.Windows.Forms.Label Label_LoggedInAs;


    }
}