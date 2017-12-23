using ETicaret.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretModel.Option
{
   public class Order:CoreEntity
    {
        public DateTime? OrderDate { get; set; }
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
