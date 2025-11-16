namespace AspProjectManager.Models
{
    public class Project
    {
        public int Id { get; }
        public required string Name { get; set; }

        public Project(string name)
        {
            Name = name;
        }

        
    }
}
