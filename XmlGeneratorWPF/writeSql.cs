
namespace writeInterface
{
    class writeSql : IwriteXMLSQL
    {
        public void Write(security.Config sec)
        {
            using (var ctx = new XmlGeneratorWPF.DBContexts())
            {
                ctx.SecurityRecordings.Add(sec);

                ctx.SaveChanges();
            }
        }

        public void Write(plate.ConfigP plt)
        {
            using (var ctx = new XmlGeneratorWPF.DBContexts())
            {
                ctx.PlateRecognition.Add(plt);

                ctx.SaveChanges();
            }
        }

        public void Write(Topology tpl)
        {
            using (var ctx = new XmlGeneratorWPF.DBContexts())
            {
                ctx.Topology.Add(tpl);

                ctx.SaveChanges();
            }
        }
    }
}
