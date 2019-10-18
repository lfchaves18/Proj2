using System;
using System.Collections.Generic;
using System.Text;

namespace Proj2
{
    class Menu
    {
        public uint Numero { get; set; }

        Escola e = new Escola();
        Turma T = new Turma();

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
                        e.ListaTurma.Add(turma);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 2: // adicionar professor
                        Professor prof = new Professor();
                        prof.AddProfessor();
                        e.ListaProfessor.Add(prof);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3: // adicionar aluno
                        Aluno aluno = new Aluno();
                        aluno.AdicionarAluno();
                        e.ListaAluno.Add(aluno);

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4: // mostrar turma
                        foreach (Turma tur in e.ListaTurma)
                            Console.WriteLine(tur);
                        if (e.ListaTurma.Count == 0) 
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
                                e.ListaTurma.Add(turma2);
                            }
                        }
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5: //mostrar professores
                        foreach (Professor exibirProf in e.ListaProfessor)
                            Console.WriteLine(exibirProf);
                        if (e.ListaProfessor.Count == 0) //verifica se o professor existe
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
                                e.ListaProfessor.Add(prof2);
                            }
                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6: // mostrar aluno
                        foreach (Aluno a1 in e.ListaAluno)
                            Console.WriteLine(a1);
                        if (e.ListaAluno.Count == 0)
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
                                e.ListaAluno.Add(aluno2);
                            }
                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 7: // atribuir professores a turma

                        if (e.ListaTurma.Count == 0) //verificar se existe alguma turma
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
                                e.ListaTurma.Add(turma2);
                            }
                        }

                        else if (e.ListaProfessor.Count == 0) //verifica se o professor existe
                        {
                            Console.WriteLine("Não existem professores cadastradas!\nDeseja cadastrar uma nova turma (S ou N)?");
                            string resp = Console.ReadLine().ToUpper().Trim();
                            while (resp != "S" && resp != "N") // se o professor não existir, vai dar a opção se adicionar ou não
                            {
                                Console.WriteLine($"Invalido!Não existem professores cadastradas!\nDeseja cadastrar uma nova turma (S ou N)?  ");
                                resp = Console.ReadLine().ToUpper().Trim();
                            }
                            if (resp == "S")
                            {                      // se a resposta for sim, adiciona um novo a professor a de lista de professor
                                Professor prof2 = new Professor();
                                prof2.AddProfessor();
                                e.ListaProfessor.Add(prof2);
                            }
                        }

                        else    // se já existir um professor e uma turma, ele vai atribuir
                        {
                            foreach (Turma tur in e.ListaTurma) //mostra as turmas que existem
                                Console.WriteLine($"\n{tur}");
                            foreach (Professor exibirProf in e.ListaProfessor) // mostra os professores que existem
                                Console.WriteLine($"\n{exibirProf}");


                            Console.WriteLine("Qual professor(a) você deseja cadastrar?\n Insira o Numero de Registro: "); // pede para informar o professor que deseja cadastrar
                            string opcaoProfAux = Console.ReadLine();
                            uint opcaoProf;
                            while (!uint.TryParse(opcaoProfAux, out opcaoProf))         // valida se as informações passadas são as desejadas
                            {
                                Console.WriteLine($"Invalido! Insira novamente o Numero de Registro: "); // se não forem validas, vai ser pedido novamente 
                                opcaoProfAux = Console.ReadLine();
                            }


                            Console.WriteLine("Em qual turma deseja cadastrar o(a) professor(a): "); // pede para informar a turma que deseja inserir o professor
                            string opcaoTurmaAux = Console.ReadLine();
                            uint opcaoTurma;
                            while (!uint.TryParse(opcaoTurmaAux, out opcaoTurma))      // valida se as informações passadas são as desejadas                  
                            {
                                Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o(a) professor(a): "); // se não forem validas, vai ser pedido novamente
                                opcaoTurmaAux = Console.ReadLine();
                            }

                            Professor p = e.ListaProfessor.Find(buscaProf => buscaProf.NumeroRegistro == opcaoProf); //operação para buscar o numero do registro do professor
                            Turma t = e.ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma); // operação para buscar o numero da turma

                            if (e.ListaTurma.Contains(t) && e.ListaProfessor.Contains(p))
                            {
                                t.ProfNaTurma = p; // adicionar o professor a turma desejada

                                Console.WriteLine($"\n A turma {opcaoTurma} tem como professor:\n {p}"); // mostra a turma desejada e o professor que ela tem 
                            }
                            else Console.WriteLine("A turma e/ou o(a) professor(a) que você deseja inserir, não existem!");

                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 8: // atribuir alunos a turma                                                                                                
                        if (e.ListaTurma.Count == 0) //verificar se existe alguma turma
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
                                e.ListaTurma.Add(turma2);
                            }

                        }

                        else if (e.ListaAluno.Count == 0)
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
                                e.ListaAluno.Add(aluno2);
                            }
                        }

                        else
                        {
                            foreach (Turma tur in e.ListaTurma)
                                Console.WriteLine($"\n{tur}\n");

                            foreach (Aluno a1 in e.ListaAluno)
                                Console.WriteLine($"{a1}\n");

                            Console.WriteLine("Qual aluno você deseja cadastrar?\n Insira o Numero de Matricula: ");
                            string opcaoAlunoAux = Console.ReadLine();
                            uint opcaoAluno;
                            while (!uint.TryParse(opcaoAlunoAux, out opcaoAluno))                       //validando se a idade do aluno é maior que zero e se é um número
                            {
                                Console.WriteLine($"Invalido! Insira novamente o Numero de Matricula: ");
                                opcaoAlunoAux = Console.ReadLine();
                            }

                            Console.WriteLine("Em qual turma deseja cadastrar o aluno: ");
                            string opcaoTurmaAuxAlu = Console.ReadLine();
                            uint opcaoTurmaAlu;
                            while (!uint.TryParse(opcaoTurmaAuxAlu, out opcaoTurmaAlu))                       //validando se a idade do aluno é maior que zero e se é um número
                            {
                                Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o aluno: ");
                                opcaoTurmaAuxAlu = Console.ReadLine();
                            }

                            Aluno a = e.ListaAluno.Find(buscaAluno => buscaAluno.NumeroMatricula == opcaoAluno);
                           
                            Turma
                                tAlu = e.ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurmaAlu);

                            if (e.ListaAluno.Contains(a) && e.ListaTurma.Contains(tAlu))
                            {
                                tAlu.ListaAlunoTurma.Add(a);
                                foreach (Aluno alu in tAlu.ListaAlunoTurma) Console.WriteLine($"\n A turma {opcaoTurmaAlu} \n {alu}\n");
                            }
                            else Console.WriteLine("A turma e/ou o(a) aluno(a) que você deseja inserir, não existem!");
                        }

                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
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