using ETicaret.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretModel.Option
{
    public class Comment:CoreEntity
    {
        public string Content { get; set; }
        public string Header { get; set; }
        public Guid ProductID { get; set; }
        public Guid AppUserID { get; set; }

        public virtual Product Product { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
