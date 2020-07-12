using System;
using Monster.Repositories;

namespace Monster
{
    class Program
    {
        public static string nome;
        public static int idade;

        static void Main(string[] args)
        {
            PessoaRepository pessoaRepository = new PessoaRepository();
            Console.WriteLine("Entity Framework - Testes");


            Console.WriteLine("Digite a operação desejada: \n1 - Listar Pessoas \n2 - Editar Pessoa \n3 - Adicionar Pessoa \n4 - Deletar Pessoa");
            int tipos = int.Parse(Console.ReadLine());

            switch (tipos)
            {
                case 1:
                    var pessoas = pessoaRepository.GetPessoas();

                    foreach (var person in pessoas)
                    {
                        Console.WriteLine($"O nome é: {person.NOME_PESSOA} e a idade: {person.IDADE_PESSOA}");
                    }
                    break;

                case 2:
                    Console.WriteLine("-- Editar Pessoa -- ");

                    Console.WriteLine("Digite o nome desejado (opcional): ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade desejada: ");
                    idade = int.Parse(Console.ReadLine());

                    pessoaRepository.EditPessoas(2, nome, idade);
                    break;
                case 3:
                    Console.WriteLine("-- Adicionar pessoa --");

                    Console.WriteLine("Digite o nome da pessoa: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade da pessoa: ");
                    idade = int.Parse(Console.ReadLine());

                    pessoaRepository.AddPessoas(nome, idade);
                    break;
                default:
                    break;
            }
        }
    }
}
