using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class administratorMap : EntityTypeConfiguration<administrator>
    {
        public administratorMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.username)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("administrator", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
