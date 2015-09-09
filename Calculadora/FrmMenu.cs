using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void médiasDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMedias>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmMedias>().First().Focus();
            }
            else
            {
                FrmMedias Medias = new FrmMedias();
                Medias.MdiParent = this;
                Medias.Show();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCalculadora>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCalculadora>().First().Focus();
            }
            else
            {
                FrmCalculadora Calculadora = new FrmCalculadora();
                Calculadora.MdiParent = this;
                Calculadora.Show();
            }
        }
    }
}
