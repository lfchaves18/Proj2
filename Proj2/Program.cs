using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {

            Turma t = new Turma();


            t.NumeroDaTurma();
            t.InserirProfessor();
            t.InserirAluno();

            Console.WriteLine($"A turma {t.MostrarNumero()} tem:\n"); //mostrar o numero a turma
            Console.WriteLine(t.MostrarProfessor()); //mostrar professor



            foreach (Aluno aluno in t.ListaAluno) //percorrer a lista de alunos e imprimir cada aluno na tela
            {
                Console.WriteLine($"O nome do aluno é: {aluno.Nome}, tem {aluno.Idade}," +
                    $" seu sexo é: {aluno.Sexo} e seu número de matricula é: {aluno.NumeroMatricula}. " +
                    $"Este aluno(a) {aluno.RespBolsista} bolsista!!\n");

            }
        }
    }
}
