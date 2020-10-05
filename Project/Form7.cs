using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Withdrawll withd = new Withdrawll();
        private void button3_Click(object sender, EventArgs e)
        {
            withd.withdrawl(textBox1, textBox2, textBox3, textBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
