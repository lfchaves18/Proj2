using System;

namespace Proj2
{
    class Professor : Pessoa // a classe professor recebendo pessoa
    {

        public int NumeroRegistro { get; set; }
        public void AddProfessor()
        {
            Console.WriteLine("Qual o nome do professor: ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || string.IsNullOrEmpty(Nome) || (Nome.Length < 3)) // validação do nome do professor atraves de um metodo, não pode ser vazio ou nulo e tem que ser maior do que três
            {
                Console.WriteLine("Invalido! Qual o nome do professor? ");
                Nome = Console.ReadLine();
            }
            Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'Feminino' ou 'Masculino':");
            Sexo = Console.ReadLine();

            while (Sexo != "Feminino" && Sexo != "Masculino" || string.IsNullOrEmpty(Sexo)) //validando o sexo que só tem duas opções: Femenino ou Masculino
            {
                Console.WriteLine($"Invalido! Qual o sexo do(a) {Nome} \n Responda com 'Feminino' ou 'Masculino':");
                Sexo = Console.ReadLine();
            }

            Console.WriteLine($"Qual a idade do(a) {Nome}: ");
            string idadeAux = Console.ReadLine();
            uint idade;


            while (!uint.TryParse(idadeAux, out idade) || (idade == 0))                       //validar se a idade é um numero e não é igual a zero
            {
                Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");
                idadeAux = Console.ReadLine();
            }
            Idade = idade; // passando o valor da variavel auxiliar para o atributo

            Random rnd = new Random();
            NumeroRegistro = rnd.Next(0, 999999); // gerando um número aleatorio para ser o registro do professor;
            if (NumeroRegistro == NumeroRegistro) // validação do número de registro
                NumeroRegistro = rnd.Next(0, 999999);

            Console.WriteLine();

        }

        public string Mostrar() => $"O professor: {Nome}, tem {Idade} anos, seu sexo é {Sexo}. Seu número de registro: {NumeroRegistro}\n"; // metodo que mostra os dados do professor

    }
}