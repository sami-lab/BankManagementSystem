using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Depositt 

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
        public void deposit(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            string[] xyz = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < xyz.Length; i += 15)
            {
                if (xyz[i] == customerid.Text)
                {
                    double add = Convert.ToDouble(addamount.Text);
                    double a = add + Convert.ToDouble(xyz[i + 13]);
                    prebal.Text = xyz[i + 13].ToString();
                    newbal.Text = a.ToString();
                    xyz[i + 13] = a.ToString();
                    MessageBox.Show("Your Deposit Process is Successfull", "Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
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
