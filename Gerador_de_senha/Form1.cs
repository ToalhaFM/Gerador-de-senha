namespace Gerador_de_senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            Gerador_Senha senha = new Gerador_Senha();
            txt_senha.Text = senha.GerandoSenha();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Login.Text = string.Empty;
            txt_senha.Text = string.Empty;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (txt_senha.PasswordChar == '*')
            {
                txt_senha.PasswordChar = default;
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.usuario = txt_Login.Text;
            cad.senha = txt_senha.Text;
            CadastramentoF cadastramentoF = new CadastramentoF();
            cadastramentoF.ShowDialog();
        }
    }
}