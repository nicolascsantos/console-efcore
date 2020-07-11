using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Monster.Models;
using Monster.Data;
using Monster.Repositories.Contracts;

namespace Monster.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        public List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            using (ContextoDB contexto = new ContextoDB())
            {
                pessoas = contexto.Pessoas.ToList();
            }

            return pessoas;
        }

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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensagem de erro: {e}");
                throw;
            }
        }

        public void DeletePessoas(int id)
        {
            try
            {
                using (ContextoDB contexto = new ContextoDB())
                {
                    Pessoa pessoa1 = new Pessoa()
                    {
                        ID_PESSOA = id
                    };
                    contexto.Pessoas.Remove(pessoa1);
                    contexto.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensagem de erro {e.Message}");
                throw;
            }

        }
    }
}
