using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_calculator
{    
    class LensMountTable
    {
        public Dictionary<string, LensMount> Table;
        LensMountTable()
        {
            Table = new Dictionary<string, LensMount>();

            StreamReader vnos = new StreamReader("tabela.jsonc");

            // JsonSerializer.Deserialize(vnos.ReadToEnd());

            // Table["asdpaf"] = new LensMount();
            vnos.Close();
        }
    }
}
