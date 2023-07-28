namespace CrudVillasAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public double Fee { get; set; }
        public DateTime creationDate { get; set; }
    }
}
