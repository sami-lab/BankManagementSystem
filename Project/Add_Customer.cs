using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Add_Customer 
    {
        public  void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            int count = 0;
            int i;
            for (i = 0; i < abc.Length; i++)
            {
                if (abc[i] == customerid.Text)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                MessageBox.Show("Your Account No is Already Exists \n Plz Change Your Account No", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StreamWriter sw = new StreamWriter("Customer.txt", true);
                MessageBox.Show("Registration Confirmed");
                sw.WriteLine(customerid.Text);
                sw.WriteLine(pincode.Text);
                sw.WriteLine(name.Text);
                sw.WriteLine(faname.Text);
                sw.WriteLine(dob.Text);
                sw.WriteLine(sex.Text);
                sw.WriteLine(cellnum.Text);
                sw.WriteLine(cntry.Text);
                sw.WriteLine(cit.Text);
                sw.WriteLine(adress.Text);
                sw.WriteLine(stret.Text);
                sw.WriteLine(em.Text);
                sw.WriteLine(zip.Text);
                sw.WriteLine(depo.Text);
                sw.WriteLine(dtp.Text);
                sw.Close();
            }
        }
    }
}

            
            


        
    
