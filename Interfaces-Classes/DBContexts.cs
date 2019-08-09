using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace XmlGeneratorWPF
{
    public class DBContexts : DbContext
    {
        public DbSet<security.Config> SecurityRecordings { get; set; }
        public DbSet<plate.ConfigP> PlateRecognition { get; set; }
        public DbSet<Topology> Topology { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<security.Config>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<security.ConfigController>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<plate.ConfigP>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<plate.ConfigControllerP>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Topology>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyFloor>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyGroup>()
                     .Property(c => c.Id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDataservers>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDataserversDataserver>()
                     .Property(c => c.Id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyBehaviour>()
                     .Property(c => c.Id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyBehaviourTimeRows>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyBehaviourTimeRowsTimeRow>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyController>()
                     .Property(c => c.Id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyControllerCamera>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyControllerCameraSpace>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyControllerCameraSpaceMapLocation>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDisplay>()
                     .Property(c => c.Id)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDisplayMapLocation>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDisplayZone>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyDisplayZoneZoneMember>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TopologyFileInfo>()
                     .Property(c => c.ID)
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }

}


