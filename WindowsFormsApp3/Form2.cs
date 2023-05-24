using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using our system");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelconter4.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;


        }

        private void btnaddpt_Click(object sender, EventArgs e)
        {
            labelconter1.ForeColor=System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;

        }

        private void btnAddstaf_Click(object sender, EventArgs e)
        {
            labelconter2.ForeColor = System.Drawing.Color.Red;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;


        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            labelconter3.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;


        }
    }
}
