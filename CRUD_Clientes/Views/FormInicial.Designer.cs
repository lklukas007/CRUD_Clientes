namespace CRUD_Clientes
{
    partial class FormInicial
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
            this.btnCadastro_AbrirForm = new System.Windows.Forms.Button();
            this.btnBuscar_AbrirForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro_AbrirForm
            // 
            this.btnCadastro_AbrirForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_AbrirForm.Location = new System.Drawing.Point(43, 28);
            this.btnCadastro_AbrirForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastro_AbrirForm.Name = "btnCadastro_AbrirForm";
            this.btnCadastro_AbrirForm.Size = new System.Drawing.Size(211, 57);
            this.btnCadastro_AbrirForm.TabIndex = 1;
            this.btnCadastro_AbrirForm.Text = "Cadastrar";
            this.btnCadastro_AbrirForm.UseVisualStyleBackColor = true;
            this.btnCadastro_AbrirForm.Click += new System.EventHandler(this.btnCadastro_AbrirForm_Click);
            // 
            // btnBuscar_AbrirForm
            // 
            this.btnBuscar_AbrirForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar_AbrirForm.Location = new System.Drawing.Point(43, 114);
            this.btnBuscar_AbrirForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_AbrirForm.Name = "btnBuscar_AbrirForm";
            this.btnBuscar_AbrirForm.Size = new System.Drawing.Size(211, 57);
            this.btnBuscar_AbrirForm.TabIndex = 7;
            this.btnBuscar_AbrirForm.Text = "Buscar";
            this.btnBuscar_AbrirForm.UseVisualStyleBackColor = true;
            this.btnBuscar_AbrirForm.Click += new System.EventHandler(this.btnBuscar_AbrirForm_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 213);
            this.Controls.Add(this.btnBuscar_AbrirForm);
            this.Controls.Add(this.btnCadastro_AbrirForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicial";
            this.Text = "Tela inicial";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastro_AbrirForm;
        private System.Windows.Forms.Button btnBuscar_AbrirForm;
    }
}

