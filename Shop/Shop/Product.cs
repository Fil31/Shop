using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Shop
{
    public class Product
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>
        {
            new Product { Name = "iPhone 14 pro max", ImageUrl = "https://m.media-amazon.com/images/I/610pghkO81L._AC_SX679_.jpg", Price = 1400 },
            new Product { Name = "iPhone 14", ImageUrl = "https://m.media-amazon.com/images/I/61BGE6iu4AL._AC_SX679_.jpg", Price = 890 },
            new Product { Name = "MacBook Pro 16", ImageUrl = "https://m.media-amazon.com/images/I/61lYIKPieDL._AC_SX679_.jpg", Price = 2300 }
        };
        }
    }
}
