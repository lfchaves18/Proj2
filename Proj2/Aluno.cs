﻿using System;
using System.Collections.Generic;

namespace Proj2
{
    class Aluno : Pessoa // recebe a herança de pessoa
    {
        public bool Bolsista { get; set; } // atributo para ver se o aluno é bolsista
        public int NumeroMatricula { get; set; } // atributo para o número de matricula
        public string RespBolsista { get; set; }


        public void AdicionarAluno() // metodo para adicionar o aluno
        {
            
            //----------------Inserir o nome do aluno------------------
            Console.WriteLine("Qual o nome do(a) aluno(a): ");
            Nome = Console.ReadLine();
            while ((!ValidarPalavras(Nome)) || (Nome.Length < 3)) // validando o sexo do aluno atraves de um metodo, so pode ser letras e ter mais de tres caracteres, não pode ser nulo ou vazio
            {
                Console.WriteLine("Invalido! Qual o nome do(a) aluno?");
                Nome = Console.ReadLine();
            }

            //--------------Inserir o sexo do aluno-----------------
            Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M': ");
            Sexo = Console.ReadLine().Trim().ToUpper();
            while (Sexo != "F" && Sexo != "M" || string.IsNullOrEmpty(Sexo)) //validando o sexo do aluno que só tem duas opções: Femenino ou Masculino
            {
                Console.WriteLine($"Qual o sexo do(a) {Nome} \n Responda com 'F' ou 'M': ");
                Sexo = Console.ReadLine().Trim().ToUpper();
            }

            //----------Inserir o sexo do aluno-------------
            Console.WriteLine($"Qual a idade do(a) {Nome}: ");
            uint idade;
            while (!uint.TryParse(Console.ReadLine(), out idade) || (idade == 0))                       //validando se a idade do aluno é maior que zero e se é um número
            Console.WriteLine($"Invalido! Qual a idade do(a) {Nome}: ");
            Idade = idade;

            //--------------Ver se o aluno é bolsista-------------------
            Console.WriteLine($"{Nome} é bolsista: \n Responda com 'S' ou 'N': ");
            string resp = Console.ReadLine().ToUpper().Trim();
            bool bolsista;
            while (resp != "S" && resp != "N") //validar se é bolsista, só aceita Sim ou Não, não pode ser nulo
            {
                Console.WriteLine($"Invalido! {Nome} é bolsista: \n Responda com 'S' ou 'N':  ");
                resp = Console.ReadLine().ToUpper().Trim();
            }
            if (resp == "S") bolsista = true;
            else bolsista = false;

            if (bolsista == true) RespBolsista = "é";
            else if (bolsista == false) RespBolsista = "não é";


            Random rnd = new Random();
            NumeroMatricula = rnd.Next(0, 999999); // gerar número aleatorio 
        }

        public override string ToString() => $"O(a) aluno(a): {Nome}, tem {Idade} anos, seu sexo é {Sexo} e {RespBolsista} bolsista. " +
            $"Seu número de matricula é: {NumeroMatricula}\n";
    }
}