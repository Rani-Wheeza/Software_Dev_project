namespace BabysittingSYS
{
    partial class frm_CancelBooking
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
            this.bn_Submit = new System.Windows.Forms.Button();
            this.txt_SecurityCode = new System.Windows.Forms.TextBox();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.lb_SecurityCode = new System.Windows.Forms.Label();
            this.lb_CardNumber = new System.Windows.Forms.Label();
            this.lb_Expires = new System.Windows.Forms.Label();
            this.txt_BookingID = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.rb_VisaPayment = new System.Windows.Forms.RadioButton();
            this.rb_Person = new System.Windows.Forms.RadioButton();
            this.gb_PaymentMethod = new System.Windows.Forms.GroupBox();
            this.txt_Ecxpires = new System.Windows.Forms.TextBox();
            this.dtp_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lb_Time = new System.Windows.Forms.Label();
            this.cbo_Services = new System.Windows.Forms.ComboBox();
            this.lb_ExtraInfromation = new System.Windows.Forms.Label();
            this.bn_Confirm = new System.Windows.Forms.Button();
            this.bn_Back = new System.Windows.Forms.Button();
            this.lb_BookingID = new System.Windows.Forms.Label();
            this.dtp_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lb_Services = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.gb_CancelBooking = new System.Windows.Forms.GroupBox();
            this.txt_ExtraInformation = new System.Windows.Forms.TextBox();
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Bookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_PaymentMethod.SuspendLayout();
            this.gb_CancelBooking.SuspendLayout();
            this.mnu_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_Submit
            // 
            this.bn_Submit.Location = new System.Drawing.Point(129, 301);
            this.bn_Submit.Name = "bn_Submit";
            this.bn_Submit.Size = new System.Drawing.Size(93, 37);
            this.bn_Submit.TabIndex = 11;
            this.bn_Submit.Text = "Submit";
            this.bn_Submit.UseVisualStyleBackColor = true;
            // 
            // txt_SecurityCode
            // 
            this.txt_SecurityCode.Location = new System.Drawing.Point(263, 215);
            this.txt_SecurityCode.Name = "txt_SecurityCode";
            this.txt_SecurityCode.Size = new System.Drawing.Size(75, 22);
            this.txt_SecurityCode.TabIndex = 9;
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Location = new System.Drawing.Point(99, 165);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(174, 22);
            this.txt_CardNumber.TabIndex = 8;
            // 
            // lb_SecurityCode
            // 
            this.lb_SecurityCode.AutoSize = true;
            this.lb_SecurityCode.Location = new System.Drawing.Point(168, 221);
            this.lb_SecurityCode.Name = "lb_SecurityCode";
            this.lb_SecurityCode.Size = new System.Drawing.Size(91, 16);
            this.lb_SecurityCode.TabIndex = 7;
            this.lb_SecurityCode.Text = "Security Code";
            // 
            // lb_CardNumber
            // 
            this.lb_CardNumber.AutoSize = true;
            this.lb_CardNumber.Location = new System.Drawing.Point(6, 171);
            this.lb_CardNumber.Name = "lb_CardNumber";
            this.lb_CardNumber.Size = new System.Drawing.Size(87, 16);
            this.lb_CardNumber.TabIndex = 6;
            this.lb_CardNumber.Text = "Card Number";
            // 
            // lb_Expires
            // 
            this.lb_Expires.AutoSize = true;
            this.lb_Expires.Location = new System.Drawing.Point(6, 218);
            this.lb_Expires.Name = "lb_Expires";
            this.lb_Expires.Size = new System.Drawing.Size(55, 16);
            this.lb_Expires.TabIndex = 5;
            this.lb_Expires.Text = "Expires ";
            // 
            // txt_BookingID
            // 
            this.txt_BookingID.Location = new System.Drawing.Point(124, 38);
            this.txt_BookingID.Name = "txt_BookingID";
            this.txt_BookingID.Size = new System.Drawing.Size(100, 22);
            this.txt_BookingID.TabIndex = 5;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(6, 136);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 16);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(99, 133);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(174, 22);
            this.txt_Name.TabIndex = 3;
            // 
            // rb_VisaPayment
            // 
            this.rb_VisaPayment.AutoSize = true;
            this.rb_VisaPayment.Location = new System.Drawing.Point(6, 78);
            this.rb_VisaPayment.Name = "rb_VisaPayment";
            this.rb_VisaPayment.Size = new System.Drawing.Size(110, 20);
            this.rb_VisaPayment.TabIndex = 1;
            this.rb_VisaPayment.TabStop = true;
            this.rb_VisaPayment.Text = "Visa payment";
            this.rb_VisaPayment.UseVisualStyleBackColor = true;
            // 
            // rb_Person
            // 
            this.rb_Person.AutoSize = true;
            this.rb_Person.Location = new System.Drawing.Point(6, 37);
            this.rb_Person.Name = "rb_Person";
            this.rb_Person.Size = new System.Drawing.Size(167, 20);
            this.rb_Person.TabIndex = 0;
            this.rb_Person.TabStop = true;
            this.rb_Person.Text = "Pay in person with cash";
            this.rb_Person.UseVisualStyleBackColor = true;
            // 
            // gb_PaymentMethod
            // 
            this.gb_PaymentMethod.Controls.Add(this.bn_Submit);
            this.gb_PaymentMethod.Controls.Add(this.txt_Ecxpires);
            this.gb_PaymentMethod.Controls.Add(this.txt_SecurityCode);
            this.gb_PaymentMethod.Controls.Add(this.txt_CardNumber);
            this.gb_PaymentMethod.Controls.Add(this.lb_SecurityCode);
            this.gb_PaymentMethod.Controls.Add(this.lb_CardNumber);
            this.gb_PaymentMethod.Controls.Add(this.lb_Expires);
            this.gb_PaymentMethod.Controls.Add(this.lb_Name);
            this.gb_PaymentMethod.Controls.Add(this.txt_Name);
            this.gb_PaymentMethod.Controls.Add(this.rb_VisaPayment);
            this.gb_PaymentMethod.Controls.Add(this.rb_Person);
            this.gb_PaymentMethod.Location = new System.Drawing.Point(515, 64);
            this.gb_PaymentMethod.Name = "gb_PaymentMethod";
            this.gb_PaymentMethod.Size = new System.Drawing.Size(369, 378);
            this.gb_PaymentMethod.TabIndex = 18;
            this.gb_PaymentMethod.TabStop = false;
            this.gb_PaymentMethod.Text = "Payment Method";
            // 
            // txt_Ecxpires
            // 
            this.txt_Ecxpires.Location = new System.Drawing.Point(56, 215);
            this.txt_Ecxpires.Name = "txt_Ecxpires";
            this.txt_Ecxpires.Size = new System.Drawing.Size(74, 22);
            this.txt_Ecxpires.TabIndex = 10;
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.Location = new System.Drawing.Point(124, 138);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.Size = new System.Drawing.Size(222, 22);
            this.dtp_DateTo.TabIndex = 17;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(42, 144);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(41, 16);
            this.lb_Time.TabIndex = 16;
            this.lb_Time.Text = "Time:";
            // 
            // cbo_Services
            // 
            this.cbo_Services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Services.FormattingEnabled = true;
            this.cbo_Services.Items.AddRange(new object[] {
            "Help with homework",
            "Bathing children and putting htem to bed",
            "Pick up from school",
            "Pick up from after-school activities",
            "Prepare meals and snacks",
            "Light work around the house",
            "Changing diapers"});
            this.cbo_Services.Location = new System.Drawing.Point(124, 200);
            this.cbo_Services.Name = "cbo_Services";
            this.cbo_Services.Size = new System.Drawing.Size(222, 24);
            this.cbo_Services.TabIndex = 14;
            // 
            // lb_ExtraInfromation
            // 
            this.lb_ExtraInfromation.AutoSize = true;
            this.lb_ExtraInfromation.Location = new System.Drawing.Point(156, 282);
            this.lb_ExtraInfromation.Name = "lb_ExtraInfromation";
            this.lb_ExtraInfromation.Size = new System.Drawing.Size(105, 16);
            this.lb_ExtraInfromation.TabIndex = 13;
            this.lb_ExtraInfromation.Text = "Extra Infromation";
            // 
            // bn_Confirm
            // 
            this.bn_Confirm.Location = new System.Drawing.Point(391, 483);
            this.bn_Confirm.Name = "bn_Confirm";
            this.bn_Confirm.Size = new System.Drawing.Size(109, 33);
            this.bn_Confirm.TabIndex = 12;
            this.bn_Confirm.Text = "Confirm";
            this.bn_Confirm.UseVisualStyleBackColor = true;
            // 
            // bn_Back
            // 
            this.bn_Back.Location = new System.Drawing.Point(1108, 45);
            this.bn_Back.Name = "bn_Back";
            this.bn_Back.Size = new System.Drawing.Size(77, 24);
            this.bn_Back.TabIndex = 14;
            this.bn_Back.Text = "Back";
            this.bn_Back.UseVisualStyleBackColor = true;
            // 
            // lb_BookingID
            // 
            this.lb_BookingID.AutoSize = true;
            this.lb_BookingID.Location = new System.Drawing.Point(42, 41);
            this.lb_BookingID.Name = "lb_BookingID";
            this.lb_BookingID.Size = new System.Drawing.Size(73, 16);
            this.lb_BookingID.TabIndex = 2;
            this.lb_BookingID.Text = "Booking ID";
            // 
            // dtp_DateFrom
            // 
            this.dtp_DateFrom.Location = new System.Drawing.Point(124, 96);
            this.dtp_DateFrom.Name = "dtp_DateFrom";
            this.dtp_DateFrom.Size = new System.Drawing.Size(222, 22);
            this.dtp_DateFrom.TabIndex = 2;
            this.dtp_DateFrom.Value = new System.DateTime(2024, 12, 2, 16, 47, 32, 0);
            // 
            // lb_Services
            // 
            this.lb_Services.AutoSize = true;
            this.lb_Services.Location = new System.Drawing.Point(42, 208);
            this.lb_Services.Name = "lb_Services";
            this.lb_Services.Size = new System.Drawing.Size(60, 16);
            this.lb_Services.TabIndex = 1;
            this.lb_Services.Text = "Services";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(42, 101);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(39, 16);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "Date:";
            // 
            // gb_CancelBooking
            // 
            this.gb_CancelBooking.Controls.Add(this.txt_BookingID);
            this.gb_CancelBooking.Controls.Add(this.gb_PaymentMethod);
            this.gb_CancelBooking.Controls.Add(this.dtp_DateTo);
            this.gb_CancelBooking.Controls.Add(this.lb_Time);
            this.gb_CancelBooking.Controls.Add(this.lb_BookingID);
            this.gb_CancelBooking.Controls.Add(this.txt_ExtraInformation);
            this.gb_CancelBooking.Controls.Add(this.cbo_Services);
            this.gb_CancelBooking.Controls.Add(this.lb_ExtraInfromation);
            this.gb_CancelBooking.Controls.Add(this.bn_Confirm);
            this.gb_CancelBooking.Controls.Add(this.dtp_DateFrom);
            this.gb_CancelBooking.Controls.Add(this.lb_Services);
            this.gb_CancelBooking.Controls.Add(this.lb_Date);
            this.gb_CancelBooking.Location = new System.Drawing.Point(87, 107);
            this.gb_CancelBooking.Name = "gb_CancelBooking";
            this.gb_CancelBooking.Size = new System.Drawing.Size(918, 565);
            this.gb_CancelBooking.TabIndex = 13;
            this.gb_CancelBooking.TabStop = false;
            this.gb_CancelBooking.Text = "Cancel Booking";
            // 
            // txt_ExtraInformation
            // 
            this.txt_ExtraInformation.Location = new System.Drawing.Point(64, 301);
            this.txt_ExtraInformation.Multiline = true;
            this.txt_ExtraInformation.Name = "txt_ExtraInformation";
            this.txt_ExtraInformation.Size = new System.Drawing.Size(405, 160);
            this.txt_ExtraInformation.TabIndex = 15;
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
            this.mnu_MainMenu.Size = new System.Drawing.Size(1238, 28);
            this.mnu_MainMenu.TabIndex = 12;
            this.mnu_MainMenu.Text = "Main Menu";
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
            // frm_CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 712);
            this.Controls.Add(this.bn_Back);
            this.Controls.Add(this.gb_CancelBooking);
            this.Controls.Add(this.mnu_MainMenu);
            this.Name = "frm_CancelBooking";
            this.Text = "frm_CancelBooking";
            this.gb_PaymentMethod.ResumeLayout(false);
            this.gb_PaymentMethod.PerformLayout();
            this.gb_CancelBooking.ResumeLayout(false);
            this.gb_CancelBooking.PerformLayout();
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_Submit;
        private System.Windows.Forms.TextBox txt_SecurityCode;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.Label lb_SecurityCode;
        private System.Windows.Forms.Label lb_CardNumber;
        private System.Windows.Forms.Label lb_Expires;
        private System.Windows.Forms.TextBox txt_BookingID;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.RadioButton rb_VisaPayment;
        private System.Windows.Forms.RadioButton rb_Person;
        private System.Windows.Forms.GroupBox gb_PaymentMethod;
        private System.Windows.Forms.TextBox txt_Ecxpires;
        private System.Windows.Forms.DateTimePicker dtp_DateTo;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.ComboBox cbo_Services;
        private System.Windows.Forms.Label lb_ExtraInfromation;
        private System.Windows.Forms.Button bn_Confirm;
        private System.Windows.Forms.Button bn_Back;
        private System.Windows.Forms.Label lb_BookingID;
        private System.Windows.Forms.DateTimePicker dtp_DateFrom;
        private System.Windows.Forms.Label lb_Services;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.GroupBox gb_CancelBooking;
        private System.Windows.Forms.TextBox txt_ExtraInformation;
        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_Home;
        private System.Windows.Forms.ToolStripMenuItem mnu_Bookings;
        private System.Windows.Forms.ToolStripMenuItem mnu_Services;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rates;
        private System.Windows.Forms.ToolStripMenuItem mnu_AboutUs;
    }
}