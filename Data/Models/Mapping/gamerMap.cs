using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class gamerMap : EntityTypeConfiguration<gamer>
    {
        public gamerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.pwd)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("gamer", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.age).HasColumnName("age");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.numtel).HasColumnName("numtel");
            this.Property(t => t.pwd).HasColumnName("pwd");
            this.Property(t => t.rank).HasColumnName("rank");
            this.Property(t => t.record).HasColumnName("record");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.team).HasColumnName("team");

            // Relationships
            this.HasOptional(t => t.team1)
                .WithMany(t => t.gamers)
                .HasForeignKey(d => d.team);

        }
    }
}
