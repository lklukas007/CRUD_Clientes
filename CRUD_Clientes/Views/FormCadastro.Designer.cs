namespace CRUD_Clientes.Views
{
    partial class FormCadastro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtDatanascimento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnRealizaCadastro = new System.Windows.Forms.Button();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.cRUD_CLIENTESDataSet = new CRUD_Clientes.CRUD_CLIENTESDataSet();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new CRUD_Clientes.CRUD_CLIENTESDataSetTableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_CLIENTESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 57);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(374, 33);
            this.txtNome.TabIndex = 6;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(427, 57);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(346, 33);
            this.txtSobrenome.TabIndex = 7;
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.Location = new System.Drawing.Point(35, 153);
            this.txtDatanascimento.Multiline = true;
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(346, 33);
            this.txtDatanascimento.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(35, 322);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 33);
            this.txtNumero.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(35, 251);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(738, 33);
            this.txtEndereco.TabIndex = 11;
            // 
            // btnRealizaCadastro
            // 
            this.btnRealizaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaCadastro.Location = new System.Drawing.Point(301, 368);
            this.btnRealizaCadastro.Name = "btnRealizaCadastro";
            this.btnRealizaCadastro.Size = new System.Drawing.Size(215, 59);
            this.btnRealizaCadastro.TabIndex = 12;
            this.btnRealizaCadastro.Text = "Cadastrar";
            this.btnRealizaCadastro.UseVisualStyleBackColor = true;
            this.btnRealizaCadastro.Click += new System.EventHandler(this.btnRealizaCadastro_Click);
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.generoBindingSource, "Descricao", true));
            this.comboBox_Genero.DataSource = this.generoBindingSource;
            this.comboBox_Genero.DisplayMember = "Descricao";
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Location = new System.Drawing.Point(427, 153);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(206, 24);
            this.comboBox_Genero.TabIndex = 13;
            this.comboBox_Genero.ValueMember = "Descricao";
            // 
            // cRUD_CLIENTESDataSet
            // 
            this.cRUD_CLIENTESDataSet.DataSetName = "CRUD_CLIENTESDataSet";
            this.cRUD_CLIENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.cRUD_CLIENTESDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Genero);
            this.Controls.Add(this.btnRealizaCadastro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_CLIENTESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtDatanascimento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnRealizaCadastro;
        private System.Windows.Forms.ComboBox comboBox_Genero;
        private CRUD_CLIENTESDataSet cRUD_CLIENTESDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private CRUD_CLIENTESDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
    }
}