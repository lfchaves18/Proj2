using System;
using System.Collections.Generic;

namespace Proj2
{
    class Escola
    {


        public List<Turma> ListaTurma { get; set; } = new List<Turma>();
        public List<Professor> ListaProfessor { get; set; } = new List<Professor>();
        public List<Aluno> ListaAluno { get; set; } = new List<Aluno>();
        public List<Coordenador> ListaCoordenador { get; set; } = new List<Coordenador>();

        public void AtribuirProfessor()
        {
            if (ListaTurma.Count == 0) //verificar se existe alguma turma
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
                    ListaTurma.Add(turma2);
                }
            }

            else if (ListaProfessor.Count == 0) //verifica se o professor existe
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
                    ListaProfessor.Add(prof2);
                }
            }

            else    // se já existir um professor e uma turma, ele vai atribuir
            {
                foreach (Turma tur in ListaTurma) //mostra as turmas que existem
                    Console.WriteLine($"\n{tur}");
                foreach (Professor exibirProf in ListaProfessor) // mostra os professores que existem
                    Console.WriteLine($"\n{exibirProf}");


                Console.WriteLine("Qual professor(a) você deseja cadastrar?\n Insira o Numero de Registro: "); // pede para informar o professor que deseja cadastrar
                uint opcaoProf;
                while (!uint.TryParse(Console.ReadLine(), out opcaoProf))         // valida se as informações passadas são as desejadas
                    Console.WriteLine($"Invalido! Insira novamente o Numero de Registro: "); // se não forem validas, vai ser pedido novamente 



                Console.WriteLine("Em qual turma deseja cadastrar o(a) professor(a): "); // pede para informar a turma que deseja inserir o professorstring opcaoTurmaAux = Console.ReadLine();
                uint opcaoTurma;
                while (!uint.TryParse(Console.ReadLine(), out opcaoTurma))      // valida se as informações passadas são as desejadas                  
                    Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o(a) professor(a): "); // se não forem validas, vai ser pedido novamente


                Professor p = ListaProfessor.Find(buscaProf => buscaProf.NumeroRegistro == opcaoProf); //operação para buscar o numero do registro do professor
                Turma t = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma); // operação para buscar o numero da turma

                if (ListaTurma.Contains(t) && ListaProfessor.Contains(p))
                {
                    t.ProfNaTurma = p; // adicionar o professor a turma desejada

                    Console.WriteLine($"\n A turma {opcaoTurma} tem como professor:\n {p}"); // mostra a turma desejada e o professor que ela tem 
                }
                else Console.WriteLine("A turma e/ou o(a) professor(a) que você deseja inserir, não existem!");

            }
        }

        public void AtribuirCoordenador()
        {
            if (ListaTurma.Count == 0) //verificar se existe alguma turma
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
                    ListaTurma.Add(turma2);
                }
            }

            else if (ListaCoordenador.Count == 0) //verifica se o coordenador existe
            {
                Console.WriteLine("Não existem coordenadores cadastradas!\nDeseja cadastrar uma nova turma (S ou N)?");
                string resp = Console.ReadLine().ToUpper().Trim();
                while (resp != "S" && resp != "N") // se o coordenador não existir, vai dar a opção se adicionar ou não
                {
                    Console.WriteLine($"Invalido!Não existem coordenadores cadastradas!\nDeseja cadastrar uma nova turma (S ou N)?  ");
                    resp = Console.ReadLine().ToUpper().Trim();
                }
                if (resp == "S")
                {                      // se a resposta for sim, adiciona um novo a coordenador a de lista de professor
                    Coordenador coord = new Coordenador();
                    coord.AddCoordenador();
                    ListaCoordenador.Add(coord);
                }
            }

            else    // se já existir um coordenador e uma turma, ele vai atribuir
            {
                foreach (Turma tur in ListaTurma) //mostra as turmas que existem
                    Console.WriteLine($"\n{tur}");
                foreach (Coordenador exibirCoord in ListaCoordenador) // mostra os coordenador que existem
                    Console.WriteLine($"\n{exibirCoord}");


                Console.WriteLine("Em qual turma deseja cadastrar o(a) coordenador(a): "); // pede para informar a turma que deseja inserir o professor
                uint opcaoTurma;
                while (!uint.TryParse(Console.ReadLine(), out opcaoTurma))      // valida se as informações passadas são as desejadas 
                    Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o(a) coordenadores(a): "); // se não forem validas, vai ser pedido novamente

                Console.WriteLine("Qual coordenador você deseja cadastrar?\n Insira o numero: "); // pede para informar o coordenador que deseja cadastrar
                uint opcaoCoord;
                while (!uint.TryParse(Console.ReadLine(), out opcaoCoord))         // valida se as informações passadas são as desejadas
                    Console.WriteLine($"Invalido! Insira novamente o Numero do coordenador: "); // se não forem validas, vai ser pedido novamente 


                Coordenador c = ListaCoordenador.Find(buscaCoord => buscaCoord.NumCoordenador == opcaoCoord); //operação para buscar o numero do registro do professor
                Turma t = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma); // operação para buscar o numero da turma

                if (ListaTurma.Contains(t) && ListaCoordenador.Contains(c))
                {
                    t.CoordNaTurma = c; // adicionar o professor a turma desejada

                    Console.WriteLine($"\n A turma {opcaoTurma} tem como professor:\n {c}"); // mostra a turma desejada e o professor que ela tem 
                }
                else Console.WriteLine("A turma e/ou o(a) coordenador(a) que você deseja inserir, não existem!");

            }
        }

        public void AtribuirAluno()
        {
            if (ListaTurma.Count == 0) //verificar se existe alguma turma
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
                    ListaTurma.Add(turma2);
                }
            }

            else if (ListaAluno.Count == 0)
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
                    ListaAluno.Add(aluno2);
                }
            }

            else
            {
                foreach (Turma tur in ListaTurma)
                    Console.WriteLine($"{tur}\n");

                foreach (Aluno a1 in ListaAluno)
                    Console.WriteLine($"{a1}\n");


                Console.WriteLine("Qual aluno você deseja cadastrar?\n Insira o Numero de Matricula: ");
                uint opcaoAluno;
                while (!uint.TryParse(Console.ReadLine(), out opcaoAluno))                       //validando se a idade do aluno é maior que zero e se é um número  Console.WriteLine($"Invalido! Insira novamente o Numero de Matricula: ");
                    Console.WriteLine("Invalido! Em qual turma deseja cadastrar o aluno: ");

                Console.WriteLine("Em qual turma deseja cadastrar? \n Insira o numero da turma: ");
                uint opcaoTurmaAlu;
                while (!uint.TryParse(Console.ReadLine(), out opcaoTurmaAlu))                       //validando se a idade do aluno é maior que zero e se é um número
                    Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o aluno: ");


                Aluno aluno = ListaAluno.Find(buscaAluno => buscaAluno.NumeroMatricula == opcaoAluno);
                Turma turma = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurmaAlu);

                if (aluno != null && turma != null)
                {
                    turma.ListaAlunoTurma.Add(aluno);
                    foreach (Aluno alu in turma.ListaAlunoTurma) Console.WriteLine($"\n A turma {opcaoTurmaAlu} \n {aluno}\n");
                }
                else Console.WriteLine("A turma e/ou o(a) aluno(a) que você deseja inserir, não existem!");
            }
        }

        public void RemoverProfessorTurma()
        {

            foreach (Turma tur in ListaTurma) //mostra as turmas que existem
                Console.WriteLine($"\n{tur}");

            Console.WriteLine("Em qual turma deseja remover o(a) professor(a): "); // pede para informar a turma que deseja inserir o professorstring opcaoTurmaAux = Console.ReadLine();
            uint opcaoTurma;
            while (!uint.TryParse(Console.ReadLine(), out opcaoTurma))      // valida se as informações passadas são as desejadas                  
                Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o(a) professor(a): "); // se não forem validas, vai ser pedido novamente


            Turma t = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma); // operação para buscar o numero da turma

            t.ProfNaTurma = null; // adicionar o professor a turma desejada
        }

        public void RemoverCoordenadorTurma()
        {

            foreach (Turma tur in ListaTurma) //mostra as turmas que existem
                Console.WriteLine($"\n{tur}");

            Console.WriteLine("Em qual turma deseja remover o(a) professor(a): "); // pede para informar a turma que deseja inserir o professorstring opcaoTurmaAux = Console.ReadLine();
            uint opcaoTurma;
            while (!uint.TryParse(Console.ReadLine(), out opcaoTurma))      // valida se as informações passadas são as desejadas                  
                Console.WriteLine($"Invalido! Em qual turma deseja cadastrar o(a) professor(a): "); // se não forem validas, vai ser pedido novamente


            Turma t = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurma); // operação para buscar o numero da turma

            t.CoordNaTurma = null; // adicionar o professor a turma desejada
        }

        public void RemoverAlunoTurma()
        {
            foreach (Turma tur in ListaTurma)
                Console.WriteLine($"{tur}\n");

            foreach (Aluno a1 in ListaAluno)
                Console.WriteLine($"{a1}\n");


            Console.WriteLine("Qual aluno você deseja cadastrar?\n Insira o numero de matricula: ");
            uint opcaoAluno;
            while (!uint.TryParse(Console.ReadLine(), out opcaoAluno))                       //validando se a idade do aluno é maior que zero e se é um número  Console.WriteLine($"Invalido! Insira novamente o Numero de Matricula: ");
                Console.WriteLine("Invalido! Em qual turma deseja cadastrar o aluno: ");

            Console.WriteLine("De qual turma voce deseja remover? \n Insira o numero da turma: ");
            uint opcaoTurmaAlu;
            while (!uint.TryParse(Console.ReadLine(), out opcaoTurmaAlu))                       //validando se a idade do aluno é maior que zero e se é um número
                Console.WriteLine($"Invalido! Em qual de turma deseja remover o aluno: ");


            Aluno aluno = ListaAluno.Find(buscaAluno => buscaAluno.NumeroMatricula == opcaoAluno);
            Turma turma = ListaTurma.Find(buscaTurma => buscaTurma.NumeroTurma == opcaoTurmaAlu);

            if (aluno != null && turma != null)
            {
                turma.ListaAlunoTurma.Remove(aluno);
            }
            else Console.WriteLine("A turma e/ou o(a) aluno(a) que você deseja remover, não existem!");
        }

    }
}
