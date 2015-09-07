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
    public partial class FrmMedias : Form
    {
        string StrSoma, StrMedia;
        public FrmMedias()
        {
            InitializeComponent();
        }

        private void FrmMedias_Load(object sender, EventArgs e)
        {

        }

        private void btnCalCularNotas_Click(object sender, EventArgs e)
        {
            if (txtPortugues.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Português","ERRO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtMatematica.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Matemática", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtHistoria.Text == "")
            {
                MessageBox.Show("Preencha a Nota de História", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtGeografia.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Geografia", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtBiologia.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Biologia", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtFisica.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Física", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtQuimica.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Química", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtFilosofia.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Filosofia", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtSociologia.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Sociologia", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtIngles.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Inglês", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtEducacaoFisica.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Educação Física", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (txtEducacaoArtistica.Text == "")
            {
                MessageBox.Show("Preencha a Nota de Eucação Artística", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                StrSoma = Convert.ToString(Convert.ToDecimal(txtPortugues.Text) +
                                           Convert.ToDecimal(txtMatematica.Text) +
                                           Convert.ToDecimal(txtHistoria.Text) +
                                           Convert.ToDecimal(txtGeografia.Text) +
                                           Convert.ToDecimal(txtBiologia.Text) +
                                           Convert.ToDecimal(txtFisica.Text) +
                                           Convert.ToDecimal(txtQuimica.Text) +
                                           Convert.ToDecimal(txtFilosofia.Text) +
                                           Convert.ToDecimal(txtSociologia.Text) +
                                           Convert.ToDecimal(txtIngles.Text) +
                                           Convert.ToDecimal(txtEducacaoFisica.Text) +
                                           Convert.ToDecimal(txtEducacaoFisica.Text));

                StrMedia = Convert.ToString((Convert.ToDecimal(txtPortugues.Text) +
                                             Convert.ToDecimal(txtMatematica.Text) +
                                             Convert.ToDecimal(txtHistoria.Text) +
                                             Convert.ToDecimal(txtGeografia.Text) +
                                             Convert.ToDecimal(txtBiologia.Text) +
                                             Convert.ToDecimal(txtFisica.Text) +
                                             Convert.ToDecimal(txtQuimica.Text) +
                                             Convert.ToDecimal(txtFilosofia.Text) +
                                             Convert.ToDecimal(txtSociologia.Text) +
                                             Convert.ToDecimal(txtIngles.Text) +
                                             Convert.ToDecimal(txtEducacaoFisica.Text) +
                                             Convert.ToDecimal(txtEducacaoFisica.Text)) / 12); ;

                txtSomaNotas.Text = StrSoma;
                txtMediaNotas.Text = StrMedia;

                MessageBox.Show("Notas calculadas com sucesso.", "Notas Calculadas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPortugues.Text = "";
                txtMatematica.Text = "";
                txtHistoria.Text = "";
                txtGeografia.Text = "";
                txtBiologia.Text = "";
                txtFisica.Text = "";
                txtQuimica.Text = "";
                txtFilosofia.Text = "";
                txtSociologia.Text = "";
                txtIngles.Text = "";
                txtEducacaoFisica.Text = "";
                txtEducacaoArtistica.Text = "";

                txtPortugues.Focus();
            }                   
        }
    }
}
