using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class teamMap : EntityTypeConfiguration<team>
    {
        public teamMap()
        {
            // Primary Key
            this.HasKey(t => t.id_team);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("team", "vgta");
            this.Property(t => t.id_team).HasColumnName("id_team");
            this.Property(t => t.max_members).HasColumnName("max_members");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
