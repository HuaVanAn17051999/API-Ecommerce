﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { set; get; }
        public int Stock { get; set; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Caption { set; get; }
        public string SeoTitle { set; get; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }
        public long ImageSize { get; set; }
        public Categories Categories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
