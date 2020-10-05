using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Transfer_Balance 
    {
        public double a;
        public double bal;
        
        public void Transfer(TextBox accountid, TextBox transferAccountId, TextBox balance)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < abc.Length; i+=15)
            {
                if (abc[i] == accountid.Text)
                {
                    bal = Convert.ToDouble(balance.Text);
                    a = Convert.ToDouble(abc[i + 13]) - bal;
                    abc[i + 13] = a.ToString();
                   
                    break;

                }
            }
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < abc.Length; i++)
            {

                wr.WriteLine(abc[i], true);

            }
            wr.Close();

            for (int i = 0; i < abc.Length; i += 15)
            {
                if (abc[i] == transferAccountId.Text)
                {
                    bal = Convert.ToDouble(balance.Text);
                    a = Convert.ToDouble(abc[i + 13]) + bal;
                    abc[i + 13] = a.ToString();
                    MessageBox.Show("Your Balance is Transfer","Transfer",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    break;

                }
            }
            StreamWriter wr1 = new StreamWriter("Customer.txt");
            for (int i = 0; i < abc.Length; i++)
            {

                wr1.WriteLine(abc[i], true);

            }
            wr1.Close();

        }
        
    }
}
        

 
        
    

