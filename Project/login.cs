using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class login
    {
        public string read;
        public void Log(TextBox id, TextBox pincode, ComboBox cbox)
        {
            if (cbox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please Select Your identity");
            }
                if (cbox.SelectedItem.ToString() == "Admin")
            {
                string[] read = File.ReadAllLines("admin login id and pass.txt");


                for (int i = 0; i < read.Length; i += 1)
                {
                    if (read[i] == id.Text + pincode.Text)
                    {

                        Form2 form2 = new Form2();
                        form2.Show();


                    }

                    else
                    {
                        MessageBox.Show("Your Account Is Not Exit", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form1 f1 = new Form1();
                        f1.Show();
                    }



                }


            }
            if (cbox.SelectedItem.ToString() == "Member")
            {

                string[] read = File.ReadAllLines(@"Customer.txt");
                int count = 0;
                int i;


                for (i = 0; i < read.Length; i += 15)
                {
                    if (read[i] == id.Text && read[i + 1] == pincode.Text)
                    {
                        count++;
                        break;
                    }
                }
                if (count > 0)
                {
                    Form8 form8 = new Form8(id);
                    form8.Show();


                }

                else
                {
                    MessageBox.Show("Your Account Is Not Exit", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1 f1 = new Form1();
                    f1.Show();
                }

            }

        }
    }



}
