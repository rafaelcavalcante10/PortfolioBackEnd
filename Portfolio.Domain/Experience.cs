using System.Collections.Generic;

namespace Portfolio.Domain
{
    public class Experience
    {
        public int id { get; set; }
        public string cargo { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string empresa { get; set; }
        public int id_developer { get; set; }
        public Developer developer { get; set; }
        public IEnumerable<ExperienceDetail> experienceDetails { get; set; }
    }
}
