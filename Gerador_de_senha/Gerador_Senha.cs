using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senha
{
    internal class Gerador_Senha
    {
        private string GerarSenha;

        public Gerador_Senha() { 
            this.GerarSenha = string.Empty;
        }

        public string GerandoSenha()
        {
            string s;
            string[] c = { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "m", "M", "N", "n", "O", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int index;
            int cont;
            int val;
            Random ran = new Random();
            
            cont = ran.Next(8, 15);
            for(int i = 0; i < cont; i++)
            {
                index = ran.Next(0, 59);
                val = ran.Next(index, c.Length);
                s = c[val];
                this.GerarSenha += s;
            }
            return this.GerarSenha;
        }
    }
}
