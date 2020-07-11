using System;
using System.Collections.Generic;
using System.Text;
using Monster.Models;

namespace Monster.Repositories.Contracts
{
    public interface IPessoaRepository
    {
        public List<Pessoa> GetPessoas();

        public void AddPessoas(string nome, int idade);

        public void DeletePessoas(int id);
    }
}
