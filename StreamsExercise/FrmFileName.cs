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
    public partial class FrmFileName : Form
    {
        FrmRegistration registration;

        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();

            registration = new FrmRegistration();

            CreateButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            CreateButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string filename = fileNameTxt.Text;
            SetFileName = filename + ".txt";
            this.Close();

            registration.ShowDialog();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
