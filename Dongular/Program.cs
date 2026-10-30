using System;

class Menu
{
    static void Main()
    {
          int Bakiye=1000;
          int secim=0;

         Console.Write("==HOŞGELDİNİZ==");

           while (secim!=4)
           {
            Console.WriteLine("\nHANGİ İŞLEMİ YAPMAK İSTERSİNİZ");
            Console.WriteLine("1 - Bakiye görüntüle");
            Console.WriteLine("2 - Para yatır");
            Console.WriteLine("3 - Para çek");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Seçiniz: ");
            secim = Convert.ToInt32(Console.ReadLine());


            
             if (secim==1)
               {
                 Console.Write($"Bakiyeniz :{Bakiye} ");

               }
             else if (secim==2)

               {
                Console.Write("NE KADAR YATIRMAK İSTİYORSUN ");
                int yatir=Convert.ToInt32(Console.ReadLine());

                while (yatir>5000)
                {
                 Console.WriteLine("En Fazla 5000 TL Yatırabilirsin");
                 Console.Write("Lütfen tekrar girin: ");
                 yatir = Convert.ToInt32(Console.ReadLine());

                }
                Bakiye+=yatir;
                Console.WriteLine($"Para eklendi. Güncel bakiyeniz: {Bakiye} TL");
                }
              
               
               else if (secim==3 )
        {
          Console.Write("Ne kadar para çekmek istiyorsun:");
          int cekmek=Convert.ToInt32(Console.Read());
           
           while (cekmek>Bakiye)
          {
            Console.Write($"En fazla {Bakiye} bu kadar para çekebilirsiniz ");
            Console.Write("Lütfen tekrar giriniz");
            cekmek = Convert.ToInt32(Console.ReadLine());

          }
         Bakiye-=cekmek;
          Console.WriteLine($"Güncel bakiyeniz : {Bakiye}");
        }
         
         
          else if (secim==4)
      {
        Console.Write("iyi günler !");



      } 
       else
      {
        Console.WriteLine("yanlış veya hatalı tuşlama yaptınız lütfen 1 ile 4 arasında bir sayı girniz  ");
      }

               }




           }
 }
