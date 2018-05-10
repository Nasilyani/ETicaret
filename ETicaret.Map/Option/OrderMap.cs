using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class OrderMap:CoreMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
            Property(x => x.OrderDate).HasColumnType("datetime2").IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            HasMany(x => x.OrderDetails)
                .WithRequired(x => x.Order)
                .HasForeignKey(x => x.OrderID)
                .WillCascadeOnDelete(true);

        }
    }
}
