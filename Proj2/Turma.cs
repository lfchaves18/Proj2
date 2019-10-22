using System;
using System.Collections.Generic;
using System.Linq;

namespace Proj2
{
    class Turma
    {
        public int NumeroTurma { get; set; }
        public uint NumPessoaNaTurma { get; set; }
        public List<Aluno> ListaAlunoTurma { get; set; } = new List<Aluno>();
        public Professor ProfNaTurma { get; set; }
        public Coordenador CoordNaTurma { get; set; }
        Escola esc = new Escola();

        public void AdicionarTurma()
        {
            //-------------Numero de pessoas na turma-----------
            Console.WriteLine("Quantos alunos podem ter essa turma? ");
            string numeroTurmaAux = Console.ReadLine();
            uint numeroTurma;
            while (!uint.TryParse(numeroTurmaAux, out numeroTurma) || (numeroTurma == 0))                       //validando se a idade do aluno é maior que zero e se é um número
            {
                Console.WriteLine($"Invalido! Quantos alunos podem ter na turma: ");
                numeroTurmaAux = Console.ReadLine();
            }
            NumPessoaNaTurma = numeroTurma;

            //---------------Numero da turma-----------------
            Random rnd = new Random();
            NumeroTurma = rnd.Next(0, 999999); // gerar número aleatorio 
            while (esc.ListaTurma.Any(buscaNum => buscaNum.NumeroTurma == NumeroTurma))
                NumeroTurma = rnd.Next(0, 999999);

            Console.WriteLine("\nTurma cadastrada com sucesso\n");
            


        }

        
        public override string ToString() => $"Número da turma é: {NumeroTurma}, o maximo de pessoas que podem contar nela é: {NumPessoaNaTurma}\n";

    }
}