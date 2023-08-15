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
            this.label_listaclientes = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAlterar_AbrirForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_listaclientes
            // 
            this.label_listaclientes.AutoSize = true;
            this.label_listaclientes.Enabled = false;
            this.label_listaclientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaclientes.Location = new System.Drawing.Point(12, 9);
            this.label_listaclientes.Name = "label_listaclientes";
            this.label_listaclientes.Size = new System.Drawing.Size(152, 23);
            this.label_listaclientes.TabIndex = 8;
            this.label_listaclientes.Text = "Lista de clientes";
            this.label_listaclientes.Visible = false;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Enabled = false;
            this.dataGridViewClientes.Location = new System.Drawing.Point(16, 47);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(938, 399);
            this.dataGridViewClientes.TabIndex = 7;
            this.dataGridViewClientes.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(501, 475);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 57);
            this.button4.TabIndex = 10;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAlterar_AbrirForm
            // 
            this.btnAlterar_AbrirForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_AbrirForm.Location = new System.Drawing.Point(252, 475);
            this.btnAlterar_AbrirForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar_AbrirForm.Name = "btnAlterar_AbrirForm";
            this.btnAlterar_AbrirForm.Size = new System.Drawing.Size(211, 57);
            this.btnAlterar_AbrirForm.TabIndex = 9;
            this.btnAlterar_AbrirForm.Text = "Alterar";
            this.btnAlterar_AbrirForm.UseVisualStyleBackColor = true;
            this.btnAlterar_AbrirForm.Click += new System.EventHandler(this.btnAlterar_AbrirForm_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 545);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAlterar_AbrirForm);
            this.Controls.Add(this.label_listaclientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormLista";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_listaclientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAlterar_AbrirForm;
    }
}