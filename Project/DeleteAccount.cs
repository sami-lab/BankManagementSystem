using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    class DeleteAccount 
    {
        public void DeleteAcc(TextBox customerid)
        {

            string[] abc = File.ReadAllLines("Customer.txt");
            List<string> ss = File.ReadAllLines("Customer.txt").ToList();
            int count = 0;
            int i;
            for (i = 0; i < abc.Length; i += 15)
            {

                if (abc[i] == customerid.Text)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                File.WriteAllLines("Customer.txt", ss.ToArray());
                MessageBox.Show("Account is Delete","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }


            else
            {
                MessageBox.Show("Account is Not Exists","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
