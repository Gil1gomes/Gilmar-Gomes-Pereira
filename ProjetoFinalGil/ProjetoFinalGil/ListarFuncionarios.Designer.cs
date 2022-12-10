namespace ProjetoFinalGil
{
    partial class ListarFuncionarios
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cadastrobutton1 = new System.Windows.Forms.Button();
            this.Atualizarbutton2 = new System.Windows.Forms.Button();
            this.Excluirbutton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOME_FUNC";
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
            this.columnHeader4.Text = "ADMISSAO";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CARGO";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DEPTO";
            // 
            // Cadastrobutton1
            // 
            this.Cadastrobutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrobutton1.Location = new System.Drawing.Point(27, 372);
            this.Cadastrobutton1.Name = "Cadastrobutton1";
            this.Cadastrobutton1.Size = new System.Drawing.Size(138, 35);
            this.Cadastrobutton1.TabIndex = 1;
            this.Cadastrobutton1.Text = "CADASTRAR";
            this.Cadastrobutton1.UseVisualStyleBackColor = true;
            this.Cadastrobutton1.Click += new System.EventHandler(this.Cadastrobutton1_Click_1);
            // 
            // Atualizarbutton2
            // 
            this.Atualizarbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizarbutton2.Location = new System.Drawing.Point(276, 372);
            this.Atualizarbutton2.Name = "Atualizarbutton2";
            this.Atualizarbutton2.Size = new System.Drawing.Size(196, 35);
            this.Atualizarbutton2.TabIndex = 2;
            this.Atualizarbutton2.Text = "ATUALIZAR DADOS";
            this.Atualizarbutton2.UseVisualStyleBackColor = true;
            this.Atualizarbutton2.Click += new System.EventHandler(this.Atualizarbutton2_Click_1);
            // 
            // Excluirbutton3
            // 
            this.Excluirbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluirbutton3.Location = new System.Drawing.Point(598, 372);
            this.Excluirbutton3.Name = "Excluirbutton3";
            this.Excluirbutton3.Size = new System.Drawing.Size(165, 35);
            this.Excluirbutton3.TabIndex = 3;
            this.Excluirbutton3.Text = "EXCLUIR";
            this.Excluirbutton3.UseVisualStyleBackColor = true;
            this.Excluirbutton3.Click += new System.EventHandler(this.Excluirbutton3_Click_1);
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluirbutton3);
            this.Controls.Add(this.Atualizarbutton2);
            this.Controls.Add(this.Cadastrobutton1);
            this.Controls.Add(this.listView1);
            this.Name = "ListarFuncionarios";
            this.Text = "ListarFuncionarios";
            this.Load += new System.EventHandler(this.ListarFuncionarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button Cadastrobutton1;
        private System.Windows.Forms.Button Atualizarbutton2;
        private System.Windows.Forms.Button Excluirbutton3;
    }
}