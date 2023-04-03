using SklepInternetowy.Models;

namespace SklepInternetowy.Repositories
{
    public interface IItemsRepository
    {
        List<Item> getAll();
        Item getItem(int id);
        List<Item> getItems(int category);
    }
}
