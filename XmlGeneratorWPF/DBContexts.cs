using System.Data.Entity;

namespace XmlGeneratorWPF
{
    class DBContexts : DbContext
    {
        public DbSet<security.Config> SecurityRecordings { get; set; }
        public DbSet<plate.Config2> PlateRecognition { get; set; }
        public DbSet<Topology> Topology { get; set; }
    }
}
