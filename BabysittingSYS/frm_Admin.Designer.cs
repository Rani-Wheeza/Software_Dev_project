namespace BabysittingSYS
{
    partial class frm_Admin
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.lb_AdminID = new System.Windows.Forms.Label();
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.bn_Login = new System.Windows.Forms.Button();
            this.mnu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Bookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bn_Back = new System.Windows.Forms.Button();
            this.gb_login.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.bn_Login);
            this.gb_login.Controls.Add(this.txt_Password);
            this.gb_login.Controls.Add(this.txt_Username);
            this.gb_login.Controls.Add(this.lb_Password);
            this.gb_login.Controls.Add(this.lb_Username);
            this.gb_login.Controls.Add(this.txt_AdminID);
            this.gb_login.Controls.Add(this.lb_AdminID);
            this.gb_login.Location = new System.Drawing.Point(149, 84);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(737, 403);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // lb_AdminID
            // 
            this.lb_AdminID.AutoSize = true;
            this.lb_AdminID.Location = new System.Drawing.Point(38, 62);
            this.lb_AdminID.Name = "lb_AdminID";
            this.lb_AdminID.Size = new System.Drawing.Size(61, 16);
            this.lb_AdminID.TabIndex = 0;
            this.lb_AdminID.Text = "Admin ID";
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.Location = new System.Drawing.Point(130, 59);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminID.TabIndex = 1;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(86, 142);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(70, 16);
            this.lb_Username.TabIndex = 2;
            this.lb_Username.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(86, 186);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(67, 16);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(157, 136);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(146, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(157, 180);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(146, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // bn_Login
            // 
            this.bn_Login.Location = new System.Drawing.Point(266, 241);
            this.bn_Login.Name = "bn_Login";
            this.bn_Login.Size = new System.Drawing.Size(122, 41);
            this.bn_Login.TabIndex = 6;
            this.bn_Login.Text = "Login";
            this.bn_Login.UseVisualStyleBackColor = true;
            this.bn_Login.Click += new System.EventHandler(this.bn_Login_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bn_Back
            // 
            this.bn_Back.Location = new System.Drawing.Point(1035, 4);
            this.bn_Back.Name = "bn_Back";
            this.bn_Back.Size = new System.Drawing.Size(77, 24);
            this.bn_Back.TabIndex = 7;
            this.bn_Back.Text = "Back";
            this.bn_Back.UseVisualStyleBackColor = true;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 648);
            this.Controls.Add(this.bn_Back);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gb_login);
            this.Name = "frm_Admin";
            this.Text = "frm_Admin";
            this.Load += new System.EventHandler(this.frm_Admin_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.Label lb_AdminID;
        private System.Windows.Forms.Button bn_Login;
        private System.Windows.Forms.ToolStripMenuItem mnu_Home;
        private System.Windows.Forms.ToolStripMenuItem mnu_Bookings;
        private System.Windows.Forms.ToolStripMenuItem mnu_Services;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rates;
        private System.Windows.Forms.ToolStripMenuItem mnu_AboutUs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bn_Back;
    }
}