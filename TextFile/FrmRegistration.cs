using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] content =
                {
                lbl1.Text.ToString() + txtStudNo.Text,
                lbl2.Text.ToString() + txtLastName.Text,
                lbl6.Text.ToString() + txtFirstName.Text,
                lbl7.Text.ToString() + txtMI.Text,
                lbl3.Text.ToString() + txtAge.Text,
                lbl9.Text.ToString() + txtContact.Text,
                lbl5.Text.ToString() + cbProgram.Text,
                lbl8.Text.ToString() + cbGender.Text,
                lbl4.Text.ToString() + dtpBirthday.Value.ToString("yyyy-MM-dd")
            };

            MessageBox.Show("Successfully Registered");



            string fileName = txtStudNo.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in content)
                {
                    outputFile.WriteLine(line);
                    Console.WriteLine(line);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] Gender = new string[]
            {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(Gender[i].ToString());
            }
        }
    }
}