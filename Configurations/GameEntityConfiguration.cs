using GameShelf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameShelf.Configurations
{
    internal class GameEntityConfiguration : IEntityTypeConfiguration<GameEntity>
    {
        public void Configure(EntityTypeBuilder<GameEntity> builder)
        {
            builder
                .ToTable("Games")
                .HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.Rating).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.Genre).IsRequired();

        }
    }
}
