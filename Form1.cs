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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void faclbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void logbut_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtname.Text == "patrickcollado" && txtpass.Text == "12345")
                {

                    MessageBox.Show("Login Successfully!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
                else
                {
                    string message = "Invalid Username or Password";
                    string title = "WARNING!!!";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    {
                        if (result == DialogResult.Retry)
                        {
                            txtname.Clear();
                            txtpass.Clear();
                        }

                        else
                        {
                            this.Close();
                        }

                    }

                }

            }

        }

        private void signbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                e.Cancel = true;
                txtname.Focus();
                errorProviderName.SetError(txtname, "*Name should not be left blank*");

            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(txtname, "");
            }

        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                e.Cancel = true;
                txtname.Focus();
                errorProviderPass.SetError(txtpass, "*Please Enter Password*");

            }
            else
            {
                e.Cancel = false;
                errorProviderPass.SetError(txtpass, "");
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }
    }
}
