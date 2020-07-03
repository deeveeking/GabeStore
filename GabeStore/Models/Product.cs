﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabeStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImportPrice { get; set; }
        public int GameCategoryId { get; set; }
        public Category Category { get; set; }
        public int DeveloperCopanyId { get; set; }
        public Developer Developer { get; set; }
        public string RealeseDate { get; set; }



    }
}
