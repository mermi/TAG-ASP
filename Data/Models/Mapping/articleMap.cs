using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class articleMap : EntityTypeConfiguration<article>
    {
        public articleMap()
        {
            // Primary Key
            this.HasKey(t => t.id_article);

            // Properties
            this.Property(t => t.text)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.video)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("article", "vgta");
            this.Property(t => t.id_article).HasColumnName("id_article");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.pubDate).HasColumnName("pubDate");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.video).HasColumnName("video");
            this.Property(t => t.teamMedia).HasColumnName("teamMedia");

            // Relationships
            this.HasOptional(t => t.team)
                .WithMany(t => t.articles)
                .HasForeignKey(d => d.teamMedia);

        }
    }
}
