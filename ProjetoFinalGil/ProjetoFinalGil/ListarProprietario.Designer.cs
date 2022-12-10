namespace ProjetoFinalGil
{
    partial class ListarProprietario
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
            this.ProprietariolistView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cadastrarbutton1 = new System.Windows.Forms.Button();
            this.Atualizarbutton1 = new System.Windows.Forms.Button();
            this.Excluirbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProprietariolistView1
            // 
            this.ProprietariolistView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ProprietariolistView1.HideSelection = false;
            this.ProprietariolistView1.Location = new System.Drawing.Point(12, 12);
            this.ProprietariolistView1.Name = "ProprietariolistView1";
            this.ProprietariolistView1.Size = new System.Drawing.Size(776, 417);
            this.ProprietariolistView1.TabIndex = 0;
            this.ProprietariolistView1.UseCompatibleStateImageBehavior = false;
            this.ProprietariolistView1.View = System.Windows.Forms.View.Details;
            this.ProprietariolistView1.Click += new System.EventHandler(this.ProprietariolistView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOME";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SEXO";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EMAIL";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TELEFONE";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ENDERECO";
            // 
            // Cadastrarbutton1
            // 
            this.Cadastrarbutton1.Location = new System.Drawing.Point(34, 360);
            this.Cadastrarbutton1.Name = "Cadastrarbutton1";
            this.Cadastrarbutton1.Size = new System.Drawing.Size(86, 32);
            this.Cadastrarbutton1.TabIndex = 1;
            this.Cadastrarbutton1.Text = "CADASTRAR";
            this.Cadastrarbutton1.UseVisualStyleBackColor = true;
            this.Cadastrarbutton1.Click += new System.EventHandler(this.Cadastrarbutton1_Click);
            // 
            // Atualizarbutton1
            // 
            this.Atualizarbutton1.Location = new System.Drawing.Point(221, 360);
            this.Atualizarbutton1.Name = "Atualizarbutton1";
            this.Atualizarbutton1.Size = new System.Drawing.Size(149, 32);
            this.Atualizarbutton1.TabIndex = 2;
            this.Atualizarbutton1.Text = "ATUALIZAR DADOS";
            this.Atualizarbutton1.UseVisualStyleBackColor = true;
            // 
            // Excluirbutton1
            // 
            this.Excluirbutton1.Location = new System.Drawing.Point(472, 360);
            this.Excluirbutton1.Name = "Excluirbutton1";
            this.Excluirbutton1.Size = new System.Drawing.Size(86, 32);
            this.Excluirbutton1.TabIndex = 3;
            this.Excluirbutton1.Text = "EXCLUIR";
            this.Excluirbutton1.UseVisualStyleBackColor = true;
            // 
            // ListarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluirbutton1);
            this.Controls.Add(this.Atualizarbutton1);
            this.Controls.Add(this.Cadastrarbutton1);
            this.Controls.Add(this.ProprietariolistView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListarProprietario";
            this.Text = "ListarProprietario";
            this.Load += new System.EventHandler(this.ListarProprietario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProprietariolistView1;
        private System.Windows.Forms.Button Cadastrarbutton1;
        private System.Windows.Forms.Button Atualizarbutton1;
        private System.Windows.Forms.Button Excluirbutton1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}