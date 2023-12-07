namespace Gerador_de_senha
{
    partial class CadastramentoF
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
            dtv_Cadastro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtv_Cadastro).BeginInit();
            SuspendLayout();
            // 
            // dtv_Cadastro
            // 
            dtv_Cadastro.AllowUserToOrderColumns = true;
            dtv_Cadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_Cadastro.Dock = DockStyle.Fill;
            dtv_Cadastro.Location = new Point(0, 0);
            dtv_Cadastro.Name = "dtv_Cadastro";
            dtv_Cadastro.RowHeadersWidth = 51;
            dtv_Cadastro.RowTemplate.Height = 29;
            dtv_Cadastro.Size = new Size(458, 450);
            dtv_Cadastro.TabIndex = 0;
            // 
            // CadastramentoF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(dtv_Cadastro);
            Name = "CadastramentoF";
            Text = "CadastramentoF";
            Load += CadastramentoF_Load;
            ((System.ComponentModel.ISupportInitialize)dtv_Cadastro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtv_Cadastro;
    }
}