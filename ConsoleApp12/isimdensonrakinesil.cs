using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class isimdensonrakinesil
    {
        public int kacnesilsonuc;
        private List<Insan> annelist = new List<Insan>();
        public int sonnesil;
        public void nesilbul(List<Insan> insanlar,string derogren)
        {
            int i;
            Insan a = new Insan();
            for(i=0; i<insanlar.Count; i++)
            {
                if (String.Equals(insanlar[i].isim,derogren))
                {
                    a = insanlar[i];
                    break;
                }
            }

            kacnesil(a);


        }
        public int nesil = 0;
        private List<int> nesillist = new List<int>();
        
        public int kacnesil(Insan a)
        {
            int cocukv=0;
            for (int j=0; j < a.Cocuk.Count; j++) 
            {
                if (a.Cocuk.Count != 0)
                {
                    if(annelist.Contains(a)==false)
                    {
                        annelist.Add(a);
                        nesil++;
                    }
                     kacnesil(a.Cocuk[j]);
                }
                
            }
       
            
               a.nesil= nesil;
              if(nesillist.Contains(nesil)==false)
              {

                nesillist.Add(nesil);

              }
               
         //   Console.WriteLine(a.isim + nesillist.Count);
            sonnesil = nesillist.Count;
         
            return sonnesil;
           

        }

        public void nesilyaz()
        {
            Console.WriteLine("girilen kisiden sonraki nesil:");
            Console.WriteLine(sonnesil);
        }
        
    }
}
