using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.Map
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("Peoples")
                .HasKey(x => x.Id);
                
            builder.Property(x => x.Id)
                .UseSqlServerIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100); 
                
            builder.Property(x => x.Active);     
        }
    }
}