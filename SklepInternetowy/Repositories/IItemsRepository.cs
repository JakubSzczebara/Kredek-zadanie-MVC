﻿using SklepInternetowy.Models;

namespace SklepInternetowy.Repositories
{
    public interface IItemsRepository
    {
        List<Item> getAll();
        Item GetItem(int id);
        List<Item> getItems(string category);
    }
}
