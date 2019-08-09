using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeInterface
{
    interface IwriteXMLSQL
    {
        void Write(security.Config sec);
        void Write(plate.ConfigP plt);
        void Write(Topology tpl);
    }
}
