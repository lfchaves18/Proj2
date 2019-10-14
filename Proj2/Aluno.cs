using System;

namespace Proj2
{
    class Aluno : Pessoa // recebe a herança de pessoa
    {
        public bool Bolsista { get; set; } // atributo para ver se o aluno é bolsista
        public int NumeroMatricula { get; set; } // atributo para o número de matricula
        public string RespBolsista { get; set; }


        public Aluno()
        {

        }
        public void AdicionarAluno() // metodo para adicionar o aluno
        {


            Console.WriteLine("Qual o nome do(a) aluno(a): ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || string.IsNullOrEmpty(Nome) || (Nome.Length < 3)) // validando o sexo do aluno atraves de um metodo, so pode ser letras e ter mais de tres caracteres, não pode ser nulo ou vazio
            {
                Console.WriteLine("Invalido! Qual o nome do(a) aluno?");
                Nome = Console.ReadLine();
            }

            Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'Feminino' ou 'Masculino': ");
            Sexo = Console.ReadLine();

            while (Sexo != "Feminino" && Sexo != "Masculino" || string.IsNullOrEmpty(Sexo)) //validando o sexo do aluno que só tem duas opções: Femenino ou Masculino
            {
                Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'Feminino' ou 'Masculino': ");
                Sexo = Console.ReadLine();
            }


            Console.WriteLine($"Qual a idade do(a) {Nome}: ");
            string idadeAux = Console.ReadLine();
            uint idade;

            while (!uint.TryParse(idadeAux, out idade) || (idade == 0))                       //validando se a idade do aluno é maior que zero e se é um número
            {
                Console.WriteLine("Invalido! Qual o número de alunos você deseja inserir? ");
                idadeAux = Console.ReadLine();
            }
            Idade = idade;

            Console.WriteLine($"{Nome} é bolsista: \n Responda com 'Sim' ou 'Não': ");

            string resp = Console.ReadLine();
            bool bolsista = false;

            while (resp != "Sim" && resp != "Não") //validar se é bolsista, só aceita Sim ou Não, não pode ser nulo
            {
                Console.WriteLine($"Invalido! {Nome} é bolsista: ");
                resp = Console.ReadLine();
            }
            if (resp == "Sim")
                bolsista = true;

            Bolsista = bolsista;
            if (resp == "Sim")          //operação para dar resposta sobre a bolsa
                RespBolsista = "é";
            if (resp == "Não")
                RespBolsista = "não é";



            Random rnd = new Random();
            NumeroMatricula = rnd.Next(0, 999999); // gerar número aleatorio 



            Console.WriteLine();
        }
    }
}