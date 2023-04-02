using SklepInternetowy.Models;


namespace SklepInternetowy.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        public static readonly List<Item> _items = new List<Item>()
        {
            new(1,"Samsung","Jakiś opis","czarny","samsung.jpg",20,2299.99M,1)
        };

        public List<Item> getAll()
        {
            return _items.ToList();
        }

        public Item GetItem(int id)
        {
            return _items.Find(Item => Item.Id == id);
        }

        public List<Item> getItems(int category)
        {
            return _items.FindAll(Item => Item.Category==category).ToList();
        }

    }
}
