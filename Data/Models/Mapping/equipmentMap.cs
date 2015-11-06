using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class equipmentMap : EntityTypeConfiguration<equipment>
    {
        public equipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.id_equipement);

            // Properties
            this.Property(t => t.label)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("equipment", "vgta");
            this.Property(t => t.id_equipement).HasColumnName("id_equipement");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.teamLogistics).HasColumnName("teamLogistics");
            this.Property(t => t.typeEquipment).HasColumnName("typeEquipment");

            // Relationships
            this.HasOptional(t => t.team)
                .WithMany(t => t.equipments)
                .HasForeignKey(d => d.teamLogistics);
            this.HasOptional(t => t.typeequipment1)
                .WithMany(t => t.equipments)
                .HasForeignKey(d => d.typeEquipment);

        }
    }
}
