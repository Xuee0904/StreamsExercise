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

namespace StreamsExercise
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            RegisterButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            RegisterButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            string[] ListOfPrograms = new string[]
            {
                "Bachelor of Science in Accountancy (BSA)",
                "Bachelor of Science in Business Administration (BSBA)",
                "Bachelor of Science in Computer Science (BSCS)",
                "Bachelor of Science in Computer Engineering (BSCPE)",
                "Bachelor of Science in Hospitality Management (BSHM)",
                "Bachelor of Science in Information Technology (BSIT)",
                "Bachelor of Science in Nursing (BSN)",
                "Bachelor of Science in Psychology (BS Psychology)",
                "Bachelor of Science in Tourism Management (BSTM)"
        };
            for (int i = 0; i < 9; i++)
            {
                ProgramCombo.Items.Add(ListOfPrograms[i].ToString());
            }

            GenderCombo.Items.Add("Male");
            GenderCombo.Items.Add("Female");
            GenderCombo.Items.Add("Unspecified");

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string studentNumber = StudentNoText.Text;
            string lastName = LastNameText.Text;
            string firstName = FirstNameText.Text;
            string middlaName = MiddleNameText.Text;
            string contactNumber = ContactNoText.Text;
            string age = AgeText.Text;
            string birthday = BirthdayPicker.Value.ToString("yyyy-MM-dd");
            string program = ProgramCombo.Text;
            string Gender = GenderCombo.Text;

           /* if (MaleRB.Checked)
            {
                string Gender = "Male";
            }
            else if (FemaleRB.Checked)
            {
               string Gender = "Female";
            }
            else if (UnspecifiedRB.Checked)
            {
                string Gender = "Unspecified";
            }*/

            string relativePath = @"..\..\Madayag, Cedric Ashley J - LabStream";
            string docPath = Path.GetFullPath(relativePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNumber + ".txt")))
            {
                outputFile.WriteLine("Student Number: " + studentNumber);
                outputFile.WriteLine("Full Name: " + lastName + ", " + firstName + " " + middlaName);
                outputFile.WriteLine("Program: " + program);
                outputFile.WriteLine("Gender: " + Gender);
                outputFile.WriteLine("Age: " + age);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact Number: " + contactNumber);
            }

            MessageBox.Show("Successfully added as text file.");
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
