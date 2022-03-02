using MyApp.Domain.ProductGroups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace  MyApp.Database.Domain.ProductGroups;

internal class ProductGroupEntityTypeConfiguration : IEntityTypeConfiguration<ProductGroup>
{
    public void Configure(EntityTypeBuilder<ProductGroup> builder)
    {
        builder.ToTable("ProductGroups");

        builder.HasKey(productGroup => productGroup.Id);

        builder.Property(productGroup => productGroup.Id)
            .HasColumnName(nameof(ProductGroup.Id))
            .ValueGeneratedOnAdd();

        builder.Property(productGroup => productGroup.Name)
            .HasColumnName(nameof(ProductGroup.Name))
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(productGroup => productGroup.Path)
            .HasColumnName(nameof(ProductGroup.Path))
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(productGroup => productGroup.Discount)
            .HasColumnName(nameof(ProductGroup.Discount))
            .IsRequired();

        builder.Navigation(productGroup => productGroup.Products).UsePropertyAccessMode(PropertyAccessMode.Field);
    }
}