using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Withdrawll
    {
        private double _sub;
        public double sub
        {
            get { return _sub; }
            set { _sub = value; }
        }

        private double _balance;

        public double balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void withdrawl(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {

            string[] xyz = File.ReadAllLines("Customer.txt");
            int count = 0;
            for (int i = 0; i < xyz.Length; i += 15)
            {
                double bal = Convert.ToDouble(xyz[i + 13]);
                if (xyz[i] == customerid.Text)
                {
                    count++;
                    double sub = Convert.ToDouble(addamount.Text);
                    if (bal >= sub)
                    {
                        double a = bal - sub;
                        prebal.Text = bal.ToString();
                        newbal.Text = a.ToString();
                        xyz[i + 13] = a.ToString();
                        MessageBox.Show("Your Withdrawl Process is Successfull", "Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance");
                    }
                        break;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Account Not Found","Not exist",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < xyz.Length; i++)
            {

                wr.WriteLine(xyz[i], true);

            }
            wr.Close();
        }
       
    }
}
