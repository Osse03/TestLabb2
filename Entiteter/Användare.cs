using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Användare
    {

        public string AnvändareID { get; set; }
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public  string BetalningsMetod { get; set; }
        public List<Hyra> HyresHistorik { get; set; }
    }
}
