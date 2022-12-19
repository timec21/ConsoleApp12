using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Derinlik
    {

        public static List<int> derin = new List<int>();
        public static List<Insan> kkont = new List<Insan>();
        public static int kont = 1;

        public void derinlikbul(Insan a)
        {
            

            for (int j = 0; j < a.Cocuk.Count; j++)
            {
                a.Cocuk[j].derinlik = a.derinlik + 1;
                
                if (a.Cocuk[j].Esi != null)
                    a.Cocuk[j].Esi.derinlik = a.Cocuk[j].derinlik;
                
            }
            
            if(a.Cocuk.Count == 0 && a.Anne != null)
            {
                a.derinlik = a.Anne.derinlik + 1;
            }
            if(a.Cocuk.Count == 0 && a.Baba != null)
            {
                a.derinlik = a.Baba.derinlik + 1;
            }
           
            
            for (int j = 0; j < a.Cocuk.Count; j++)
            {
                derin.Add(a.Cocuk[j].derinlik);
                derinlikbul(a.Cocuk[j]);
            }

            
            



        }
        
        public void derinlikyaz()
        {
            int maxderinlik = derin[0];
            for (int i = 0; i < derin.Count; i++)
            {
                if (derin[i] > maxderinlik)
                {
                    maxderinlik = derin[i];
                }
            }
            Console.WriteLine(maxderinlik);
        }

    }
}

