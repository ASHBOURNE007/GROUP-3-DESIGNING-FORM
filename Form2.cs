using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_3_DESIGNING_FORM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Account Registered Succesfully!", "REGISTER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtcreatePass.PasswordChar == '*')
            {
                btnshow.BringToFront();
                txtcreatePass.PasswordChar = '\0';
            }

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtcreatePass.PasswordChar == '\0')
            {
                btnhide.BringToFront();
                txtcreatePass.PasswordChar = '*';
            }

        }

        private void txtcreatefname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreatefname.Text))
            {
                e.Cancel = true;
                txtcreatefname.Focus();
                errorProviderFname.SetError(txtcreatefname, "*Firstname not detected, Please Enter Firstname*");

            }
            else
            {
                e.Cancel = false;
                errorProviderFname.SetError(txtcreatefname, "");
            }
        }

        private void txtcreatefname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtcreateLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreateLname.Text))
            {
                e.Cancel = true;
                txtcreateLname.Focus();
                errorProviderLname.SetError(txtcreateLname, "Lastname not detected, Please Enter Lastname*");

            }
            else
            {
                e.Cancel = false;
                errorProviderLname.SetError(txtcreateLname, "");
            }
        }

        private void txtcreateLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtcreateEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreateEmail.Text))
            {
                e.Cancel = true;
                txtcreateEmail.Focus();
                errorProviderEmail.SetError(txtcreateEmail, "Please Enter Valid Email Address*");

            }
            else
            {
                e.Cancel = false;
                errorProviderEmail.SetError(txtcreateEmail, "");
            }
        }

        private void txtcreateEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcreatePnum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreatePnum.Text))
            {
                e.Cancel = true;
                txtcreatePnum.Focus();
                errorProviderPhone.SetError(txtcreatePnum, "Please Enter Phone Number*");

            }
            else
            {
                e.Cancel = false;
                errorProviderPhone.SetError(txtcreateEmail, "");
            }
        }

        private void txtcreatePnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcreatePass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreatePass.Text))
            {
                e.Cancel = true;
                txtcreatePass.Focus();
                errorProviderPass.SetError(txtcreatePass, "Please Enter Phone Number*");

            }
            else
            {
                e.Cancel = false;
                errorProviderPass.SetError(txtcreatePass, "");
            }
        }

        private void txtcreatePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
