using Portfolio.Domain;
using System.Collections.Generic;

namespace Portfolio.Services.ViewModels
{
    public class PortfolioResumeVM
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string informacao { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public IList<Graduation> graduations { get; set; }
        public IList<Experience> experiences { get; set; }
    }
}
