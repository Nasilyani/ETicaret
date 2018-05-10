using ETicaret.Core.Map;
using ETicaretModel.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Map.Option
{
   public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Content).HasMaxLength(50).IsRequired();
            Property(x => x.Header).IsRequired();

            HasRequired(x => x.Product)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);


            HasMany(x => x.TreeComment)
                .WithRequired(x => x.Comment)
                .HasForeignKey(x => x.CommentID)
                .WillCascadeOnDelete(true);
            //yoruma yorum.
            HasRequired(x => x.AppUser)
               .WithMany(x => x.Comments)
               .HasForeignKey(x => x.AppUserID)
               .WillCascadeOnDelete(true);

        }
    }
}
