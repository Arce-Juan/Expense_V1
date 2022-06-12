namespace Core.Domain.Entities
{
    public class Concept
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Category { get; set; }
    }
}
