using System;
using System.Collections.ObjectModel;
using OnlineStoreApp.Models; 

namespace OnlineStoreApp.ViewModels
{
    public class DetailViewModel
    {
        public ObservableCollection<Products> products { get; set; }

        public DetailViewModel() 
        {
            products = new ObservableCollection<Products>
            {
                new Products { Picture = "Clock" },
                new Products { Picture = "Bags" },
                new Products { Picture = "Car" }
            };
        }
    }
}
