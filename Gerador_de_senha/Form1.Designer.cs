namespace Gerador_de_senha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Gerar = new Button();
            txt_senha = new TextBox();
            btn_salvar = new Button();
            txt_Login = new TextBox();
            lbl_cadastro = new Label();
            btn_limpar = new Button();
            btn_ver = new Button();
            SuspendLayout();
            // 
            // btn_Gerar
            // 
            btn_Gerar.Location = new Point(203, 194);
            btn_Gerar.Name = "btn_Gerar";
            btn_Gerar.Size = new Size(129, 29);
            btn_Gerar.TabIndex = 0;
            btn_Gerar.Text = "Gerar Senha";
            btn_Gerar.UseVisualStyleBackColor = true;
            btn_Gerar.Click += btn_Gerar_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(79, 132);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(253, 27);
            txt_senha.TabIndex = 1;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(79, 194);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(104, 29);
            btn_salvar.TabIndex = 2;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_Login
            // 
            txt_Login.Location = new Point(79, 73);
            txt_Login.Name = "txt_Login";
            txt_Login.Size = new Size(253, 27);
            txt_Login.TabIndex = 3;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cadastro.Location = new Point(102, -6);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(212, 62);
            lbl_cadastro.TabIndex = 4;
            lbl_cadastro.Text = "Cadastro";
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(79, 253);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(253, 29);
            btn_limpar.TabIndex = 5;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_ver
            // 
            btn_ver.Location = new Point(338, 131);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(48, 29);
            btn_ver.TabIndex = 6;
            btn_ver.Text = "Ver";
            btn_ver.UseVisualStyleBackColor = true;
            btn_ver.Click += btn_ver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 307);
            Controls.Add(btn_ver);
            Controls.Add(btn_limpar);
            Controls.Add(lbl_cadastro);
            Controls.Add(txt_Login);
            Controls.Add(btn_salvar);
            Controls.Add(txt_senha);
            Controls.Add(btn_Gerar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Gerar;
        private TextBox txt_senha;
        private Button btn_salvar;
        private TextBox txt_Login;
        private Label lbl_cadastro;
        private Button btn_limpar;
        private Button btn_ver;
    }
}