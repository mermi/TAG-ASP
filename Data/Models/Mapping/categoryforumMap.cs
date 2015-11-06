using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class categoryforumMap : EntityTypeConfiguration<categoryforum>
    {
        public categoryforumMap()
        {
            // Primary Key
            this.HasKey(t => t.id_category);

            // Properties
            this.Property(t => t.label)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("categoryforum", "vgta");
            this.Property(t => t.id_category).HasColumnName("id_category");
            this.Property(t => t.label).HasColumnName("label");
        }
    }
}
