namespace GameStore.Catalog.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
