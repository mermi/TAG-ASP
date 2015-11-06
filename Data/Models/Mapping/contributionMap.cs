using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class contributionMap : EntityTypeConfiguration<contribution>
    {
        public contributionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_event, t.id_sponsor });

            // Properties
            this.Property(t => t.id_event)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_sponsor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("contribution", "vgta");
            this.Property(t => t.id_event).HasColumnName("id_event");
            this.Property(t => t.id_sponsor).HasColumnName("id_sponsor");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.description).HasColumnName("description");

            // Relationships
            this.HasRequired(t => t.sponsor)
                .WithMany(t => t.contributions)
                .HasForeignKey(d => d.id_sponsor);
            this.HasRequired(t => t.@event)
                .WithMany(t => t.contributions)
                .HasForeignKey(d => d.id_event);

        }
    }
}
