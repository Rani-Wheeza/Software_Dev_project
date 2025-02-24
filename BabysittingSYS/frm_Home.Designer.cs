namespace BabysittingSYS
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.mnu_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Bookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.bnClient = new System.Windows.Forms.Button();
            this.bnSitter = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.bn_Admin = new System.Windows.Forms.Button();
            this.mnu_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_Services
            // 
            this.mnu_Services.Name = "mnu_Services";
            this.mnu_Services.Size = new System.Drawing.Size(76, 24);
            this.mnu_Services.Text = "Services";
            // 
            // mnu_MainMenu
            // 
            this.mnu_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Home,
            this.mnu_Bookings,
            this.mnu_Services,
            this.mnu_Rates,
            this.mnu_AboutUs});
            this.mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainMenu.Name = "mnu_MainMenu";
            this.mnu_MainMenu.Size = new System.Drawing.Size(1147, 28);
            this.mnu_MainMenu.TabIndex = 7;
            this.mnu_MainMenu.Text = "Main Menu";
            this.mnu_MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_MainMenu_ItemClicked);
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
            this.mnu_AboutUs.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(274, 64);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(721, 430);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 8;
            this.pb_Logo.TabStop = false;
            // 
            // bnClient
            // 
            this.bnClient.Location = new System.Drawing.Point(340, 609);
            this.bnClient.Name = "bnClient";
            this.bnClient.Size = new System.Drawing.Size(185, 57);
            this.bnClient.TabIndex = 9;
            this.bnClient.Text = "Client";
            this.bnClient.UseVisualStyleBackColor = true;
            this.bnClient.Click += new System.EventHandler(this.bnClient_Click);
            // 
            // bnSitter
            // 
            this.bnSitter.Location = new System.Drawing.Point(639, 609);
            this.bnSitter.Name = "bnSitter";
            this.bnSitter.Size = new System.Drawing.Size(185, 57);
            this.bnSitter.TabIndex = 10;
            this.bnSitter.Text = "Siiter";
            this.bnSitter.UseVisualStyleBackColor = true;
            this.bnSitter.Click += new System.EventHandler(this.bnSitter_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(578, 539);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(160, 32);
            this.lbQuestion.TabIndex = 11;
            this.lbQuestion.Text = "Are you are Client or Sitter\r\n or Admin";
            this.lbQuestion.Click += new System.EventHandler(this.lbQuestion_Click);
            // 
            // bn_Admin
            // 
            this.bn_Admin.Location = new System.Drawing.Point(896, 609);
            this.bn_Admin.Name = "bn_Admin";
            this.bn_Admin.Size = new System.Drawing.Size(185, 57);
            this.bn_Admin.TabIndex = 12;
            this.bn_Admin.Text = "Admin";
            this.bn_Admin.UseVisualStyleBackColor = true;
            this.bn_Admin.Click += new System.EventHandler(this.bn_Admin_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 688);
            this.Controls.Add(this.bn_Admin);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.bnSitter);
            this.Controls.Add(this.bnClient);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.mnu_MainMenu);
            this.Name = "frm_Home";
            this.Text = "Babysitting - Admin";
            this.Load += new System.EventHandler(this.Home_Load);
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnu_Services;
        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_Home;
        private System.Windows.Forms.ToolStripMenuItem mnu_Bookings;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rates;
        private System.Windows.Forms.ToolStripMenuItem mnu_AboutUs;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button bnClient;
        private System.Windows.Forms.Button bnSitter;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button bn_Admin;
    }
}