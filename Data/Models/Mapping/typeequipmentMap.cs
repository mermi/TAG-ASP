using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class typeequipmentMap : EntityTypeConfiguration<typeequipment>
    {
        public typeequipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.typeEq)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("typeequipment", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.typeEq).HasColumnName("typeEq");
        }
    }
}
