using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class Entity
    {
        public class Etkinlik
        {
            public string EID { get; set; }
            public string Adi { get; set; }
            public string Tarih { get; set; }
            public string Yer { get; set; }
            public string Açıklama { get; set; }

           public List<Katılımcı> Katılımcılar = new List<Katılımcı>();

        }

        public class Katılımcı
        {
            
            public string KID { get; set; }
            public string KEID { get; set; }
            public string Adi { get; set; }
            public string Telefon { get; set; }

            

        }
    }
}
