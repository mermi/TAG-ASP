using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class publicationMap : EntityTypeConfiguration<publication>
    {
        public publicationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_gamer, t.id_subject });

            // Properties
            this.Property(t => t.id_gamer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_subject)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("publication", "vgta");
            this.Property(t => t.id_gamer).HasColumnName("id_gamer");
            this.Property(t => t.id_subject).HasColumnName("id_subject");
            this.Property(t => t.label).HasColumnName("label");

            // Relationships
            this.HasRequired(t => t.gamer)
                .WithMany(t => t.publications)
                .HasForeignKey(d => d.id_gamer);
            this.HasRequired(t => t.subject)
                .WithMany(t => t.publications)
                .HasForeignKey(d => d.id_subject);

        }
    }
}
