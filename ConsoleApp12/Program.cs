using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Data.OleDb;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    internal class Program
    {
         public static void yaz(List<Insan> insanlar)
          { 
              for (int i = 2; i < insanlar.Count; i++)
              {
                  if (true)
                  {
                      Console.WriteLine(insanlar[i].isim);
                      if (insanlar[i].Anne != null)
                      {
                          Console.WriteLine(insanlar[i].Anne.isim + "........."); 

                      }
                      if (insanlar[i].Baba != null)
                      {
                          Console.WriteLine(insanlar[i].Baba.isim + "*******");

                      }

                  }
              }

          } 

        

        static void Main(string[] args)
        {

            OleDbConnection con;
            OleDbCommand cmd;
            OleDbCommand cmd2;
            OleDbCommand cmd3;
            OleDbCommand cmd4;
            OleDbDataReader dr;

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Ece\Downloads\Test Dosyası.csv""; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            cmd = new OleDbCommand("SELECT *FROM [Sayfa1$]", con);
            cmd2 = new OleDbCommand("SELECT *FROM [Sayfa2$]", con);
            cmd3 = new OleDbCommand("SELECT *FROM [Sayfa3$]", con);
            cmd4 = new OleDbCommand("SELECT *FROM [Sayfa4$]", con);


            Insan insan = new Insan();

            con.Open();

            List<Insan> insanlar = new List<Insan>();
            List<Int32> idlist = new List<Int32>();

            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Insan insans = new Insan();
                if (idlist.Contains(insans.id) == false)
                {

                    insanlar.Add(insans);
                }


                insans.id = Int32.Parse(dr["id"].ToString());
                insans.isim = dr["İsim"].ToString();
                insans.soyisim = dr["Soyisim"].ToString();
                insans.dg = dr["Doğum Tarihi"].ToString();
                insans.es = dr["Eşi"].ToString();
                insans.annead = dr["Anne Adı"].ToString();
                insans.babaad = dr["Baba Adı"].ToString();
                insans.kang = dr["Kan Grubu"].ToString();
                insans.meslek = dr["Meslek"].ToString();
                insans.medenihal = dr["Medeni Hali"].ToString();
                insans.kizliksi = dr["Kızlık Soyismi"].ToString();
                insans.cinsiyet = dr["Cinsiyet"].ToString();
                if (String.Equals(insans.cinsiyet, "Erkek") || String.Equals(insans.cinsiyet, "Kadın") && String.Equals(insans.medenihal, "Bekar"))
                {
                    insans.kizliksi = "-";
                }

                idlist.Add(insans.id);



              

            }
            //  Console.WriteLine("2. sayfa");
            dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                Insan insans = new Insan();


                insans.id = Int32.Parse(dr["id"].ToString());
                insans.isim = dr["İsim"].ToString();
                insans.soyisim = dr["Soyisim"].ToString();
                insans.dg = dr["Doğum Tarihi"].ToString();
                insans.es = dr["Eşi"].ToString();
                insans.annead = dr["Anne Adı"].ToString();
                insans.babaad = dr["Baba Adı"].ToString();
                insans.kang = dr["Kan Grubu"].ToString();
                insans.meslek = dr["Meslek"].ToString();
                insans.medenihal = dr["Medeni Hali"].ToString();
                insans.kizliksi = dr["Kızlık Soyismi"].ToString();
                insans.cinsiyet = dr["Cinsiyet"].ToString();
                if (String.Equals(insans.cinsiyet, "Erkek") || String.Equals(insans.cinsiyet, "Kadın") && String.Equals(insans.medenihal, "Bekar"))
                {
                    insans.kizliksi = "-";
                }



                if (idlist.Contains(insans.id) == false)
                {
                    //     Console.WriteLine(insans.id);

                    insanlar.Add(insans); 
                }
              
                idlist.Add(insans.id);

                
                

            }
        
            dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                Insan insans = new Insan();


                insans.id = Int32.Parse(dr["id"].ToString());
                insans.isim = dr["İsim"].ToString();
                if (String.Equals(insans.isim, "Ahmet")==true)
                    {
                    insans.dg = dr["Doğum Tarihi"].ToString();
                    }
                insans.soyisim = dr["Soyisim"].ToString();
                insans.dg = dr["Doğum Tarihi"].ToString();
                insans.es = dr["Eşi"].ToString();
                insans.annead = dr["Anne Adı"].ToString();
                insans.babaad = dr["Baba Adı"].ToString();
                insans.kang = dr["Kan Grubu"].ToString();
                insans.meslek = dr["Meslek"].ToString();
                insans.medenihal = dr["Medeni Hali"].ToString();
                insans.kizliksi = dr["Kızlık Soyismi"].ToString();
                insans.cinsiyet = dr["Cinsiyet"].ToString();
                if (String.Equals(insans.cinsiyet, "Erkek") || String.Equals(insans.cinsiyet, "Kadın") && String.Equals(insans.medenihal, "Bekar"))
                {
                    insans.kizliksi = "-";
                }



                if (idlist.Contains(insans.id) == false)
                {
                    //     Console.WriteLine(insans.id);

                    insanlar.Add(insans);
                }
                else
                {
                    //       Console.WriteLine("bu kisi eklidir");
                }
                idlist.Add(insans.id);



             

            }
            //  Console.WriteLine("4. sayfa");
            dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                Insan insans = new Insan();


                insans.id = Int32.Parse(dr["id"].ToString());
                insans.isim = dr["İsim"].ToString();
                insans.soyisim = dr["Soyisim"].ToString();
                insans.dg = dr["Doğum Tarihi"].ToString();
                insans.es = dr["Eşi"].ToString();
                insans.annead = dr["Anne Adı"].ToString();
                insans.babaad = dr["Baba Adı"].ToString();
                insans.kang = dr["Kan Grubu"].ToString();
                insans.meslek = dr["Meslek"].ToString();
                insans.medenihal = dr["Medeni Hali"].ToString();
                insans.kizliksi = dr["Kızlık Soyismi"].ToString();
                insans.cinsiyet = dr["Cinsiyet"].ToString();
                if (String.Equals(insans.cinsiyet, "Erkek") || String.Equals(insans.cinsiyet, "Kadın") && String.Equals(insans.medenihal, "Bekar"))
                {
                    insans.kizliksi = "-";
                }



                if (idlist.Contains(insans.id) == false)
                {
                    // Console.WriteLine(insans.id);

                    insanlar.Add(insans);
                }
                else
                {
                    //  Console.WriteLine("bu kisi eklidir");
                }
                idlist.Add(insans.id);


  

            }

            con.Close();

            Console.WriteLine("insan listesi: ");
            foreach (var Insan in insanlar)
            {
                Console.WriteLine(Insan.isim + " " + Insan.dg);

            }

            List<Insan> cocuk = new List<Insan>();
            List<Insan> cocukyok = new List<Insan>();
            for (int i = 0; i < insanlar.Count; i++)
            {
                int s = 0;
                
                for (int j = 0; j < insanlar.Count; j++)
                {
                    String cins = insanlar[i].cinsiyet;
                    if (String.Equals(cins, "Kadın"))
                    {
                        String anne = insanlar[i].isim;
                        String esi = insanlar[i].es;
                        String cocukmu = insanlar[j].annead;
                        String baba = insanlar[j].babaad;

                        if (String.Equals(anne, cocukmu) && esi.Contains(baba))
                        {
                            s++;
                            insanlar[j].Anne = insanlar[i];
                            insanlar[i].Cocuk.Add(insanlar[j]);
                            if (insanlar[j].Baba != null)
                            {
                                insanlar[i].Esi = insanlar[j].Baba;
                                insanlar[j].Baba.Esi = insanlar[i];
                            }
                            
                            


                        }
                    }
                    if (String.Equals(cins, "Erkek"))
                    {
                        String baba = insanlar[i].isim;
                        String esi = insanlar[i].es;
                        String cocukmu = insanlar[j].babaad;
                        String anne = insanlar[j].annead;
                        if (String.Equals(baba, cocukmu) && esi.Contains(anne))
                        {
                            s++;
                            insanlar[j].Baba = insanlar[i];
                            insanlar[i].Cocuk.Add(insanlar[j]);
                            if (insanlar[j].Anne != null)
                            {
                                insanlar[i].Esi = insanlar[j].Anne;
                                insanlar[j].Anne.Esi = insanlar[i]; 

                            }
                            
                            
                        }
                        
                    }
                }
               
                if (s == 0) 
                {
                    //Console.WriteLine(insanlar[i].isim + "  cocugu yoktur"); 
                    cocukyok.Add(insanlar[i]); 
                }
            }

            for (int k = 0; k < insanlar.Count; k++)
            {
                string s = insanlar[k].dg;
                int say = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.')
                    {
                        say++;
                        //Console.WriteLine(say);
                        if (say == 2)
                        {
                            String a = s.Substring(i + 1);
                            String b = a.Substring(0, 4);
                            // Console.WriteLine(b);
                            int c = Convert.ToInt32(b);

                            insanlar[k].yas = 2022 - c;


                        }
                    }
                }

            }
            /*for(int i=0; i<insanlar.Count; i++)
            {
                Console.Write(insanlar[i].isim);
                Console.WriteLine(insanlar[i].yas);
            }*/
            // Console.WriteLine("cocuk listesi: ");
            foreach (var cocukl in cocuk)
            {
                //Console.WriteLine(cocukl.isim + " " + cocukl.soyisim);
            }
            foreach (int biid in idlist)
            {
                // Console.WriteLine(biid);
            }

            Console.WriteLine();
            Console.WriteLine("Cocugu olmayan dugumler: ");
            foreach (var cocuky in cocukyok)
            {
                Console.WriteLine(cocuky.isim);
            }

            Console.WriteLine();
            List<Insan> aynikan = new List<Insan>();
            Console.WriteLine("Aynı kan grubuna sahip kisiler:");
            for (int i = 0; i < insanlar.Count; i++)
            {
                if (insanlar[i].kang == "A(+)" || insanlar[i].kang == "A(-)")
                {
                    aynikan.Add(insanlar[i]);
                }
            }
            foreach (var insanc in aynikan)
            {
                Console.WriteLine(insanc.isim + " " + insanc.soyisim + " " + insanc.kang);
            }
            Console.WriteLine();

            for (int k = 0; k < cocukyok.Count; k++)
            {
                string s = cocukyok[k].dg;
                int say = 0;
                if (String.Equals(cocukyok[k].isim, "Almila") == true || String.Equals(cocukyok[k].isim, "Furkan") == true)
                {
                    //Console.WriteLine(cocukyok[k].dg);
                    //Console.WriteLine(cocukyok[k].isim);


                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.')
                    {
                        say++;
                        //Console.WriteLine(say);
                        if (say == 2)
                        {
                            String a = s.Substring(i + 1);
                            String b = a.Substring(0, 4);
                            // Console.WriteLine(b);
                            int c = Convert.ToInt32(b);
                            // Console.WriteLine(c);
                            cocukyok[k].yas = 2022 - c;
                           // Console.WriteLine(cocukyok[k].isim + " " + cocukyok[k].yas + " yasindadir");

                        }
                    }
                }
            }

            List<Insan> siralicocuksuz = new List<Insan>();

            for (int i = 0; i < cocukyok.Count; i++)
            {
                for (int j = 0; j < cocukyok.Count - 1; j++)
                {
                    if (cocukyok[j].yas > cocukyok[j + 1].yas)
                    {
                        Insan temp = new Insan();
                        temp = cocukyok[j];
                        cocukyok[j] = cocukyok[j + 1];
                        cocukyok[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Yaslara gore siralanmis cocuksuz dugumler: ");
            foreach (var cocuky in cocukyok)
            {
                Console.WriteLine(cocuky.isim);
                //Console.WriteLine(cocuky.yas);

            }

            yaz(insanlar);
            Agac agac = new Agac();
            Console.WriteLine("agac ekleme fonskiyonu:");
            agac.agacaekle(insanlar);
            Console.WriteLine("----------------------------------------");
            //DepthFirstSearch arama = new DepthFirstSearch();
            //arama.Search(insanlar,0);
            Ayniisim isim = new Ayniisim(); 
            Console.WriteLine("isim fonskiyonu:");
            isim.AyniIsim(insanlar, 0);
            Console.WriteLine("----------------------------------------");
            BreathFirstSearch arama2 = new BreathFirstSearch();
           // bfskont f = new bfskont();
            Console.WriteLine("bfs fonksiyonu:");
              arama2.Search(insanlar, 0);
           // f.Search(insanlar, 0);
            Console.WriteLine("----------------------------------------");
           
            Derinlik derin = new Derinlik();
            Console.WriteLine("derinlik fonskiyonu:");
            
            for (int i = 0; i < insanlar.Count; i++)
            {
                Insan a = new Insan();
                a = insanlar[i]; 
                derin.derinlikbul(a);
                //Console.Write(a.isim);
                //Console.Write(" ");
                //Console.Write(a.soyisim);
                //Console.Write(" ");
                //Console.WriteLine(a.derinlik); 

            }
            Console.WriteLine("max derinlik: ");
            derin.derinlikyaz();
            AyniMeslek meslek = new AyniMeslek();
            Console.WriteLine("meslek fonskiyonu:"); 
           
           for (int i = 0; i < insanlar.Count; i++)
            {
                Insan x = new Insan();
                x = insanlar[i];
                meslek.aynimeslek(x);
                if (insanlar[i].Anne == null && insanlar[i].Baba == null)
                {
          //          Console.WriteLine(meslek.meslek_list);
                }
            } 
           

            Console.WriteLine("derinligini ogrenmek istediginiz kisiyi giriniz: ");
            String derogren = Console.ReadLine();
            isimdensonrakinesil nesil = new isimdensonrakinesil();
            nesil.nesilbul(insanlar,derogren);
            nesil.nesilyaz();

            Console.WriteLine("yakinligina bakacaginiz iki kisiyi giriniz:");
            string k1 = Console.ReadLine();
            string k2 = Console.ReadLine();
            //yakinlikderecesi yk = new yakinlikderecesi();
            //yk.yakinlik(k1, k2, insanlar);

            Console.Read();
        }
    }
}
