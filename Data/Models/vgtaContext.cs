using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

namespace Data.Models
{
    public partial class vgtaContext : DbContext
    {
        static vgtaContext()
        {
            Database.SetInitializer<vgtaContext>(null);
        }

        public vgtaContext()
            : base("Name=vgtaContext")
        {
        }

        public DbSet<administrator> administrators { get; set; }
        public DbSet<article> articles { get; set; }
        public DbSet<categoryforum> categoryforums { get; set; }
        public DbSet<contribution> contributions { get; set; }
        public DbSet<equipment> equipments { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<gamer> gamers { get; set; }
        public DbSet<publication> publications { get; set; }
        public DbSet<sponsor> sponsors { get; set; }
        public DbSet<subject> subjects { get; set; }
        public DbSet<team> teams { get; set; }
        public DbSet<trophy> trophies { get; set; }
        public DbSet<typeequipment> typeequipments { get; set; }
        public DbSet<vote> votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new administratorMap());
            modelBuilder.Configurations.Add(new articleMap());
            modelBuilder.Configurations.Add(new categoryforumMap());
            modelBuilder.Configurations.Add(new contributionMap());
            modelBuilder.Configurations.Add(new equipmentMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new gamerMap());
            modelBuilder.Configurations.Add(new publicationMap());
            modelBuilder.Configurations.Add(new sponsorMap());
            modelBuilder.Configurations.Add(new subjectMap());
            modelBuilder.Configurations.Add(new teamMap());
            modelBuilder.Configurations.Add(new trophyMap());
            modelBuilder.Configurations.Add(new typeequipmentMap());
            modelBuilder.Configurations.Add(new voteMap());
        }
    }
}
