using System;
using Monster.Repositories;

namespace Monster
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaRepository pessoaRepository = new PessoaRepository();
            Console.WriteLine("Entity Framework - Testes");
            //Console.WriteLine("Digite o seu nome: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite a sua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //pessoaRepository.AddPessoas(nome, idade);

            Console.WriteLine("Deletando um usuário, digite o if:");
            int id = int.Parse(Console.ReadLine());

            pessoaRepository.DeletePessoas(id);

            var pessoas = pessoaRepository.GetPessoas();

            Console.WriteLine(pessoas[0].NOME_PESSOA);
        }
    }
}
