using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Update 
    {
        public void Customer_Record_Update(TextBox customerid, DataGridView dgv)
        {
           string[] abc = File.ReadAllLines("Customer.txt");
           int count = 0;
           int i;
           for ( i = 0; i < abc.Length; i += 15)
               
           {
               
               if (abc[i] == customerid.Text)
               {
                   count++; 
                   break;

               }
              
               
           }
           if (count > 0)
           {
               dgv.Rows.Add(abc[i], abc[i + 1], abc[i + 2], abc[i + 3], abc[i + 4], abc[i + 5], abc[i + 6], abc[i + 7], abc[i + 8], abc[i + 9], abc[i + 10], abc[i + 11], abc[i + 12], abc[i + 13], abc[i + 14]);
                   
           }
           else
           {
               MessageBox.Show("Your Account is Not Exist","Not Exists",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           
           
        }
    }
}
