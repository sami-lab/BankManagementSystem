using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class CheckDetailed 
    {
        public void Account_Detailed(TextBox accountid, TextBox cusname, TextBox faname, TextBox currentbal, TextBox contactnum)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            
            int i;
            for (i = 0; i < abc.Length; i += 15)
            {

                if (abc[i] == accountid.Text)
                {
                    cusname.Text = abc[i + 2].ToString();
                    faname.Text = abc[i + 3].ToString();
                    currentbal.Text = abc[i + 13].ToString();
                    contactnum.Text = abc[i + 6].ToString();
                }
            }
            
        }
    }
}




