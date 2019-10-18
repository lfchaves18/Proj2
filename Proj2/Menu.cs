using System;
using System.Collections.Generic;

namespace Proj2
{
    class Menu
    {
        public uint Numero { get; set; }
       /* public List<Turma> ListaTurma { get; set; } = new List<Turma>();
        public List<Professor> ListaProfessor { get; set; } = new List<Professor>();
        public List<Aluno> ListaAluno { get; set; } = new List<Aluno>();*/

        Turma turma = new Turma();
        Escola esc = new Escola();

        public void AddMenu()
        {
            do
            {
                Console.WriteLine("\n---- Bem-Vindo ---- \n ");
                Console.WriteLine("1- Adicionar turma. \n");
                Console.WriteLine("2- Adicionar professor.\n");
                Console.WriteLine("3- Adicionar aluno.\n ");
                Console.WriteLine("4- Mostrar turmas.\n");
                Console.WriteLine("5- Mostrar professores. \n");
                Console.WriteLine("6- Mostrar alunos.\n");
                Console.WriteLine("7- Adicionar professores a turma.\n");
                Console.WriteLine("8- Adicionar alunos a turma.\n");
                Console.WriteLine("0- Sair. \n");
                Console.Write("Digite a opção desejada:  ");
                string numeroAux = Console.ReadLine();
                Console.WriteLine();
                uint numero;
                while (!uint.TryParse(numeroAux, out numero))                       //validando se a idade do aluno é maior que zero e se é um número
                {
                    Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");
                    numeroAux = Console.ReadLine();
                }
                Numero = numero;

                switch (Numero)
                {
                    case 1: // adicionar turma
                        Turma turma = new Turma();
                        turma.AdicionarTurma();
                        esc.ListaTurma.Add(turma);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 2: // adicionar professor
                        Professor prof = new Professor();
                        prof.AddProfessor();
                        esc.ListaProfessor.Add(prof);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3: // adicionar aluno
                        Aluno aluno = new Aluno();
                        aluno.AdicionarAluno();
                        esc.ListaAluno.Add(aluno);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4: // mostrar turma
                       /* int opcaoMenu4;
                        do
                        {
                            Console.WriteLine("Mostrar turmas existentes: ");
                            Console.WriteLine("Mostrar turmas populadas: ");
                            Console.WriteLine("Digite a opção desejada: ");
                            opcaoMenu4 = int.Parse(Console.ReadLine());

                        } while (opcaoMenu4 != 0);*/

                        foreach (Turma tur in esc.ListaTurma)
                            Console.WriteLine($" {tur} \n");

                        if (esc.ListaTurma.Count == 0)
                        {
                            Console.WriteLine("Não existem turmas cadastradas!\nDeseja cadastrar turmas (S ou N)?");
                            string resp = Console.ReadLine().ToUpper().Trim();
                            while (resp != "S" && resp != "N") // se a turma não existir, vai dar a opção se adicionar ou não
                            {
                                Console.WriteLine($"Invalido! Não existem turmas cadastradas!\nDeseja cadastrar turmas (S ou N)?  ");
                                resp = Console.ReadLine().ToUpper().Trim();
                            }
                            if (resp == "S")
                            {                      // se a resposta for sim, adiciona uma nova turma a de lista de turma
                                Turma turma2 = new Turma();
                                turma2.AdicionarTurma();
                                esc.ListaTurma.Add(turma2);
                            }
                        }
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5: //mostrar professores
                        foreach (Professor exibirProf in esc.ListaProfessor)
                            Console.WriteLine(exibirProf);
                        if (esc.ListaProfessor.Count == 0) //verifica se o professor existe
                        {
                            Console.WriteLine("Não existem professores cadastradas!\nDeseja cadastrar um novo (a) professor(a) (S ou N)?");
                            string resp = Console.ReadLine().ToUpper().Trim();
                            while (resp != "S" && resp != "N") // se o professor não existir, vai dar a opção se adicionar ou não
                            {
                                Console.WriteLine($"Invalido!Não existem professores cadastradas!\nDeseja cadastrar um (a) professor(a) (S ou N)?  ");
                                resp = Console.ReadLine().ToUpper().Trim();
                            }
                            if (resp == "S")
                            {                      // se a resposta for sim, adiciona um novo a professor a de lista de professor
                                Professor prof2 = new Professor();
                                prof2.AddProfessor();
                                esc.ListaProfessor.Add(prof2);
                            }
                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6: // mostrar aluno
                        foreach (Aluno a1 in esc.ListaAluno)
                            Console.WriteLine(a1);
                        if (esc.ListaAluno.Count == 0)
                        {
                            Console.WriteLine("Não existem alunos cadastrado! \n Deseja cadastrar um novo aluno (S ou N)");
                            string resp = Console.ReadLine().ToUpper().Trim();
                            while (resp != "S" && resp != "N") // se o professor não existir, vai dar a opção se adicionar ou não
                            {
                                Console.WriteLine($"Invalido!Não existem alunos cadastradas!\nDeseja cadastrar um novo aluno (S ou N)?  ");
                                resp = Console.ReadLine().ToUpper().Trim();
                            }
                            if (resp == "S")
                            {                      // se a resposta for sim, adiciona um novo a professor a de lista de professor
                                Aluno aluno2 = new Aluno();
                                aluno2.AdicionarAluno();
                                esc.ListaAluno.Add(aluno2);
                            }
                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 7: // atribuir professores a turma
                        esc.AtribuirProfessor();
                       
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 8: // atribuir alunos a turma                                                                                                
                        esc.AtribuirAluno();

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 9:
                        Coordenador c = new Coordenador();
                        c.AddCoordenador();            //TESTE PARA ADICIONAR COORDENADOR
                        esc.ListaCoordenador.Add(c);
                        break;
                    case 10:
                        esc.AtribuirCoordenador();              //TESTE PARA ATRIBUIR COORDENADOR A TURMA
                        break;

                    case 0:
                        Console.WriteLine("Você escolheu sair!");
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

            } while (Numero != 0);
        }
    }
}