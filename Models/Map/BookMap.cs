using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.Map
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books")
                .HasKey(x => x.Id);
                
            builder.Property(x => x.Id)
                .UseSqlServerIdentityColumn();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);  

            builder.Property(x => x.Active);
        }
    }
}