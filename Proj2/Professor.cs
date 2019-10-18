using System;
using System.Collections.Generic;

namespace Proj2
{
    class Professor : Pessoa // a classe professor recebendo pessoa
    {

        public int NumeroRegistro { get; set; }
        public Coordenador CoordDoProfessor { get; set; }

        public void AddProfessor()
        {
            //------------------Adicionar nome do professor-----------------------------
            Console.WriteLine("Qual o nome do professor: ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || string.IsNullOrEmpty(Nome) || (Nome.Length < 3)) // validação do nome do professor atraves de um metodo, não pode ser vazio ou nulo e tem que ser maior do que três
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
            while (!uint.TryParse(Console.ReadLine(), out idade) || (idade == 0))                       //validar se a idade é um numero e não é igual a zero
            {
                Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");
                
            }
            Idade = idade; // passando o valor da variavel auxiliar para o atributo

            //-----------------Gerar número do registro aleatorio--------------
            Random rnd = new Random();
            NumeroRegistro = rnd.Next(0, 999999);           // gerando um número aleatorio para ser o registro do professor

            Console.WriteLine($"Qual é o coordenador do(a) {Nome}: ");
            uint opcaoCoord;
            while (!uint.TryParse(Console.ReadLine(), out opcaoCoord))                       
            Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");


        }

        public override string ToString() => $"O professor: {Nome}, tem {Idade} anos, seu sexo é {Sexo}. Seu número de registro: {NumeroRegistro}. O coordenador desse professor é:{CoordDoProfessor} \n";

    }
}