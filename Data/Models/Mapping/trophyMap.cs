using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class trophyMap : EntityTypeConfiguration<trophy>
    {
        public trophyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_event, t.id_gamer });

            // Properties
            this.Property(t => t.id_event)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_gamer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("trophy", "vgta");
            this.Property(t => t.id_event).HasColumnName("id_event");
            this.Property(t => t.id_gamer).HasColumnName("id_gamer");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.rankTrophy).HasColumnName("rankTrophy");

            // Relationships
            this.HasRequired(t => t.@event)
                .WithMany(t => t.trophies)
                .HasForeignKey(d => d.id_event);
            this.HasRequired(t => t.gamer)
                .WithMany(t => t.trophies)
                .HasForeignKey(d => d.id_gamer);

        }
    }
}
