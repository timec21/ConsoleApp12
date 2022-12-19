using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class AyniMeslek
    {
        public List<string> meslek_list = new List<string>();

        public void aynimeslek(Insan insanlar)
        {
            
            if (String.Equals(insanlar.cinsiyet, "Erkek"))
            {



                for (int j = 0; j < meslek_list.Count; j++)
                {
                    if (String.Equals(meslek_list[j], insanlar.meslek) && insanlar.mkont == 0)
                    {
                        Console.WriteLine(insanlar.isim + " " + insanlar.meslek);

                    }
                }

                for (int j = 0; j < meslek_list.Count; j++)
                {
                    if (String.Equals(meslek_list[j], insanlar.meslek) == true && meslek_list.Contains(insanlar.meslek) != true && insanlar.mkont == 0)
                    {
                        meslek_list.Add(insanlar.meslek);
                        
                    }
                  
                        
                }
                if (insanlar.Anne == null && insanlar.Baba == null)
                {

                    meslek_list.Add(insanlar.meslek);
                }

    
                for (int j = 0; j < insanlar.Cocuk.Count; j++)
                {
                    
                    aynimeslek(insanlar.Cocuk[j]);

                }

                insanlar.mkont = 1;
            }



        }






    }
}