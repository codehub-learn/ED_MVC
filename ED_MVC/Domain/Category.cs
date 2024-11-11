namespace ED_MVC.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageLoc { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
