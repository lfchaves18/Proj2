using System;
using System.Collections.Generic;


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

            Console.WriteLine("\nTurma cadastrada com sucesso\n");
            


        }

        /*public void MostarTurmas()
        {
            foreach (Turma t in esc.ListaTurma)
            {
                Console.WriteLine($"A turma {NumeroTurma}, com limite de {NumPessoaNaTurma}: \n");

                if (CoordNaTurma == null) Console.WriteLine("Essa turma não tem coordenador.\n");
                else Console.WriteLine($"O coordenador é:\n {CoordNaTurma.Nome} - {CoordNaTurma.Sexo} - {CoordNaTurma.Idade} - {CoordNaTurma.NumCoordenador}.\n");

                if (ProfNaTurma == null) Console.WriteLine("Essa turma não tem professor.\n");
                else Console.WriteLine($"O professor é: \n {ProfNaTurma.Nome} - {ProfNaTurma.Sexo} - {ProfNaTurma.Idade} - {ProfNaTurma.NumeroRegistro}.\n");

                if (ListaAlunoTurma == null) Console.WriteLine("Essa turma não tem aluno.\n");
                else
                {
                    Console.WriteLine($"Os alunos são: ");
                    foreach (Aluno a in ListaAlunoTurma) Console.WriteLine($"{a.Nome} - {a.Sexo} - {a.Idade} - {a.NumeroMatricula} - {a.RespBolsista} bolsita. \n");
                }
            }
        }*/
        public override string ToString() => $"Número da turma é: {NumeroTurma}, o maximo de pessoas que podem contar nela é: {NumPessoaNaTurma}\n";

    }
}