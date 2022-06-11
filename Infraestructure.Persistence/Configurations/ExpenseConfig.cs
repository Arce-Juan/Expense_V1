using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    public class ExpenseConfig : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("Expenses");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Amount)
                .IsRequired();

            builder.Property(p => p.Date)
                .IsRequired();

            builder.Property(p => p.Month)
                .IsRequired();
        }
    }
}
