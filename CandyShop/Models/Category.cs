﻿using System.Collections.Generic;

namespace CandyShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Candy> Candies{ get; set; }
    }
}
