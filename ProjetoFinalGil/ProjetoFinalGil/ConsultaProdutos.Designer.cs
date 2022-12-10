namespace ProjetoFinalGil
{
    partial class frmConsultarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEstoque));
            this.radTomate = new System.Windows.Forms.RadioButton();
            this.radCebola = new System.Windows.Forms.RadioButton();
            this.picDebora = new System.Windows.Forms.PictureBox();
            this.picCereja = new System.Windows.Forms.PictureBox();
            this.radDebora = new System.Windows.Forms.RadioButton();
            this.radCereja = new System.Windows.Forms.RadioButton();
            this.picRoxa = new System.Windows.Forms.PictureBox();
            this.picBranca = new System.Windows.Forms.PictureBox();
            this.radRoxa = new System.Windows.Forms.RadioButton();
            this.radBranca = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDebora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCereja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBranca)).BeginInit();
            this.SuspendLayout();
            // 
            // radTomate
            // 
            this.radTomate.AutoSize = true;
            this.radTomate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTomate.Location = new System.Drawing.Point(155, 36);
            this.radTomate.Name = "radTomate";
            this.radTomate.Size = new System.Drawing.Size(92, 28);
            this.radTomate.TabIndex = 99;
            this.radTomate.TabStop = true;
            this.radTomate.Text = "Tomate";
            this.radTomate.UseVisualStyleBackColor = true;
            this.radTomate.CheckedChanged += new System.EventHandler(this.radTomate_CheckedChanged);
            // 
            // radCebola
            // 
            this.radCebola.AutoSize = true;
            this.radCebola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCebola.Location = new System.Drawing.Point(672, 43);
            this.radCebola.Name = "radCebola";
            this.radCebola.Size = new System.Drawing.Size(88, 28);
            this.radCebola.TabIndex = 98;
            this.radCebola.TabStop = true;
            this.radCebola.Text = "Cebola";
            this.radCebola.UseVisualStyleBackColor = true;
            this.radCebola.CheckedChanged += new System.EventHandler(this.radCebola_CheckedChanged);
            // 
            // picDebora
            // 
            this.picDebora.Image = ((System.Drawing.Image)(resources.GetObject("picDebora.Image")));
            this.picDebora.Location = new System.Drawing.Point(44, 115);
            this.picDebora.Name = "picDebora";
            this.picDebora.Size = new System.Drawing.Size(238, 152);
            this.picDebora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDebora.TabIndex = 2;
            this.picDebora.TabStop = false;
            this.picDebora.Visible = false;
            // 
            // picCereja
            // 
            this.picCereja.Image = ((System.Drawing.Image)(resources.GetObject("picCereja.Image")));
            this.picCereja.Location = new System.Drawing.Point(44, 343);
            this.picCereja.Name = "picCereja";
            this.picCereja.Size = new System.Drawing.Size(238, 178);
            this.picCereja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCereja.TabIndex = 3;
            this.picCereja.TabStop = false;
            this.picCereja.Visible = false;
            // 
            // radDebora
            // 
            this.radDebora.AutoSize = true;
            this.radDebora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDebora.Location = new System.Drawing.Point(327, 174);
            this.radDebora.Name = "radDebora";
            this.radDebora.Size = new System.Drawing.Size(90, 28);
            this.radDebora.TabIndex = 4;
            this.radDebora.TabStop = true;
            this.radDebora.Text = "Debora";
            this.radDebora.UseVisualStyleBackColor = true;
            this.radDebora.Visible = false;
            this.radDebora.CheckedChanged += new System.EventHandler(this.radDebora_CheckedChanged);
            // 
            // radCereja
            // 
            this.radCereja.AutoSize = true;
            this.radCereja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCereja.Location = new System.Drawing.Point(327, 416);
            this.radCereja.Name = "radCereja";
            this.radCereja.Size = new System.Drawing.Size(83, 28);
            this.radCereja.TabIndex = 5;
            this.radCereja.TabStop = true;
            this.radCereja.Text = "Cereja";
            this.radCereja.UseVisualStyleBackColor = true;
            this.radCereja.Visible = false;
            this.radCereja.CheckedChanged += new System.EventHandler(this.radCereja_CheckedChanged);
            // 
            // picRoxa
            // 
            this.picRoxa.Image = ((System.Drawing.Image)(resources.GetObject("picRoxa.Image")));
            this.picRoxa.Location = new System.Drawing.Point(672, 115);
            this.picRoxa.Name = "picRoxa";
            this.picRoxa.Size = new System.Drawing.Size(225, 152);
            this.picRoxa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoxa.TabIndex = 6;
            this.picRoxa.TabStop = false;
            this.picRoxa.Visible = false;
            // 
            // picBranca
            // 
            this.picBranca.Image = ((System.Drawing.Image)(resources.GetObject("picBranca.Image")));
            this.picBranca.Location = new System.Drawing.Point(672, 343);
            this.picBranca.Name = "picBranca";
            this.picBranca.Size = new System.Drawing.Size(225, 178);
            this.picBranca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBranca.TabIndex = 7;
            this.picBranca.TabStop = false;
            this.picBranca.Visible = false;
            // 
            // radRoxa
            // 
            this.radRoxa.AutoSize = true;
            this.radRoxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRoxa.Location = new System.Drawing.Point(946, 174);
            this.radRoxa.Name = "radRoxa";
            this.radRoxa.Size = new System.Drawing.Size(72, 28);
            this.radRoxa.TabIndex = 8;
            this.radRoxa.TabStop = true;
            this.radRoxa.Text = "Roxa";
            this.radRoxa.UseVisualStyleBackColor = true;
            this.radRoxa.Visible = false;
            this.radRoxa.CheckedChanged += new System.EventHandler(this.radRoxa_CheckedChanged);
            // 
            // radBranca
            // 
            this.radBranca.AutoSize = true;
            this.radBranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBranca.Location = new System.Drawing.Point(946, 416);
            this.radBranca.Name = "radBranca";
            this.radBranca.Size = new System.Drawing.Size(87, 28);
            this.radBranca.TabIndex = 9;
            this.radBranca.TabStop = true;
            this.radBranca.Text = "Branca";
            this.radBranca.UseVisualStyleBackColor = true;
            this.radBranca.Visible = false;
            this.radBranca.CheckedChanged += new System.EventHandler(this.radBranca_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(718, 572);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(946, 572);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(38, 552);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(86, 31);
            this.lblMensagem.TabIndex = 100;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.Visible = false;
            // 
            // frmConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1141, 617);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.radBranca);
            this.Controls.Add(this.radRoxa);
            this.Controls.Add(this.picBranca);
            this.Controls.Add(this.picRoxa);
            this.Controls.Add(this.radCereja);
            this.Controls.Add(this.radDebora);
            this.Controls.Add(this.picCereja);
            this.Controls.Add(this.picDebora);
            this.Controls.Add(this.radCebola);
            this.Controls.Add(this.radTomate);
            this.Name = "frmConsultarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estoque";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDebora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCereja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBranca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTomate;
        private System.Windows.Forms.RadioButton radCebola;
        private System.Windows.Forms.PictureBox picDebora;
        private System.Windows.Forms.PictureBox picCereja;
        private System.Windows.Forms.RadioButton radDebora;
        private System.Windows.Forms.RadioButton radCereja;
        private System.Windows.Forms.PictureBox picRoxa;
        private System.Windows.Forms.PictureBox picBranca;
        private System.Windows.Forms.RadioButton radRoxa;
        private System.Windows.Forms.RadioButton radBranca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMensagem;
    }
}