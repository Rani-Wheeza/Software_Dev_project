using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabysittingSYS
{
    public partial class frm_MakeBooking : Form
    {
        public frm_MakeBooking()
        {
            InitializeComponent();
        }

        private void frm_MakeBooking_Load(object sender, EventArgs e)
        {
            txt_BookingID.Text = "30001";
        }

        private void bn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void dtp_DateFrom_ValueChanged(object sender, EventArgs e)
        {

            DateTime selectedDate = dtp_DateFrom.Value;
            DateTime today = DateTime.Today;


            if (selectedDate < today)
            {
               MessageBox.Show("The selceted date is in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dtp_DateFrom.Text.Equals(""))
            {
                MessageBox.Show("Select a date!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_DateFrom.Focus();
                return;
            }
        }

        private void bn_Confirm_Click(object sender, EventArgs e)
        {
            if (dtp_DateTo.Value.Date < dtp_DateFrom.Value.Date) 
            {
                MessageBox.Show("The 'Date To' must either be today or after the 'Date From'.", "Invalid Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(string.Format("You selected: {0} -- {1}",
                dtp_DateFrom.Value.ToString("MM dd YYYY HH:mm"),
                dtp_DateTo.Value.ToString("MM dd YYYY HH:mm")),"Date Confirmation",MessageBoxButtons.OK
 );

            txt_BookingID.Text = "30002";
            lb_Date.Focus();
        }
        /*else if (selectedDate == today)
            {
                MessageBox.Show("The selected date is today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                MessageBox.Show("The selceted date is in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

    }
}
