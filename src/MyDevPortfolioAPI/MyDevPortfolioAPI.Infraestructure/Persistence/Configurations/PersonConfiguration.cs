using MyDevPortfolioAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyDevPortfolioAPI.Infrastructure.Persistence.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasOne(p => p.DocumentType)
                .WithMany(dt => dt.DocumentTypePersons)
                .HasForeignKey(p => p.DocumentTypeID);
        }
    }
}
