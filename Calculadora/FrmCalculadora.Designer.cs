namespace Calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lblAnuncie = new System.Windows.Forms.Label();
            this.lblAqui = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.Black;
            this.txtVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.ForeColor = System.Drawing.Color.White;
            this.txtVisor.Location = new System.Drawing.Point(38, 19);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVisor.Size = new System.Drawing.Size(218, 38);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.Text = "0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.ForeColor = System.Drawing.Color.Black;
            this.btnOn.Location = new System.Drawing.Point(38, 67);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(106, 43);
            this.btnOn.TabIndex = 1;
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::Calculadora.Properties.Resources.Apagar;
            this.btnApagar.Location = new System.Drawing.Point(150, 67);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 43);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btn7
            // 
            this.btn7.Image = global::Calculadora.Properties.Resources.Sete;
            this.btn7.Location = new System.Drawing.Point(38, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 43);
            this.btn7.TabIndex = 4;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Image = global::Calculadora.Properties.Resources.Oito;
            this.btn8.Location = new System.Drawing.Point(94, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 43);
            this.btn8.TabIndex = 5;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Image = global::Calculadora.Properties.Resources.Nove;
            this.btn9.Location = new System.Drawing.Point(150, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 43);
            this.btn9.TabIndex = 6;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Image = global::Calculadora.Properties.Resources.Quatro;
            this.btn4.Location = new System.Drawing.Point(38, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 43);
            this.btn4.TabIndex = 7;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Image = global::Calculadora.Properties.Resources.Cinco;
            this.btn5.Location = new System.Drawing.Point(94, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 43);
            this.btn5.TabIndex = 8;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Image = global::Calculadora.Properties.Resources.Seis;
            this.btn6.Location = new System.Drawing.Point(150, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 43);
            this.btn6.TabIndex = 9;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn0
            // 
            this.btn0.Image = global::Calculadora.Properties.Resources.Zero;
            this.btn0.Location = new System.Drawing.Point(38, 263);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 43);
            this.btn0.TabIndex = 10;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
          //this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btnPonto
            // 
            this.btnPonto.Image = global::Calculadora.Properties.Resources.Ponto;
            this.btnPonto.Location = new System.Drawing.Point(150, 263);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(50, 43);
            this.btnPonto.TabIndex = 11;
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
          //this.btnPonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPonto_KeyPress);
            // 
            // btnDividir
            // 
            this.btnDividir.Image = global::Calculadora.Properties.Resources.Dividir;
            this.btnDividir.Location = new System.Drawing.Point(206, 67);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(50, 43);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Image = global::Calculadora.Properties.Resources.Multiplicar;
            this.btnMultiplicar.Location = new System.Drawing.Point(206, 116);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(50, 43);
            this.btnMultiplicar.TabIndex = 13;
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Image = global::Calculadora.Properties.Resources.Subitrair;
            this.btnSubtrair.Location = new System.Drawing.Point(206, 165);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(50, 43);
            this.btnSubtrair.TabIndex = 14;
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Image = global::Calculadora.Properties.Resources.Somar;
            this.btnSomar.Location = new System.Drawing.Point(206, 214);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(50, 43);
            this.btnSomar.TabIndex = 15;
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Image = global::Calculadora.Properties.Resources.Igual;
            this.btnIgual.Location = new System.Drawing.Point(206, 263);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(50, 43);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn1
            // 
            this.btn1.Image = global::Calculadora.Properties.Resources.Um;
            this.btn1.Location = new System.Drawing.Point(38, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 43);
            this.btn1.TabIndex = 17;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
          //this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn1_KeyPress);
            // 
            // btn2
            // 
            this.btn2.Image = global::Calculadora.Properties.Resources.Dois;
            this.btn2.Location = new System.Drawing.Point(94, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 43);
            this.btn2.TabIndex = 18;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Image = global::Calculadora.Properties.Resources.Três;
            this.btn3.Location = new System.Drawing.Point(150, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 43);
            this.btn3.TabIndex = 19;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lblAnuncie
            // 
            this.lblAnuncie.AutoSize = true;
            this.lblAnuncie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAnuncie.Enabled = false;
            this.lblAnuncie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnuncie.Location = new System.Drawing.Point(59, 72);
            this.lblAnuncie.Name = "lblAnuncie";
            this.lblAnuncie.Size = new System.Drawing.Size(68, 16);
            this.lblAnuncie.TabIndex = 20;
            this.lblAnuncie.Text = "ANUNCIE";
            // 
            // lblAqui
            // 
            this.lblAqui.AutoSize = true;
            this.lblAqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAqui.Enabled = false;
            this.lblAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAqui.Location = new System.Drawing.Point(74, 87);
            this.lblAqui.Name = "lblAqui";
            this.lblAqui.Size = new System.Drawing.Size(40, 16);
            this.lblAqui.TabIndex = 21;
            this.lblAqui.Text = "AQUI";
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.Color.Black;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.Color.White;
            this.lblSinal.Location = new System.Drawing.Point(41, 22);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(29, 31);
            this.lblSinal.TabIndex = 22;
            this.lblSinal.Text = "0";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 323);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblAqui);
            this.Controls.Add(this.lblAnuncie);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.txtVisor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lblAnuncie;
        private System.Windows.Forms.Label lblAqui;
        private System.Windows.Forms.Label lblSinal;
    }
}