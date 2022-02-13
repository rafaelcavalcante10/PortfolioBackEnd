using System;

namespace Portfolio.Services.ViewModels
{
    public class PortfolioAboutVM
    {
        public int id { get; set; }
        public string sobre { get; set; }
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
        public string telefone { get; set; }
        public string email { get; set; }
        public string site { get; set; }
        public string cidade { get; set; }
        public string resumo { get; set; }
    }
}
