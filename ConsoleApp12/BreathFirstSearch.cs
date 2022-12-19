using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class BreathFirstSearch
    {
        
        List<Insan> bfslist = new List<Insan>();
        List<Insan> uveykardesler = new List<Insan>();
        public void Search(List<Insan> insanlar, int start)
        {
            
            for (int i = 0; i < insanlar.Count; i++)
            {
                if (insanlar[i].bfskont == 0 && IsAdjacent(start, i))
                {
                    insanlar[i].bfskont = 1;
                    // Console.WriteLine(insanlar[i].isim);
                    bfslist.Add(insanlar[i]);
                    Search(insanlar, i);
                    if(i == insanlar.Count - 1)
                    {
                        ArrayList s = new ArrayList();
                        //Console.WriteLine("siralanmadan once: ");
                        for (int j = 0; j < uveykardesler.Count; j++)
                        {
                            s.Add(uveykardesler[j].isim);
                            Console.WriteLine(s[j]);
                        }

                        s.Sort();

                        Console.WriteLine("alfabetik siraya göre uvey kardesler:");
                        foreach (var k in s)
                        {
                            Console.WriteLine(k);
                        }
                    }
                }
                insanlar[start].bfskont = 1;
            }
            
            foreach(var b in bfslist)
            {
                Console.WriteLine(b.isim);
            }
            for (int i = 0; i < bfslist.Count; i++)
            {
                if (bfslist[i].Anne != null)
                {
                    string a = bfslist[i].Anne.es;
                    string b = bfslist[i].babaad;
                    
                    if (a.Contains(b) != true  && uveykardesler.Contains(bfslist[i]) != true)
                    {
                    uveykardesler.Add(bfslist[i]);

                    }
                }
                if (bfslist[i].Baba != null)
                {
                    
                    string c = bfslist[i].Baba.es;
                    string d = bfslist[i].annead;
                    if (c.Contains(d) != true && uveykardesler.Contains(bfslist[i]) != true)
                    {
                        uveykardesler.Add(bfslist[i]);

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

