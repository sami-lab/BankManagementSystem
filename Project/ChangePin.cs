using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class ChangePin
    {

        public void changePinCode(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < abc.Length; i+=15)
            {

                if (abc[i] == accountid.Text)
                {
                    double newpincode = Convert.ToDouble(newpin.Text);
                    double prepincode = Convert.ToDouble(abc[i + 1]);
                    newpin.Text = newpincode.ToString();
                    abc[i + 1] = newpincode.ToString();
                    MessageBox.Show("Your Pin Code Change Plz Logout and Check","Pin Changed",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }

            }
            
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < abc.Length; i++)
            {

                wr.WriteLine(abc[i], true);

            }
            wr.Close();
         }
    }
}

