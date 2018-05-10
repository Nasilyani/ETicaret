using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class DisLikeMap:CoreMap<DisLike>
    {
        public DisLikeMap()
        {
            ToTable("dbo.DisLikes");

            HasRequired(x => x.Product)
                .WithMany(x => x.DisLikes)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);

            HasRequired(x => x.AppUser)
                .WithMany(x => x.DisLikes)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);
        }
    }
}
