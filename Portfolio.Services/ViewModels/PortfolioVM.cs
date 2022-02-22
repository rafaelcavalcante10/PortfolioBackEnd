using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.ViewModels
{
    public class PortfolioVM
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string nascimento { get; set; }
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
        public IEnumerable<GraduationVM> graduations { get; set; }
        public IEnumerable<ExperienceVM> experiences { get; set; }

    }

    public class GraduationVM
    {
        public int id { get; set; }
        public string curso { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string universidade { get; set; }
        public string descricao { get; set; }
        public int id_developer { get; set; }
    }

    public class ExperienceVM
    {
        public int id { get; set; }
        public string cargo { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string empresa { get; set; }
        public int id_developer { get; set; }
        public IEnumerable<ExperienceDetailVM> experienceDetails { get; set; }

    }
    public class ExperienceDetailVM
    {
        public int id { get; set; }
        public int id_experience { get; set; }
        public string detalhe { get; set; }
    }
}
