namespace Portfolio.Domain
{   
    public class Graduation
    {       
        public int id { get; set; }
        public string curso { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string universidade { get; set; }
        public string? descricao { get; set; }
        public int id_developer { get; set; }
        public Developer developer { get; set; }
    }
}
