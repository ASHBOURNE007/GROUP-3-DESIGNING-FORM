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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
          
           pnl2.Hide();
           btnhide.BringToFront();
           
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            pnl2.Show();
            btnshow.BringToFront();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void btnCAS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void btnCTE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void btnIPPG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void btnCCJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void btnCITCS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9();
            frm9.Show();
        }
    }
}
