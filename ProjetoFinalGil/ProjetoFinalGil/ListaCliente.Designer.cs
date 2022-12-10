namespace ProjetoFinalGil
{
    partial class ListaCliente
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
            this.ClientesListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cadastrobutton1 = new System.Windows.Forms.Button();
            this.Atualizarbutton1 = new System.Windows.Forms.Button();
            this.excluirbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientesListView
            // 
            this.ClientesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ClientesListView.HideSelection = false;
            this.ClientesListView.Location = new System.Drawing.Point(42, 31);
            this.ClientesListView.Name = "ClientesListView";
            this.ClientesListView.Size = new System.Drawing.Size(730, 390);
            this.ClientesListView.TabIndex = 0;
            this.ClientesListView.UseCompatibleStateImageBehavior = false;
            this.ClientesListView.View = System.Windows.Forms.View.Details;
            this.ClientesListView.SelectedIndexChanged += new System.EventHandler(this.ClientesListView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NOME";
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
            this.columnHeader6.Text = "ENDEREÇO";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CPF";
            // 
            // cadastrobutton1
            // 
            this.cadastrobutton1.Location = new System.Drawing.Point(63, 367);
            this.cadastrobutton1.Name = "cadastrobutton1";
            this.cadastrobutton1.Size = new System.Drawing.Size(103, 23);
            this.cadastrobutton1.TabIndex = 1;
            this.cadastrobutton1.Text = "Cadastrar";
            this.cadastrobutton1.UseVisualStyleBackColor = true;
            this.cadastrobutton1.Click += new System.EventHandler(this.cadastrobutton1_Click);
            // 
            // Atualizarbutton1
            // 
            this.Atualizarbutton1.Location = new System.Drawing.Point(214, 367);
            this.Atualizarbutton1.Name = "Atualizarbutton1";
            this.Atualizarbutton1.Size = new System.Drawing.Size(103, 23);
            this.Atualizarbutton1.TabIndex = 2;
            this.Atualizarbutton1.Text = "AtualizarCliente";
            this.Atualizarbutton1.UseVisualStyleBackColor = true;
            this.Atualizarbutton1.Click += new System.EventHandler(this.Atualizarbutton1_Click);
            // 
            // excluirbutton1
            // 
            this.excluirbutton1.Location = new System.Drawing.Point(348, 367);
            this.excluirbutton1.Name = "excluirbutton1";
            this.excluirbutton1.Size = new System.Drawing.Size(105, 23);
            this.excluirbutton1.TabIndex = 3;
            this.excluirbutton1.Text = "Excluir";
            this.excluirbutton1.UseVisualStyleBackColor = true;
            this.excluirbutton1.Click += new System.EventHandler(this.excluirbutton1_Click);
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excluirbutton1);
            this.Controls.Add(this.Atualizarbutton1);
            this.Controls.Add(this.cadastrobutton1);
            this.Controls.Add(this.ClientesListView);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            this.Load += new System.EventHandler(this.ListaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ClientesListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button cadastrobutton1;
        private System.Windows.Forms.Button Atualizarbutton1;
        private System.Windows.Forms.Button excluirbutton1;
    }
}