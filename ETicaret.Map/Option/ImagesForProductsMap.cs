using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class ImagesForProductsMap:CoreMap<ImagesForProducts>
    {
        public ImagesForProductsMap()
        {
            ToTable("dbo.ImagesForProducts");

            Property(x => x.ImagePath).IsRequired();

            HasRequired(x => x.Product)
                .WithMany(x => x.ImagesForProducts)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);
        }
    }
}
