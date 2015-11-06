using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class sponsorMap : EntityTypeConfiguration<sponsor>
    {
        public sponsorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_sponsor);

            // Properties
            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.name_contact_sponsor)
                .HasMaxLength(255);

            this.Property(t => t.name_sponsor)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sponsor", "vgta");
            this.Property(t => t.id_sponsor).HasColumnName("id_sponsor");
            this.Property(t => t.dateEnd).HasColumnName("dateEnd");
            this.Property(t => t.dateStart).HasColumnName("dateStart");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.name_contact_sponsor).HasColumnName("name_contact_sponsor");
            this.Property(t => t.name_sponsor).HasColumnName("name_sponsor");
            this.Property(t => t.teamSponsor).HasColumnName("teamSponsor");

            // Relationships
            this.HasOptional(t => t.team)
                .WithMany(t => t.sponsors)
                .HasForeignKey(d => d.teamSponsor);

        }
    }
}
