namespace SklepInternetowy.Models
{
    public class Item
    {
        public Item(int id, string name, string description, string image, int quantity, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Quantity = quantity;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public enum color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White
        }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
    }
}
