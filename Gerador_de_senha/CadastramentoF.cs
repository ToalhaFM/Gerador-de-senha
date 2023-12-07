using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senha
{
    public partial class CadastramentoF : Form
    {
        public CadastramentoF()
        {
            InitializeComponent();
            dtv_Cadastro.DataSource = new DataSet();

        }

        private void CadastramentoF_Load(object sender, EventArgs e)
        {
            dtv_Cadastro.DataSource = new List<Cadastro>();
        }
    }
}
