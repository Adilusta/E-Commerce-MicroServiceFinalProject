﻿using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Web.ViewModels
{
    public class ProductViewModel : EditImageViewModel
    {
        public ProductViewModel()
        {
            Count = 1;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        [Range(1, 100)]
        public int Count { get; set; }
    }
}
