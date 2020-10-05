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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        login li = new login();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Member");

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            this.Hide();
            li.Log(textBox1, textBox2,comboBox1);
            textBox1.Clear();
            textBox2.Clear();
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
