using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace god_abeg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("main");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void button3cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
