using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class voteMap : EntityTypeConfiguration<vote>
    {
        public voteMap()
        {
            // Primary Key
            this.HasKey(t => t.idGamer);

            // Properties
            this.Property(t => t.idGamer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vote", "vgta");
            this.Property(t => t.idGamer).HasColumnName("idGamer");
            this.Property(t => t.number_vote).HasColumnName("number_vote");

            // Relationships
            this.HasRequired(t => t.gamer)
                .WithOptional(t => t.vote);

        }
    }
}
