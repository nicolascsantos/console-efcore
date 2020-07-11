using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Monster.Models
{
    public class Pessoa
    {
        [Key]
        public int ID_PESSOA { get; set; }

        [Required]
        public string NOME_PESSOA { get; set; }

        [Required]
        public int IDADE_PESSOA { get; set; }

        [Required]
        public DateTime DATA_CRIADA { get; set; }
    }
}
