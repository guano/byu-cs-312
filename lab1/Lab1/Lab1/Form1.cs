using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class is_prime : Form
    {
        public is_prime()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void solve_Click(object sender, EventArgs e)
        {
            output.Text = input.Text;
        }

        private void is_prime_Load(object sender, EventArgs e)
        {

        }
    }
}
