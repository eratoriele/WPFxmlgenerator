using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace writeInterface
{
    public class writeXml : IwriteXMLSQL
    {
        public void Write(security.Config sec)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (StreamWriter sw = File.CreateText(path + "\\config.xml"))
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(security.Config));

                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xsSubmit.Serialize(writer, sec);
                }
            }
        }

        public void Write(plate.ConfigP plt)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (StreamWriter sw = File.CreateText(path + "\\config.xml"))
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(security.Config));

                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xsSubmit.Serialize(writer, plt);
                }
            }
        }

        public void Write(Topology tpl)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (StreamWriter sw = File.CreateText(path + "\\topology.xml"))
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(Topology));

                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xsSubmit.Serialize(writer, tpl);
                }
            }
        }
    }
}
