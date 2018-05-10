using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Description).HasMaxLength(255).IsRequired();

            HasMany(x => x.Products)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(false);


        }
    }
}
