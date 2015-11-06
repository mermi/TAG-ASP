using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class subjectMap : EntityTypeConfiguration<subject>
    {
        public subjectMap()
        {
            // Primary Key
            this.HasKey(t => t.id_subject);

            // Properties
            this.Property(t => t.message)
                .HasMaxLength(255);

            this.Property(t => t.name_subject)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("subject", "vgta");
            this.Property(t => t.id_subject).HasColumnName("id_subject");
            this.Property(t => t.message).HasColumnName("message");
            this.Property(t => t.name_subject).HasColumnName("name_subject");
            this.Property(t => t.categoryForums).HasColumnName("categoryForums");

            // Relationships
            this.HasOptional(t => t.categoryforum)
                .WithMany(t => t.subjects)
                .HasForeignKey(d => d.categoryForums);

        }
    }
}
