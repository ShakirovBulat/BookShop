using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Models
{
    public class Book
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
