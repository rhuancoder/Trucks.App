using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trucks.Domain.Entities;

namespace Trucks.Repository.Mappings
{
    public class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder.ToTable("TB_TRUCK");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(p => p.Name).HasColumnName("NAME").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Color).HasColumnName("COLOR").HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.IdTruckModel).HasColumnName("ID_TRUCK_MODEL").HasColumnType("INTEGER").IsRequired();
            builder.Property(p => p.ManufactureYear).HasColumnName("MANUFACTURE_YEAR").HasColumnType("INTEGER").IsRequired();
            builder.Property(p => p.ModelYear).HasColumnName("MODEL_YEAR").HasColumnType("INTEGER").IsRequired();
            builder.Property(p => p.CreatedDate).HasColumnName("CREATED_DATE").HasColumnType("DATETIME").IsRequired();
            builder.Property(p => p.UpdatedDate).HasColumnName("UPDATED_DATE").HasColumnType("DATETIME");

            builder.HasOne(p => p.TruckModel).WithMany(p => p.Trucks).HasForeignKey(p => p.IdTruckModel).HasConstraintName("FK_TRUCK_TRUCK_MODEL");
        }
    }
}