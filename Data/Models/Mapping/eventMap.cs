using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.id_event);

            // Properties
            this.Property(t => t.name_event)
                .HasMaxLength(255);

            this.Property(t => t.type_event)
                .HasMaxLength(255);

            this.Property(t => t.adress)
                .HasMaxLength(255);

            this.Property(t => t.city)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("event", "vgta");
            this.Property(t => t.id_event).HasColumnName("id_event");
            this.Property(t => t.date_event).HasColumnName("date_event");
            this.Property(t => t.name_event).HasColumnName("name_event");
            this.Property(t => t.numberOfReservation).HasColumnName("numberOfReservation");
            this.Property(t => t.streaming).HasColumnName("streaming");
            this.Property(t => t.tournament).HasColumnName("tournament");
            this.Property(t => t.type_event).HasColumnName("type_event");
            this.Property(t => t.adress).HasColumnName("adress");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.teamOrganisation).HasColumnName("teamOrganisation");

            // Relationships
            this.HasOptional(t => t.team)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.teamOrganisation);

        }
    }
}
