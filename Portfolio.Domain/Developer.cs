﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Domain
{
    [Table("developer")]
    public class Developer
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public int idade
        {
            get
            {
                var YearsOld = (DateTime.Now.Year - nascimento.Year);
                if (DateTime.Now.Month < nascimento.Month || (DateTime.Now.Month == nascimento.Month && DateTime.Now.Day < nascimento.Day))
                {
                    YearsOld--;
                }
                return (YearsOld < 0) ? 0 : YearsOld;
            }
        }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string site { get; set; }
        public string telefone { get; set; }
        public string sobre { get; set; }
        public string resumo { get; set; }
        public string informacao { get; set; }
        public string cargo { get; set; }

    }
}