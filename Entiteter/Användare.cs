using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Användare : Person
    {
        public string AnvändareID { get; set; }
        public  string BetalningsMetod { get; set; }
        public List<Hyra> HyresHistorik { get; set; }


        //public Användare(string användareID,string fullNamn, string lösenOrd, string ePost, string betalningsmetod, List<Hyra> hyresHistorik)
        //{
        //    this.AnvändareID = användareID;
        //    this.FullNamn = fullNamn;
        //    this.Lösenord = lösenOrd;
        //    this.Epost = ePost;
        //    this.BetalningsMetod = betalningsmetod;
        //    this.HyresHistorik = hyresHistorik;
            
            
        //}
    }
}
