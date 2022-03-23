using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trucks.Domain.Entities;

namespace Trucks.Repository.Mappings
{
    public class TruckModelConfigurations : IEntityTypeConfiguration<TruckModel>
    {
        public void Configure(EntityTypeBuilder<TruckModel> builder)
        {
            builder.ToTable("TB_TRUCK_MODEL");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID").HasColumnType("int").IsRequired();
            builder.Property(p => p.Name).HasColumnName("NAME").HasColumnType("varchar(50)").IsRequired();
        }
    }
}