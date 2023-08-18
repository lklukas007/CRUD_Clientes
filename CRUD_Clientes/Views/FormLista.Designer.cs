namespace CRUD_Clientes.Views
{
    partial class FormLista
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar_AbrirForm = new System.Windows.Forms.Button();
            this.btnRealizaBusca = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.label_listaclientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Enabled = false;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(713, 329);
            this.dataGridViewClientes.TabIndex = 7;
            this.dataGridViewClientes.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(373, 386);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(158, 46);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar_AbrirForm
            // 
            this.btnAlterar_AbrirForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_AbrirForm.Location = new System.Drawing.Point(186, 386);
            this.btnAlterar_AbrirForm.Name = "btnAlterar_AbrirForm";
            this.btnAlterar_AbrirForm.Size = new System.Drawing.Size(158, 46);
            this.btnAlterar_AbrirForm.TabIndex = 9;
            this.btnAlterar_AbrirForm.Text = "Alterar";
            this.btnAlterar_AbrirForm.UseVisualStyleBackColor = true;
            this.btnAlterar_AbrirForm.Click += new System.EventHandler(this.btnAlterar_AbrirForm_Click);
            // 
            // btnRealizaBusca
            // 
            this.btnRealizaBusca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaBusca.Location = new System.Drawing.Point(616, 7);
            this.btnRealizaBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizaBusca.Name = "btnRealizaBusca";
            this.btnRealizaBusca.Size = new System.Drawing.Size(100, 27);
            this.btnRealizaBusca.TabIndex = 22;
            this.btnRealizaBusca.Text = "Buscar";
            this.btnRealizaBusca.UseVisualStyleBackColor = true;
            this.btnRealizaBusca.Click += new System.EventHandler(this.btnRealizaBusca_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(116, 7);
            this.txtBuscaNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscaNome.Multiline = true;
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(496, 27);
            this.txtBuscaNome.TabIndex = 21;
            // 
            // label_listaclientes
            // 
            this.label_listaclientes.AutoSize = true;
            this.label_listaclientes.Enabled = false;
            this.label_listaclientes.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaclientes.Location = new System.Drawing.Point(9, 13);
            this.label_listaclientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_listaclientes.Name = "label_listaclientes";
            this.label_listaclientes.Size = new System.Drawing.Size(108, 15);
            this.label_listaclientes.TabIndex = 8;
            this.label_listaclientes.Text = "Pesquisa Rápida:";
            this.label_listaclientes.Visible = false;
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 443);
            this.Controls.Add(this.btnRealizaBusca);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar_AbrirForm);
            this.Controls.Add(this.label_listaclientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLista";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar_AbrirForm;
        private System.Windows.Forms.Button btnRealizaBusca;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label label_listaclientes;
    }
}