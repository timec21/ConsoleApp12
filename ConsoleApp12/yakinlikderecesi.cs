using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class yakinlikderecesi
    {
        public List<Insan> dolasma = new List<Insan>(); 
        public void yakinlik(Insan b, Insan k, List<Insan> insanlar) 
        {
            for(int i=0; i<insanlar.Count; i++)
            {
                if (String.Equals(insanlar[i].isim,b.isim))
                {
                    Cocukgez(insanlar[i],k,insanlar);
                    dolasma.Add(insanlar[i]);
                }
            }
            

        }
        public void Cocukgez(Insan b, Insan k, List<Insan> insanlar)
        {
            for(int j=0; j < b.Cocuk.Count; j++)
            {
                if(String.Equals(b.isim,k.isim))
                {
                    if (String.Equals(b.cinsiyet, "Erkek"))
                    {
                        Console.WriteLine("babasi");
                    }
                  
                        
                }
                else
                {
                    dolasma.Add((Insan)b);
                    Cocukgez(b.Cocuk[j], k, insanlar);
                }
                
            }
        }
    }
}
