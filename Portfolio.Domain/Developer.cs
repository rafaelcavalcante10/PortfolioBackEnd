using System;
using System.Collections.Generic;

namespace Portfolio.Domain
{
    
    public class Developer
    {
        
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
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
        public string cargocompleto { get; set; }
        public IEnumerable<Graduation> graduations { get; set; }
        public IEnumerable<Experience> experiences { get; set; }
    }
}
