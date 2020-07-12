using System;
using System.Collections.Generic;
using System.Linq;
using Monster.Models;
using Monster.Data;
using Monster.Repositories.Contracts;

namespace Monster.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        /// <summary>
        /// Retorna uma lista de todas as pessoas cadastradas no banco de dados.
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            using (ContextoDB contexto = new ContextoDB())
            {
                pessoas = contexto.Pessoas.ToList();
            }

            return pessoas;
        }

        /// <summary>
        /// Adiciona uma pessoa ao banco de dados.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        public void AddPessoas(string nome, int idade)
        {
            try
            {
                using (ContextoDB contexto = new ContextoDB())
                {
                    Pessoa pessoa1 = new Pessoa()
                    {
                        NOME_PESSOA = nome,
                        IDADE_PESSOA = idade,
                        DATA_CRIADA = DateTime.Now
                    };

                    contexto.Add(pessoa1);
                    contexto.SaveChanges();

                    Console.WriteLine("Pessoa adicionada com sucesso.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensagem de erro: {e}");
                throw;
            }
        }


        /// <summary>
        /// Deleta uma pessoa com o ID 
        /// </summary>
        /// <param name="id"></param>
        public void DeletePessoas(int id)
        {
            try
            {
                using ContextoDB contexto = new ContextoDB();
                Pessoa pessoa1 = new Pessoa()
                {
                    ID_PESSOA = id
                };
                contexto.Pessoas.Remove(pessoa1);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensagem de erro {e.Message}");
                throw;
            }

        }

        /// <summary>
        /// Edita um registro de Pessoa com o ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        public Pessoa EditPessoas(int id, string nome = "", int idade = 0)
        {
            using (ContextoDB contexto = new ContextoDB())
            {
                try
                {
                    var filteredPerson = contexto.Pessoas
                        .Single(i => i.ID_PESSOA == id);

                    if (nome == string.Empty)
                    {
                        filteredPerson.IDADE_PESSOA = idade;
                    }

                    contexto.SaveChanges();

                    Console.WriteLine($"Nome: {filteredPerson.NOME_PESSOA} e idade {filteredPerson.IDADE_PESSOA}");

                    return filteredPerson;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Mensagem de erro: {e.Message}");
                    throw;
                }
            }
        }
    }
}
