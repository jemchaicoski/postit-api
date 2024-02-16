using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postit_webapp.Models;

namespace PostitWebAPI.Data.Map
{
    public class PostitMap : IEntityTypeConfiguration<Postit>
    {
        public void Configure(EntityTypeBuilder<Postit> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Text).HasMaxLength(300);
            builder.Property(p => p.CreationDate).IsRequired();
            builder.Property(p => p.IsFinished).IsRequired();
            builder.Property(p => p.IsFavorite).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();
        }
    }
}
