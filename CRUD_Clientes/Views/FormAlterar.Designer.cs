namespace CRUD_Clientes.Views
{
    partial class FormAlterar
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
            this.txtDatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.btnRealizaAlteracao = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatanascimento.Location = new System.Drawing.Point(34, 147);
            this.txtDatanascimento.Mask = "00/00/0000";
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(375, 27);
            this.txtDatanascimento.TabIndex = 13;
            this.txtDatanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Genero.Location = new System.Drawing.Point(426, 148);
            this.comboBox_Genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(345, 28);
            this.comboBox_Genero.TabIndex = 15;
            // 
            // btnRealizaAlteracao
            // 
            this.btnRealizaAlteracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaAlteracao.Location = new System.Drawing.Point(300, 363);
            this.btnRealizaAlteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizaAlteracao.Name = "btnRealizaAlteracao";
            this.btnRealizaAlteracao.Size = new System.Drawing.Size(215, 59);
            this.btnRealizaAlteracao.TabIndex = 20;
            this.btnRealizaAlteracao.Text = "Alterar";
            this.btnRealizaAlteracao.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(34, 246);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(737, 34);
            this.txtEndereco.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(34, 317);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(151, 34);
            this.txtNumero.TabIndex = 19;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(426, 52);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(345, 34);
            this.txtSobrenome.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(34, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(375, 34);
            this.txtNome.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // FormAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.comboBox_Genero);
            this.Controls.Add(this.btnRealizaAlteracao);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterar";
            this.Text = "Alteração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDatanascimento;
        private System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.Button btnRealizaAlteracao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}