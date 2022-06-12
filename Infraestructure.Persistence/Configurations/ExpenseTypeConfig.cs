using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class ExpenseTypeConfig : IEntityTypeConfiguration<Concept>
    {
        public void Configure(EntityTypeBuilder<Concept> builder)
        {
            builder.ToTable("Concepts");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Category)
                .IsRequired();
        }
    }
}
