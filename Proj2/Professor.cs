using System;
using System.Collections.Generic;
using System.Linq;

namespace Proj2
{
    class Professor : Pessoa // a classe professor recebendo pessoa
    {

        public int NumeroRegistro { get; set; }
        public Coordenador CoordDoProfessor { get; set; }
        public int NumTurmasProf { get; set; }

        public void AddProfessor()
        {
            Escola esc = new Escola();

            //------------------Adicionar nome do professor-----------------------------
            Console.WriteLine("Qual o nome do professor: ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || (Nome.Length < 3)) // validação do nome do professor atraves de um metodo, não pode ser vazio ou nulo e tem que ser maior do que três
            {
                Console.WriteLine("Invalido! Qual o nome do professor? ");
                Nome = Console.ReadLine();
            }


            //------------Inserir o sexo do professor-------------------
            Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M':");
            Sexo = Console.ReadLine().Trim().ToUpper();
            while (Sexo != "F" && Sexo != "M" || string.IsNullOrEmpty(Sexo)) //validando o sexo que só tem duas opções: Femenino ou Masculino
            {
                Console.WriteLine($"Invalido! Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M':");
                Sexo = Console.ReadLine().Trim().ToUpper();
            }

            //------------Inserir a idade do professor-----------------
            Console.WriteLine($"Qual a idade do(a) {Nome}: \n Ele deve ter entre 20 anos e 110 anos ");
            uint idade;
            while (!uint.TryParse(Console.ReadLine(), out idade) || (idade < 20) || (idade > 110))                       //validar se a idade é um numero e não é igual a zero
            {
                Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");

            }
            Idade = idade; // passando o valor da variavel auxiliar para o atributo


            //----------------Adicionando coordenaodor----------------------
            /*  foreach (Coordenador c1 in esc.ListaCoordenador)
                  Console.WriteLine(c1.Nome);*/
           

                Console.Write("Qual coordenor deste professor?\n Insira o Numero: "); // pede para informar o coordenador que deseja cadastrar
            uint opcaoCoord;
            while (!uint.TryParse(Console.ReadLine(), out opcaoCoord))         // valida se as informações passadas são as desejadas
                Console.WriteLine($"Invalido! Insira novamente o Numero do coordenador: "); // se não forem validas, vai ser pedido novamente 


            Coordenador c = esc.ListaCoordenador.Find(buscaCoord => buscaCoord.NumCoordenador == opcaoCoord); //operação para buscar o numero do registro do professor

            if (c != null) CoordDoProfessor = c; // adicionar o coordenador ao professor desejadado
            else Console.WriteLine("O(a) coordenador(a) que você deseja inserir, não existe!");


            //-----------------Gerar número do coordenador aleatorio--------------
            Random rnd = new Random();
            NumeroRegistro = rnd.Next(0, 999999);           // gerando um número aleatorio para ser o registro do professor
            while (esc.ListaProfessor.Any(buscaNum => buscaNum.NumeroRegistro == NumeroRegistro))
                NumeroRegistro = rnd.Next(0, 999999);

        }
        public override string ToString() => $"O professor: {Nome}, tem {Idade} anos, seu sexo é {Sexo}. Seu número de registro: {NumeroRegistro}. O coordenador desse professor é:{CoordDoProfessor} \n";

    }
}