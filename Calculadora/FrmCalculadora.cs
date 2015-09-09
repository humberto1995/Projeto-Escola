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
    public partial class FrmCalculadora : Form
    {
        double Resto;
        string StrValorMemoria;       
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            StrValorMemoria = "";
            Resto = 0;
            lblSinal.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "0";
                StrValorMemoria = "0";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "0";
                StrValorMemoria = StrValorMemoria + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "1";
                StrValorMemoria = "1";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "1";
                StrValorMemoria = StrValorMemoria + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "2";
                StrValorMemoria = "2";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "2";
                StrValorMemoria = StrValorMemoria + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "3";
                StrValorMemoria = "3";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "3";
                StrValorMemoria = StrValorMemoria + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "4";
                StrValorMemoria = "4";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "4";
                StrValorMemoria = StrValorMemoria + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "5";
                StrValorMemoria = "5";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "5";
                StrValorMemoria = StrValorMemoria + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "6";
                StrValorMemoria = "6";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "6";
                StrValorMemoria = StrValorMemoria + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "7";
                StrValorMemoria = "7";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "7";
                StrValorMemoria = StrValorMemoria + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "8";
                StrValorMemoria = "8";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "8";
                StrValorMemoria = StrValorMemoria + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "9";
                StrValorMemoria = "9";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + "9";
                StrValorMemoria = StrValorMemoria + "9";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
                txtVisor.Text = "0,";
                StrValorMemoria = "0,";
            }
            else
            {
                txtVisor.Text = txtVisor.Text + ",";
                StrValorMemoria = StrValorMemoria + ",";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnIgual.Enabled = true;
            btnSomar.Enabled = true;
            btnSubtrair.Enabled = true;
            btnMultiplicar.Enabled = true;
            btnDividir.Enabled = true;
            btn0.Enabled = true;
            btnPonto.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            txtVisor.Text = "";
            StrValorMemoria = "";
            Resto = 0;
            lblSinal.Text = "";
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub Humberto1995, Entre em contato", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Resto = Convert.ToDouble(StrValorMemoria);
            StrValorMemoria = "";
            txtVisor.Text = "";
            lblSinal.Text = "+";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Resto = Convert.ToDouble(StrValorMemoria);
            StrValorMemoria = "";
            txtVisor.Text = "";
            lblSinal.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Resto = Convert.ToDouble(StrValorMemoria);
            StrValorMemoria = "";
            txtVisor.Text = "";
            lblSinal.Text = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Resto = Convert.ToDouble(StrValorMemoria);
            StrValorMemoria = "";
            txtVisor.Text = "";
            lblSinal.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (lblSinal.Text == "+")
            {
                btnIgual.Enabled = false;
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                btn0.Enabled = false;
                btnPonto.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                Resto = Resto + Convert.ToDouble(StrValorMemoria);
                StrValorMemoria = "";
                txtVisor.Text = "Enter";
                lblSinal.Text = "=" + Convert.ToString(Resto);
                btnApagar.Focus();
            }
            else if (lblSinal.Text == "-")
            {
                btnIgual.Enabled = false;
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                btn0.Enabled = false;
                btnPonto.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                Resto = Resto - Convert.ToDouble(StrValorMemoria);
                StrValorMemoria = "";
                txtVisor.Text = "Enter";
                lblSinal.Text = "=" + Convert.ToString(Resto);
                btnApagar.Focus();
            }
            else if (lblSinal.Text == "*")
            {
                btnIgual.Enabled = false;
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                btn0.Enabled = false;
                btnPonto.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                Resto = Resto * Convert.ToDouble(StrValorMemoria);
                StrValorMemoria = "";
                txtVisor.Text = "Enter";
                lblSinal.Text = "=" + Convert.ToString(Resto);
                btnApagar.Focus();
            }
            else if (lblSinal.Text == "/")
            {
                btnIgual.Enabled = false;
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                btn0.Enabled = false;
                btnPonto.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                Resto = Resto / Convert.ToDouble(StrValorMemoria);
                StrValorMemoria = "";
                txtVisor.Text = "Enter";
                lblSinal.Text = "=" + Convert.ToString(Resto);
                btnApagar.Focus();
            }
        }
    }
}
