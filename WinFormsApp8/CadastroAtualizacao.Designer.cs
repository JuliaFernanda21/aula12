namespace WinFormsApp8
{
    partial class CadastroAtualizacao
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
            txtNome = new TextBox();
            txtPrec = new TextBox();
            lblNome = new Label();
            txtPreco = new Label();
            lblCadastro = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(132, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 34);
            txtNome.TabIndex = 0;
            // 
            // txtPrec
            // 
            txtPrec.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrec.Location = new Point(132, 214);
            txtPrec.Name = "txtPrec";
            txtPrec.Size = new Size(201, 34);
            txtPrec.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(39, 117);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txtPreco
            // 
            txtPreco.AutoSize = true;
            txtPreco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPreco.Location = new Point(39, 222);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(65, 28);
            txtPreco.TabIndex = 3;
            txtPreco.Text = "Preço:";
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCadastro.Location = new Point(329, 30);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(153, 46);
            lblCadastro.TabIndex = 4;
            lblCadastro.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(358, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 43);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroAtualizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblCadastro);
            Controls.Add(txtPreco);
            Controls.Add(lblNome);
            Controls.Add(txtPrec);
            Controls.Add(txtNome);
            Name = "CadastroAtualizacao";
            Text = "CadastroAtualizacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPrec;
        private Label lblNome;
        private Label txtPreco;
        private Label lblCadastro;
        private Button btnSalvar;
    }
}