﻿using ETicaret.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretModel.Option
{
   public class Product:CoreEntity
    {
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public string Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public Guid CategoryID { get; set; }
        public Guid AppUserID { get; set; }
        public virtual Category Category { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
    }
}
