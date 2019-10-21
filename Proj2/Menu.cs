using System;

namespace Proj2
{
    class Menu
    {
        public uint Numero { get; set; }

        Escola esc = new Escola();

        public void AddMenu()
        {
            do
            {
                uint numero;
                Console.WriteLine("\n---- Bem-Vindo ---- \n ");
                Console.WriteLine("1- Manipular turmas. \n");
                Console.WriteLine("2- Manipular professores.\n");
                Console.WriteLine("3- Manipular alunos.\n ");
                Console.WriteLine("4- Manipular coordenadores.\n");
                Console.WriteLine("0- Sair. \n");
                Console.WriteLine("Digite a opção desejada:  ");
                while (!uint.TryParse(Console.ReadLine(), out numero))
                    Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");
                Numero = numero;
                //---------------------SUBMENU TURMA-----------------------------
                switch (Numero)
                {
                    case 1: //  Menu principal: turma
                        uint opcaoMenuTurma;
                        while (!uint.TryParse(Console.ReadLine(), out opcaoMenuTurma))
                            Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");

                        do
                        {
                            Console.WriteLine("\n------- TURMA -------\n");
                            Console.WriteLine("1- Adicionar nova turma.\n");
                            Console.WriteLine("2- Remover turmas. \n");
                            Console.WriteLine("3- Mostar turmas existentes.\n");
                            Console.WriteLine("4- Mostrar turmas populadas. \n");
                            Console.WriteLine("0- Sair. \n");
                            Console.WriteLine("Digite a opção desejada: ");
                            while (!uint.TryParse(Console.ReadLine(), out opcaoMenuTurma))
                                Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");

                            switch (opcaoMenuTurma)
                            {
                                case 1: //opcao adicionar turma 
                                    Turma turma = new Turma();
                                    turma.AdicionarTurma();
                                    esc.ListaTurma.Add(turma);

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2:// remover turma
                                    if (esc.ListaTurma.Count == 0) //verifica se a turma existe
                                        Console.WriteLine("Não existem turmas cadastrados");
                                    else
                                    {
                                        foreach (Turma exibirTurma in esc.ListaTurma)
                                            Console.WriteLine(exibirTurma);

                                        Console.WriteLine("Qual o número do registro do professor que deseja remover: ");
                                        int opcaoTurma = int.Parse(Console.ReadLine());
                                        Turma t = esc.ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma);
                                        esc.ListaTurma.Remove(t);
                                    }

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3: //mostrar turmas existentes
                                    foreach (Turma exibirTurma in esc.ListaTurma)
                                        Console.WriteLine(exibirTurma);

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 4:  //mostar turmas populadas *ERRADO*
                                    if (esc.ListaTurma.Count == 0) //verificar se existe alguma turma
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
                                    else
                                    {
                                        foreach (Turma t in esc.ListaTurma)
                                        {
                                            Console.WriteLine($"A turma {t.NumeroTurma}, com limite de {t.NumPessoaNaTurma}: \n");

                                            if (t.CoordNaTurma == null) Console.WriteLine("Essa turma não tem coordenador.\n");
                                            else Console.WriteLine($"O coordenador é:\n {t.CoordNaTurma.Nome} - {t.CoordNaTurma.Sexo} - {t.CoordNaTurma.Idade} - {t.CoordNaTurma.NumCoordenador}.\n");

                                            if (t.ProfNaTurma == null) Console.WriteLine("Essa turma não tem professor.\n");
                                            else Console.WriteLine($"O professor é: \n {t.ProfNaTurma.Nome} - {t.ProfNaTurma.Sexo} - {t.ProfNaTurma.Idade} - {t.ProfNaTurma.NumeroRegistro}.\n");

                                            if (t.ListaAlunoTurma == null) Console.WriteLine("Essa turma não tem aluno.\n");
                                            else
                                            {
                                                Console.WriteLine($"Os alunos são: ");
                                                foreach (Aluno a in t.ListaAlunoTurma) Console.WriteLine($"{a.Nome} - {a.Sexo} - {a.Idade} - {a.NumeroMatricula} - {a.RespBolsista} bolsita. \n");
                                            }
                                        }
                                    }
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 0:
                                    Console.WriteLine("Você escolheu sair!");
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Opção Invalida!!");
                                    break;
                            }
                        } while (opcaoMenuTurma != 0);
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    //---------------------SUBMENU PROFESSOR-----------------------------
                    case 2: // adicionar professor
                        uint opcaoMenuProfessor;
                        do
                        {
                            Console.WriteLine("\n------- PROFESSOR -------\n");
                            Console.WriteLine("1- Adicionar novo professor.\n");
                            Console.WriteLine("2- Remover professor. \n");
                            Console.WriteLine("3- Adicionar professores a turma. \n");
                            Console.WriteLine("4- Remover professores a turma. \n");
                            Console.WriteLine("5- Mostar professores existentes. \n");
                            Console.WriteLine("0- Sair. \n");
                            Console.Write("Digite a opção desejada: ");
                            while (!uint.TryParse(Console.ReadLine(), out opcaoMenuProfessor))
                                Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");

                            switch (opcaoMenuProfessor)
                            {
                                case 1://adicionar professor
                                    Professor prof = new Professor();
                                    prof.AddProfessor();
                                    esc.ListaProfessor.Add(prof);

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2: // remover professor 
                                    if (esc.ListaProfessor.Count == 0) //verifica se o professor existe
                                        Console.WriteLine("Não existem professores cadastrados");
                                    else
                                    {
                                        foreach (Professor exibirProf in esc.ListaProfessor)
                                            Console.WriteLine(exibirProf);

                                        Console.WriteLine("Qual o número do registro do professor que deseja remover: ");
                                        int opcaoProf = int.Parse(Console.ReadLine());
                                        Professor p = esc.ListaProfessor.Find(buscaProf => buscaProf.NumeroRegistro == opcaoProf);
                                        esc.ListaProfessor.Remove(p);
                                    }
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3: //adicionar professores a turma 
                                    esc.AtribuirProfessor();

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 4://remover professores da turma *FALTA FAZER*
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 5:

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

                                    foreach (Professor exibirProf in esc.ListaProfessor)
                                        Console.WriteLine($"\n{exibirProf}");

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
                        } while (opcaoMenuProfessor != 0);
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    //---------------------SUBMENU ALUNO-----------------------------
                    case 3:// sub meu aluno
                        uint opcaoMenuAluno;

                        do
                        {
                            Console.WriteLine("\n------- ALUNO -------\n");
                            Console.WriteLine("1- Adicionar novo aluno.\n");
                            Console.WriteLine("2- Remover aluno. \n");
                            Console.WriteLine("3- Adicionar aluno a turma. \n");
                            Console.WriteLine("4- Remover aluno da turma. \n");
                            Console.WriteLine("5- Mostar aluno existentes. \n");
                            Console.WriteLine("0- Sair. \n");
                            Console.Write("Digite a opção desejada: ");
                            while (!uint.TryParse(Console.ReadLine(), out opcaoMenuAluno))
                                Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");

                            switch (opcaoMenuAluno)
                            {
                                case 1://adicionar professor
                                    Aluno aluno = new Aluno();
                                    aluno.AdicionarAluno();
                                    esc.ListaAluno.Add(aluno);

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2: // remover aluno *FALTA FAZER*
                                    if (esc.ListaAluno.Count == 0)
                                        Console.WriteLine("Não existem alunos cadastrados");
                                    else
                                    {
                                        foreach (Aluno exibirAluno in esc.ListaAluno)
                                            Console.WriteLine(exibirAluno);
                                        Console.WriteLine("Qual o número da matricula do aluno que deseja remover: ");
                                        int opcaoAluno = int.Parse(Console.ReadLine());

                                        Aluno a = esc.ListaAluno.Find(buscaAluno => buscaAluno.NumeroMatricula == opcaoAluno);
                                        esc.ListaAluno.Remove(a);
                                    }
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3: //adicionar alunos a turma 
                                    esc.AtribuirAluno();

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 4://remover aluno das turmas *FALTA FAZER*
                                    break;

                                case 5:

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
                                    foreach (Aluno a1 in esc.ListaAluno)
                                        Console.WriteLine(a1);

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
                        } while (opcaoMenuAluno != 0);
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    //---------------------SUBMENU COORDENADOR-----------------------------
                    case 4:
                        uint opcaoMenuCoordenador;

                        do
                        {
                            Console.WriteLine("\n------- Coordenador -------\n");
                            Console.WriteLine("1- Adicionar novo coordenador.\n");
                            Console.WriteLine("2- Remover coordenador. \n");
                            Console.WriteLine("3- Adicionar coordenador a turma. \n");
                            Console.WriteLine("4- Remover coordenador da turma. \n");
                            Console.WriteLine("5- Mostar coordenador existentes. \n");
                            Console.WriteLine("0- Sair. \n");
                            Console.Write("Digite a opção desejada: ");
                            while (!uint.TryParse(Console.ReadLine(), out opcaoMenuCoordenador))
                                Console.WriteLine($"Invalido! Digite novamente a opção desejada: ");

                            switch (opcaoMenuCoordenador)
                            {
                                case 1://adicionar coordenador
                                    Coordenador coordenador = new Coordenador();
                                    coordenador.AddCoordenador();
                                    esc.ListaCoordenador.Add(coordenador);

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2: // remover coordenadores *FALTA FAZER*
                                    if (esc.ListaCoordenador.Count == 0)
                                        Console.WriteLine("Não existem alunos cadastrados");
                                    else
                                    {
                                        foreach (Coordenador exibirCoord in esc.ListaCoordenador)
                                            Console.WriteLine($"\n {exibirCoord}");

                                        Console.WriteLine("Qual o numero do coordenador que deseja remover: ");
                                        int opcaoCoord = int.Parse(Console.ReadLine());
                                        Coordenador c = esc.ListaCoordenador.Find(buscaCoord => buscaCoord.NumCoordenador == opcaoCoord);

                                        esc.ListaCoordenador.Remove(c);
                                    }
                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3: //adicionar coordenadores a turma 
                                    esc.AtribuirCoordenador();

                                    Console.WriteLine("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 4: //remover coordenadores da turma*FALTA FAZER*
                                    break;

                                case 5: // msotrar coordenadores

                                    if (esc.ListaCoordenador.Count == 0)
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
                                            Coordenador coord1 = new Coordenador();
                                            coord1.AddCoordenador();
                                            esc.ListaCoordenador.Add(coord1);
                                        }
                                    }
                                    foreach (Coordenador coord in esc.ListaCoordenador)
                                        Console.WriteLine($"\n {coord}");

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
                        } while (opcaoMenuCoordenador != 0);
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 0:
                        Console.WriteLine("Você escolheu sair!");
                        Console.WriteLine("\nAperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

            } while (Numero != 0);
        }
    }
}

