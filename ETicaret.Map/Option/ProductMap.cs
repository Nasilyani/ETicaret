using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbp.Products");
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.UnitsInStock).IsRequired();
            Property(x => x.ImagePath).HasColumnName("FotoYolu").IsRequired();
            Property(x => x.Quantity).IsOptional();

            HasMany(x => x.Comments)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);

            HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.AppUser)
              .WithMany(x => x.Products)
              .HasForeignKey(x => x.AppUserID)
              .WillCascadeOnDelete(true);

            HasMany(x => x.Likes)
               .WithRequired(x => x.Product)
               .HasForeignKey(x => x.ProductID)
               .WillCascadeOnDelete(true);

        }
    }
}
