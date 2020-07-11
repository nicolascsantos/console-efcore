using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
using Monster.Models;

namespace Monster.Data
{
    class ContextoDB : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-319FFHK;Database=Testes;Trusted_Connection=True");
        }
    }
}
