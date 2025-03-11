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
    public partial class frm_AddSitter : Form
    {
        frm_Home parent;
        public frm_AddSitter()
        {
            InitializeComponent();
        }

        public frm_AddSitter(frm_Home parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }


        private void frm_AddSitter_Load(object sender, EventArgs e)
        {
            {
                //Set Max DOB
                dtpDOB.MaxDate = DateTime.Today.AddYears(-18);

                //get next SitterId

            }

        }

        private void bnEnterDetails_Click(object sender, EventArgs e)
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



                return;
            }

            if (txt_Eircode.Text.Equals(""))
            {
                MessageBox.Show("SEircode is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Eircode.Focus();
                return;
            }

            if (txt_Street.Text.Equals(""))
            {
                MessageBox.Show("Street address is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Street.Focus();
                return;
            }

            if (txt_DOB.Text.Equals(""))
            {
                MessageBox.Show("Birth date is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DOB.Focus();
                return;
            }

            if (txt_Town.Text.Equals(""))
            {
                MessageBox.Show("Town is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Town.Focus();
                return;
            }

            if (txt_Rates.Text.Equals(""))
            {
                MessageBox.Show("Rates is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Rates.Focus();
                return;
            }

            if (txt_Bio.Text.Equals(""))
            {
                MessageBox.Show("Bio details is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Bio.Focus();
                return;
            }

            if (txt_Skills.Text.Equals(""))
            {
                MessageBox.Show("Skills set is requried", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Skills.Focus();
                return;
            }

            if (cbo_YesNo.SelectedIndex == -1)
            {
                MessageBox.Show("Yes or No must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_YesNo.Focus();
                return;
            }

            if (cbo_Experience.SelectedIndex == -1)
            {
                MessageBox.Show("Number must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Experience.Focus();
                return;
            }




            //display confirmation message


            //Reset UI
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Email.Clear();
            txt_PhoneNo.Clear();
            txt_Street.Clear();
            txt_DOB.Clear();
            txt_Town.Clear();
            txt_Eircode.Clear();
            txt_Rates.Clear();
            txt_Bio.Clear();
            txt_Skills.Clear();




            cbo_Experience.SelectedIndex = -1;
            cbo_YesNo.SelectedIndex = -1;
            txt_SitterID.Text = "10002";
            txt_FirstName.Focus();
            

        }

        private void bn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void GB_AddSitterDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lb_Rates_Click(object sender, EventArgs e)
        {

        }
    }
}
