using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Insan
    {
        public String isim,soyisim,dg,es,annead,babaad,kang,meslek,medenihal,kizliksi,cinsiyet,cocukad;
        public int id,yas,dfskont,bfskont,mkont,derinlik=1,nesil=0;
           public Insan Anne;
           public Insan Baba;
           public List<Insan> Cocuk = new List<Insan>();
           public Insan Esi;
         
        public Insan() { }
    }
}
