namespace Teste1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbModelo = new System.Windows.Forms.Label();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.rCarro = new System.Windows.Forms.RadioButton();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.rMoto = new System.Windows.Forms.RadioButton();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbKm = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnMostraTotal = new System.Windows.Forms.Button();
            this.CbKit = new System.Windows.Forms.CheckBox();
            this.CbReboque = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(69, 87);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 0;
            this.lbModelo.Text = "Modelo";
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Location = new System.Drawing.Point(98, 297);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(75, 23);
            this.btnAdiciona.TabIndex = 1;
            this.btnAdiciona.Text = "Adiciona";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // rCarro
            // 
            this.rCarro.AutoSize = true;
            this.rCarro.Location = new System.Drawing.Point(72, 31);
            this.rCarro.Name = "rCarro";
            this.rCarro.Size = new System.Drawing.Size(50, 17);
            this.rCarro.TabIndex = 2;
            this.rCarro.Text = "Carro";
            this.rCarro.UseVisualStyleBackColor = true;
            this.rCarro.CheckedChanged += new System.EventHandler(this.rCarro_CheckedChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(133, 80);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // rMoto
            // 
            this.rMoto.AutoSize = true;
            this.rMoto.Location = new System.Drawing.Point(207, 31);
            this.rMoto.Name = "rMoto";
            this.rMoto.Size = new System.Drawing.Size(49, 17);
            this.rMoto.TabIndex = 4;
            this.rMoto.Text = "Moto";
            this.rMoto.UseVisualStyleBackColor = true;
            this.rMoto.CheckedChanged += new System.EventHandler(this.rMoto_CheckedChanged);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(69, 113);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbPlaca.TabIndex = 5;
            this.lbPlaca.Text = "Placa";
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.Location = new System.Drawing.Point(69, 139);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(22, 13);
            this.lbKm.TabIndex = 6;
            this.lbKm.Text = "Km";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(69, 165);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 7;
            this.lbValor.Text = "Valor";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(133, 106);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 8;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(133, 132);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(133, 158);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // btnMostraTotal
            // 
            this.btnMostraTotal.Location = new System.Drawing.Point(231, 297);
            this.btnMostraTotal.Name = "btnMostraTotal";
            this.btnMostraTotal.Size = new System.Drawing.Size(75, 23);
            this.btnMostraTotal.TabIndex = 11;
            this.btnMostraTotal.Text = "Mostrar total";
            this.btnMostraTotal.UseVisualStyleBackColor = true;
            this.btnMostraTotal.Click += new System.EventHandler(this.btnMostraTotal_Click);
            // 
            // CbKit
            // 
            this.CbKit.AutoSize = true;
            this.CbKit.Location = new System.Drawing.Point(72, 224);
            this.CbKit.Name = "CbKit";
            this.CbKit.Size = new System.Drawing.Size(226, 17);
            this.CbKit.TabIndex = 12;
            this.CbKit.Text = "Kit Capa de Chuva e Capacete R$ 145,00";
            this.CbKit.UseVisualStyleBackColor = true;
            // 
            // CbReboque
            // 
            this.CbReboque.AutoSize = true;
            this.CbReboque.Location = new System.Drawing.Point(72, 201);
            this.CbReboque.Name = "CbReboque";
            this.CbReboque.Size = new System.Drawing.Size(123, 17);
            this.CbReboque.TabIndex = 14;
            this.CbReboque.Text = "Reboque R$ 150,00";
            this.CbReboque.UseVisualStyleBackColor = true;
            this.CbReboque.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 386);
            this.Controls.Add(this.CbReboque);
            this.Controls.Add(this.CbKit);
            this.Controls.Add(this.btnMostraTotal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbKm);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.rMoto);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.rCarro);
            this.Controls.Add(this.btnAdiciona);
            this.Controls.Add(this.lbModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.RadioButton rCarro;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.RadioButton rMoto;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnMostraTotal;
        private System.Windows.Forms.CheckBox CbKit;
        private System.Windows.Forms.CheckBox CbReboque;
    }
}

