using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj2
{
    class Coordenador : Pessoa
    {
        public int NumCoordenador { get; set; }
        Escola esc = new Escola();
        public void AddCoordenador()
        {
            //------------------Adicionar nome do coordenador-----------------------------
            Console.WriteLine("Qual o nome do(a) coordernador(a): ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || string.IsNullOrEmpty(Nome) || (Nome.Length < 3)) // validação do nome do coordenador atraves de um metodo, não pode ser vazio ou nulo e tem que ser maior do que três
            {
                Console.WriteLine("Invalido! Qual o nome do professor? ");
                Nome = Console.ReadLine();
            }


            //------------Inserir o sexo do coordenador-------------------
            Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M':");
            Sexo = Console.ReadLine().Trim().ToUpper();
            while (Sexo != "F" && Sexo != "M" || string.IsNullOrEmpty(Sexo)) //validando o sexo que só tem duas opções: Femenino ou Masculino
            {
                Console.WriteLine($"Invalido! Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M':");
                Sexo = Console.ReadLine().Trim().ToUpper();
            }

            //------------Inserir a idade do coordenador-----------------
            Console.WriteLine($"Qual a idade do(a) {Nome}: \n Ele deve ter entre 25 anos e 110 anos ");
            uint idade;
            while (!uint.TryParse(Console.ReadLine(), out idade) || (idade < 25) || (idade > 110))                       //validar se a idade é um numero e não é igual a zero
            {
                Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");

            }
            Idade = idade; // passando o valor da variavel auxiliar para o atributo

            //-----------------Gerar número do coordenador aleatorio--------------
            Random rnd = new Random();
            NumCoordenador = rnd.Next(0, 999999);           // gerando um número aleatorio para ser o registro do professor

            while (esc.ListaCoordenador.Any(buscaNum => buscaNum.NumCoordenador == NumCoordenador))
                NumCoordenador = rnd.Next(0, 999999);

            Console.WriteLine("Coordenador cadastrado com sucesso");
            
        }
        public override string ToString() => $"O professor: {Nome}, tem {Idade} anos, seu sexo é {Sexo}. Seu número de registro: {NumCoordenador}\n";

    }
}
