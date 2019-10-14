using System;
using System.Collections.Generic;
using System.Text;

namespace Proj2
{
    class Turma
    {
        public uint Numero { get; set; }
        public List<Aluno> ListaAluno { get; private set; } = new List<Aluno>(); //lista de alunos

        Professor p = new Professor();

        public void NumeroDaTurma() //metodo que pega um número para ser o número da turma
        {
            Console.Write("Qual o número da turma? ");
            string nAux = Console.ReadLine();
            uint numero;

            while (!uint.TryParse(nAux, out numero) || (numero == 0))          //validar idade
            {
                Console.Write("Invalido! Qual o número da turma? ");
                nAux = Console.ReadLine();
            }
            Numero = numero;
        }

        public void InserirProfessor() => p.AddProfessor(); //metodo para adicionar o professor


        public void InserirAluno() //metodo para adicionar os alunos
        {
            Console.Write("Qual o número de alunos você deseja inserir? ");
            string nAux = Console.ReadLine();
            uint numero;

            while (!uint.TryParse(nAux, out numero) || (numero == 0))                       //validar idade
            {
                Console.Write("Invalido! Qual o número de alunos você deseja inserir? ");
                nAux = Console.ReadLine();
            }

            for (int i = 1; i <= numero; i++)
            {
                Aluno a = new Aluno();
                a.AdicionarAluno();
                ListaAluno.Add(a);
                if (a.NumeroMatricula == a.NumeroMatricula)
                {
                    Random rnd = new Random();
                    a.NumeroMatricula = rnd.Next(0, 999999);
                }
            }
        }

        public string MostrarProfessor() => p.Mostrar(); //mostrar professor
        public uint MostrarNumero() => Numero; //mostrar numero
    }
}