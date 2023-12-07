using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senha
{
    internal class Cadastro
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public static List<Cadastro> Listra(string nome, string senha)
        {
            var lista = new List<Cadastro>();
            var e1 = new Cadastro();

            e1.usuario = nome;
            e1.senha = senha;
            lista.Add(e1);
            return lista;
        }
    }
}
