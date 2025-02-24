namespace BabysittingSYS
{
    partial class frmAddClient
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
            this.GB_AddClientDetails = new System.Windows.Forms.GroupBox();
            this.cbo_NoOfChildren = new System.Windows.Forms.ComboBox();
            this.bnEnterDetails = new System.Windows.Forms.Button();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ClientID = new System.Windows.Forms.TextBox();
            this.txt_Eircode = new System.Windows.Forms.TextBox();
            this.txt_Town = new System.Windows.Forms.TextBox();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lb_ClientID = new System.Windows.Forms.Label();
            this.lb_NoOfChildern = new System.Windows.Forms.Label();
            this.lb_Eircode = new System.Windows.Forms.Label();
            this.lb_Town = new System.Windows.Forms.Label();
            this.lb_Street = new System.Windows.Forms.Label();
            this.lb_PhoneNo = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Bookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Back = new System.Windows.Forms.Button();
            this.GB_AddClientDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_AddClientDetails
            // 
            this.GB_AddClientDetails.Controls.Add(this.cbo_NoOfChildren);
            this.GB_AddClientDetails.Controls.Add(this.bnEnterDetails);
            this.GB_AddClientDetails.Controls.Add(this.txt_LastName);
            this.GB_AddClientDetails.Controls.Add(this.txt_Email);
            this.GB_AddClientDetails.Controls.Add(this.txt_ClientID);
            this.GB_AddClientDetails.Controls.Add(this.txt_Eircode);
            this.GB_AddClientDetails.Controls.Add(this.txt_Town);
            this.GB_AddClientDetails.Controls.Add(this.txt_Street);
            this.GB_AddClientDetails.Controls.Add(this.txt_PhoneNo);
            this.GB_AddClientDetails.Controls.Add(this.txt_FirstName);
            this.GB_AddClientDetails.Controls.Add(this.lb_ClientID);
            this.GB_AddClientDetails.Controls.Add(this.lb_NoOfChildern);
            this.GB_AddClientDetails.Controls.Add(this.lb_Eircode);
            this.GB_AddClientDetails.Controls.Add(this.lb_Town);
            this.GB_AddClientDetails.Controls.Add(this.lb_Street);
            this.GB_AddClientDetails.Controls.Add(this.lb_PhoneNo);
            this.GB_AddClientDetails.Controls.Add(this.lb_Email);
            this.GB_AddClientDetails.Controls.Add(this.lb_LastName);
            this.GB_AddClientDetails.Controls.Add(this.lb_FirstName);
            this.GB_AddClientDetails.Location = new System.Drawing.Point(39, 49);
            this.GB_AddClientDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddClientDetails.Name = "GB_AddClientDetails";
            this.GB_AddClientDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddClientDetails.Size = new System.Drawing.Size(961, 604);
            this.GB_AddClientDetails.TabIndex = 0;
            this.GB_AddClientDetails.TabStop = false;
            this.GB_AddClientDetails.Text = "Add Client Details";
            this.GB_AddClientDetails.Enter += new System.EventHandler(this.GB_AddClientDetails_Enter);
            // 
            // cbo_NoOfChildren
            // 
            this.cbo_NoOfChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NoOfChildren.FormattingEnabled = true;
            this.cbo_NoOfChildren.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cbo_NoOfChildren.Location = new System.Drawing.Point(149, 442);
            this.cbo_NoOfChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_NoOfChildren.Name = "cbo_NoOfChildren";
            this.cbo_NoOfChildren.Size = new System.Drawing.Size(121, 24);
            this.cbo_NoOfChildren.TabIndex = 19;
            // 
            // bnEnterDetails
            // 
            this.bnEnterDetails.Location = new System.Drawing.Point(325, 544);
            this.bnEnterDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnEnterDetails.Name = "bnEnterDetails";
            this.bnEnterDetails.Size = new System.Drawing.Size(192, 37);
            this.bnEnterDetails.TabIndex = 18;
            this.bnEnterDetails.Text = "Enter Details";
            this.bnEnterDetails.UseVisualStyleBackColor = true;
            this.bnEnterDetails.Click += new System.EventHandler(this.bnEnterDetails_Click_1);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(149, 171);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(192, 22);
            this.txt_LastName.TabIndex = 17;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(149, 263);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(192, 22);
            this.txt_Email.TabIndex = 16;
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.Enabled = false;
            this.txt_ClientID.Location = new System.Drawing.Point(149, 69);
            this.txt_ClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.Size = new System.Drawing.Size(79, 22);
            this.txt_ClientID.TabIndex = 15;
            // 
            // txt_Eircode
            // 
            this.txt_Eircode.Location = new System.Drawing.Point(149, 402);
            this.txt_Eircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Eircode.Name = "txt_Eircode";
            this.txt_Eircode.Size = new System.Drawing.Size(192, 22);
            this.txt_Eircode.TabIndex = 14;
            // 
            // txt_Town
            // 
            this.txt_Town.Location = new System.Drawing.Point(149, 375);
            this.txt_Town.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Town.Name = "txt_Town";
            this.txt_Town.Size = new System.Drawing.Size(192, 22);
            this.txt_Town.TabIndex = 13;
            // 
            // txt_Street
            // 
            this.txt_Street.Location = new System.Drawing.Point(149, 347);
            this.txt_Street.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(192, 22);
            this.txt_Street.TabIndex = 12;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Location = new System.Drawing.Point(149, 292);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.Size = new System.Drawing.Size(192, 22);
            this.txt_PhoneNo.TabIndex = 11;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(149, 143);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(192, 22);
            this.txt_FirstName.TabIndex = 9;
            // 
            // lb_ClientID
            // 
            this.lb_ClientID.AutoSize = true;
            this.lb_ClientID.Location = new System.Drawing.Point(52, 73);
            this.lb_ClientID.Name = "lb_ClientID";
            this.lb_ClientID.Size = new System.Drawing.Size(56, 16);
            this.lb_ClientID.TabIndex = 8;
            this.lb_ClientID.Text = "Client ID";
            this.lb_ClientID.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_NoOfChildern
            // 
            this.lb_NoOfChildern.AutoSize = true;
            this.lb_NoOfChildern.Location = new System.Drawing.Point(52, 450);
            this.lb_NoOfChildern.Name = "lb_NoOfChildern";
            this.lb_NoOfChildern.Size = new System.Drawing.Size(92, 16);
            this.lb_NoOfChildern.TabIndex = 7;
            this.lb_NoOfChildern.Text = "No. of children";
            // 
            // lb_Eircode
            // 
            this.lb_Eircode.AutoSize = true;
            this.lb_Eircode.Location = new System.Drawing.Point(52, 402);
            this.lb_Eircode.Name = "lb_Eircode";
            this.lb_Eircode.Size = new System.Drawing.Size(54, 16);
            this.lb_Eircode.TabIndex = 6;
            this.lb_Eircode.Text = "Eircode";
            // 
            // lb_Town
            // 
            this.lb_Town.AutoSize = true;
            this.lb_Town.Location = new System.Drawing.Point(52, 375);
            this.lb_Town.Name = "lb_Town";
            this.lb_Town.Size = new System.Drawing.Size(40, 16);
            this.lb_Town.TabIndex = 5;
            this.lb_Town.Text = "Town";
            // 
            // lb_Street
            // 
            this.lb_Street.AutoSize = true;
            this.lb_Street.Location = new System.Drawing.Point(52, 347);
            this.lb_Street.Name = "lb_Street";
            this.lb_Street.Size = new System.Drawing.Size(42, 16);
            this.lb_Street.TabIndex = 4;
            this.lb_Street.Text = "Street";
            // 
            // lb_PhoneNo
            // 
            this.lb_PhoneNo.AutoSize = true;
            this.lb_PhoneNo.Location = new System.Drawing.Point(52, 298);
            this.lb_PhoneNo.Name = "lb_PhoneNo";
            this.lb_PhoneNo.Size = new System.Drawing.Size(64, 16);
            this.lb_PhoneNo.TabIndex = 3;
            this.lb_PhoneNo.Text = "PhoneNo";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(52, 270);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(41, 16);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Location = new System.Drawing.Point(52, 177);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(72, 16);
            this.lb_LastName.TabIndex = 1;
            this.lb_LastName.Text = "Last Name";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(52, 149);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(72, 16);
            this.lb_FirstName.TabIndex = 0;
            this.lb_FirstName.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Home,
            this.mnu_Bookings,
            this.mnu_Services,
            this.mnu_Rates,
            this.mnu_AboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1115, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_Home
            // 
            this.mnu_Home.Name = "mnu_Home";
            this.mnu_Home.Size = new System.Drawing.Size(64, 24);
            this.mnu_Home.Text = "Home";
            // 
            // mnu_Bookings
            // 
            this.mnu_Bookings.Name = "mnu_Bookings";
            this.mnu_Bookings.Size = new System.Drawing.Size(84, 24);
            this.mnu_Bookings.Text = "Bookings";
            this.mnu_Bookings.Click += new System.EventHandler(this.mnu_Bookings_Click);
            // 
            // mnu_Services
            // 
            this.mnu_Services.Name = "mnu_Services";
            this.mnu_Services.Size = new System.Drawing.Size(76, 24);
            this.mnu_Services.Text = "Services";
            // 
            // mnu_Rates
            // 
            this.mnu_Rates.Name = "mnu_Rates";
            this.mnu_Rates.Size = new System.Drawing.Size(59, 24);
            this.mnu_Rates.Text = "Rates";
            // 
            // mnu_AboutUs
            // 
            this.mnu_AboutUs.Name = "mnu_AboutUs";
            this.mnu_AboutUs.Size = new System.Drawing.Size(82, 24);
            this.mnu_AboutUs.Text = "About us";
            // 
            // bn_Back
            // 
            this.bn_Back.Location = new System.Drawing.Point(1026, 4);
            this.bn_Back.Name = "bn_Back";
            this.bn_Back.Size = new System.Drawing.Size(77, 24);
            this.bn_Back.TabIndex = 2;
            this.bn_Back.Text = "Back";
            this.bn_Back.UseVisualStyleBackColor = true;
            this.bn_Back.Click += new System.EventHandler(this.bn_Back_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 665);
            this.Controls.Add(this.bn_Back);
            this.Controls.Add(this.GB_AddClientDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_AddClientDetails.ResumeLayout(false);
            this.GB_AddClientDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_AddClientDetails;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_ClientID;
        private System.Windows.Forms.TextBox txt_Eircode;
        private System.Windows.Forms.TextBox txt_Town;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lb_ClientID;
        private System.Windows.Forms.Label lb_NoOfChildern;
        private System.Windows.Forms.Label lb_Eircode;
        private System.Windows.Forms.Label lb_Town;
        private System.Windows.Forms.Label lb_Street;
        private System.Windows.Forms.Label lb_PhoneNo;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bnEnterDetails;
        private System.Windows.Forms.ComboBox cbo_NoOfChildren;
        private System.Windows.Forms.Button bn_Back;
        private System.Windows.Forms.ToolStripMenuItem mnu_Home;
        private System.Windows.Forms.ToolStripMenuItem mnu_Bookings;
        private System.Windows.Forms.ToolStripMenuItem mnu_Services;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rates;
        private System.Windows.Forms.ToolStripMenuItem mnu_AboutUs;
    }
}

