using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
