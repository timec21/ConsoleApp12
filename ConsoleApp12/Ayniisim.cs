using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Ayniisim
    {
        public List<Insan> isimbul = new List<Insan>(); 
        public List<Insan> ayniism = new List<Insan>(); 

        public void AyniIsim(List<Insan> insanlar, int start)
        {
           
            insanlar[start].bfskont = 1;
            for (int i = 0; i < insanlar.Count; i++)
            {
                if (insanlar[i].bfskont == 0 && IsAdjacent(start, i))
                {
                    insanlar[i].bfskont = 1;
                    isimbul.Add(insanlar[i]);
                //    Console.WriteLine(insanlar[i].isim);
                    AyniIsim(insanlar, i);
                }
            }
           
                 for(int k=0; k<isimbul.Count; k++)
                 {
               
                 for(int j=k+1; j<isimbul.Count; j++)
                   {
                    //Console.WriteLine(isimbul[k].isim);
                    //Console.WriteLine(isimbul[j].isim);
                    if (String.Equals(isimbul[k].isim, isimbul[j].isim) == true && isimbul[k].id != isimbul[j].id && ayniism.Contains(isimbul[k])==false && ayniism.Contains(isimbul[j])==false)
                    {
                        Console.Write(isimbul[k].isim);
                        Console.Write(isimbul[k].soyisim);
                        Console.WriteLine(isimbul[k].yas);
                        Console.Write(isimbul[j].isim);
                        Console.Write(isimbul[j].soyisim);
                        Console.WriteLine(isimbul[j].yas);
                        ayniism.Add(isimbul[k]);
                        ayniism.Add(isimbul[j]);

                    }
                   }
     
                 }


        }

        public bool IsAdjacent(int start, int target)
        {
            return (start + 1 == target || start - 1 == target);
        }

       


    }
}

