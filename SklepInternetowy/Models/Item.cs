namespace SklepInternetowy.Models
{
    public class Item
    {
        public Item(int id, string name, string description, string color, string image, int quantity, decimal price, int category)
        {
            Id = id;
            Name = name;
            Description = description;
            Color = color;
            Image = image;
            Quantity = quantity;
            Price = price;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Category { get; set; }
        
    }
}
