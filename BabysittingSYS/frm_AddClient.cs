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
    public partial class frmAddClient : Form
    {
        frm_Home parent;
        public frmAddClient()
        {
            InitializeComponent();
        }

        public frmAddClient(frm_Home parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ClientID.Text = "00001";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bnEnterDetails_Click_1(object sender, EventArgs e)
        {
            //validate data
            if (txt_FirstName.Text.Equals(""))
            {
                MessageBox.Show("First name is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_FirstName.Focus();
                return;
            }

            if (txt_LastName.Text.Equals(""))
            {
                MessageBox.Show("Last name is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LastName.Focus();
                return;
            }

            if (txt_Email.Text.Equals(""))
            {
                MessageBox.Show("Email is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return;
            }

            if (txt_PhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Phone number is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PhoneNo.Focus();

                if (string.IsNullOrEmpty(lb_PhoneNo.Text))
                {
                    if (string.IsNullOrEmpty(lb_PhoneNo.Text))
                    {
                        MessageBox.Show("The Phone Number cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                    else if (lb_PhoneNo.Text.Length != 10)
                    {
                        MessageBox.Show("The Phone Number must be 10 digits long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                }

                else
                {
                    MessageBox.Show("The Phone Number entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }


                return;

            }

            if (txt_Street.Text.Equals(""))
            {
                MessageBox.Show("Street address is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Street.Focus();
                return;
            }

            if (txt_Eircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Eircode.Focus();
                return;
            }

            if (txt_Town.Text.Equals(""))
            {
                MessageBox.Show("Town is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Town.Focus();
                return;
            }

            if (cbo_NoOfChildren.SelectedIndex == -1)
            {
                MessageBox.Show("Number of children must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_NoOfChildren.Focus();
                return;
            }




            //display confirmation message


            //Reset UI
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Email.Clear();
            txt_PhoneNo.Clear();
            txt_Street.Clear();
            txt_Eircode.Clear();
            txt_Town.Clear();




            cbo_NoOfChildren.SelectedIndex = -1;
            txt_ClientID.Text = "00002";
            txt_FirstName.Focus();
            
        }

        private void bn_Back_Click(object sender, EventArgs e)
        {
            Parent.Visible = true;
            this.Close();
            
        }

        private void GB_AddClientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void mnu_Bookings_Click(object sender, EventArgs e)
        {
            frm_MakeBooking frm_MakeBooking = new frm_MakeBooking();

            frm_MakeBooking.Show();
            this.Hide();
        }
    }
}
