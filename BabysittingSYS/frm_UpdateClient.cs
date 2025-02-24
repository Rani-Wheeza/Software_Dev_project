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
    public partial class frm_UpdateClient : Form
    {
        public frm_UpdateClient()
        {
            InitializeComponent();
        }

        private void GB_UpdateClientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ClientID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_UpdateClient_Load(object sender, EventArgs e)
        {
            txt_ClientID.Text = "00001";
        }

        private void bnUpdateDetails_Click(object sender, EventArgs e)
        {
            bool FName = false;
            bool LName = false;
            bool PhoneNo = false;   
            bool Email = false;
            bool Town = false;
            bool Street = false;
            bool Eircode = false;
            bool Children = false;


            if (!(lb_FirstName.Text.Equals("")))
            {
                FName = true;
            }

            if (!(lb_LastName.Text.Equals("")))
            {
                LName = true;
            }

            if (!(lb_Email.Text.Equals("")))
            {
                Email = true;
            }

            if (!(lb_PhoneNo.Text.Equals("")))
            {
                PhoneNo = true;
            }

            if (!(lb_Town.Text.Equals("")))
            {
                Town = true;
            }

            if (!(lb_Street.Text.Equals("")))
            {
                Street = true;
            }

            if (!(lb_Eircode.Text.Equals("")))
            {
                Eircode = true;
            }

            if (!(lb_NoOfChildern.Text.Equals("")))
            {
                Children = true;
            }

            if (FName && LName && PhoneNo)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to update your information?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {

                    MessageBox.Show(lb_FirstName.Text + " " + lb_LastName.Text + ", your information has been upated within the System "
                                    , "Client info Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Client info has not been updated in the system", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

            else if (!FName)
            {
                MessageBox.Show("The First name entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_FirstName.Focus();
                //lb_FirstName.Clear();
            }

            else if (!LName)
            {
                MessageBox.Show("The Last name entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_LastName.Focus();
                //lb_LastName.Clear();
            }

            else if (!PhoneNo)
            {
                if (string.IsNullOrEmpty(lb_PhoneNo.Text))
                {
                    MessageBox.Show("The Phone Number cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lb_PhoneNo.Focus();
                    //lb_PhoneNo.Clear();
                }

                else if (lb_PhoneNo.Text.Length != 10)
                {
                    MessageBox.Show("The Phone Number must be 10 digits long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lb_PhoneNo.Focus();
                    //lb_PhoneNo.Clear();
                }

                /*else if (!lb_PhoneNo.Text.All(char.IsDigit))
                {
                    MessageBox.Show("The phone number can only contain numeric digits. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxButtons.Error);
                }*/


                else
                {
                    MessageBox.Show("The Phone Number entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lb_PhoneNo.Focus();
                    //lb_PhoneNo.Clear();
                }

            }
        

        txt_FirstName.Focus();
        }
    }
}
