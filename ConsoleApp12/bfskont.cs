using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class bfskont
    {
       
        

            public void Search(List<Insan> insanlar, int start)
            {
                
                for (int i = 0; i < insanlar.Count; i++)
                {
                    if (insanlar[i].dfskont == 0 && IsAdjacent(start, i))
                    {
                        insanlar[i].dfskont = 1;
                        Console.WriteLine(insanlar[i].isim);
                        Search(insanlar, i);
                    }
                }
            insanlar[start].dfskont = 1;


        }

            public bool IsAdjacent(int start, int target)
            {
                return (start + 1 == target || start - 1 == target);
            }


        
    }
}
