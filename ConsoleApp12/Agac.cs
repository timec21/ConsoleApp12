using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp12
{
    internal class Agac
    {
        private Insan root;

        public Agac()
        {
            root = null;
        }

        
        public void agacaekle(List<Insan> insanlar)
        {
            Insan newnode = new Insan();
            for (int i = 0; i < insanlar.Count; i++)
                {
                newnode = insanlar[i];
                 if(root == null)
                   {
                root = newnode;
                   }
                 else
                   {
                Insan current = root;
//                Insan parent;

                
                    if (newnode.Cocuk.Count == 0)
                    { 
                       // parent = current;
                        if (newnode.Anne != null && newnode.Baba == null)
                        {
                            if ((newnode.Anne.Cocuk.Count == 1) || (newnode.Anne.Cocuk.Count == 2 && newnode.Anne.Cocuk[1].Cocuk.Count == 0 && newnode.Anne.Cocuk[0].Cocuk.Count == 0) || (newnode.Anne.Cocuk.Count == 3 && newnode.Anne.Cocuk[1].Cocuk.Count == 0 && newnode.Anne.Cocuk[0].Cocuk.Count == 0 && newnode.Anne.Cocuk[2].Cocuk.Count == 0))
                            {
                                Console.Write(newnode.isim);
                                Console.WriteLine(" dengeli");
                                
                            }

                        }
                        if (newnode.Baba != null )
                        {
                            if ((newnode.Baba.Cocuk.Count == 1) || (newnode.Baba.Cocuk.Count == 2 && newnode.Baba.Cocuk[0].Cocuk.Count == 0 && newnode.Baba.Cocuk[1].Cocuk.Count == 0) || (newnode.Baba.Cocuk.Count == 3 && newnode.Baba.Cocuk[0].Cocuk.Count == 0 && newnode.Baba.Cocuk[1].Cocuk.Count == 0 && newnode.Baba.Cocuk[2].Cocuk.Count == 0))
                            {
                                Console.Write(newnode.isim);
                                Console.WriteLine(" dengeli");
                            }

                        }

                    }

                  }
            }
        }
    }   
}

