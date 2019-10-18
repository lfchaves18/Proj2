using System;
using System.Collections.Generic;
using System.Text;

namespace Proj2
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public uint Idade { get; set; } // uint escolhido, pois a idade deve ser sempre maior que zero

        public bool ValidarPalavras(string s) //  metodo para validar as palavras
        {
            if (string.IsNullOrEmpty(s)) return false;
            foreach (char c in s) // percorre letra por letra da string
            {
                if (!char.IsLetter(c)) return false; // negando o if, então se percorre todas as letra e for diferente da string, retorna falso
            }
            return true; // se não automaticamente retorna true
        }
    }
}