using ETicaret.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretModel.Option
{
   public class ImagesForProducts:CoreEntity
    {
        public string ImagePath { get; set; }
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}
