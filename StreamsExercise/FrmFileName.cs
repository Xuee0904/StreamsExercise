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
        public FrmFileName()
        {
            InitializeComponent();

            this.Show();

            CreateButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            CreateButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
