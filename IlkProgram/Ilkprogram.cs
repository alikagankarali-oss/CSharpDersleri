using System;
using System.Collections;
using System.Net.Mail;
class Hesap
{
    static void Main ()

    {
    int bakiye = 1000;
    Console.Write("Bakiye görüntülemek için 1 e basınız\n para çekmek için 2 ye basınız \n para yatırmak için 3 e basınız \n Şeçiniz : ");
     int secim= Convert.ToInt32(Console.ReadLine());
     
     
     switch (secim)
    {
      case 1:
        Console.WriteLine($"Bakiye görüntüleniyor:{bakiye} ");
        break;
      case 2:
        Console.WriteLine($"Ne Kadar para çekmek istiyorsunuz : ");
        int cekmek=Convert.ToInt32(Console.ReadLine());
        if (bakiye>=cekmek)
        {
          bakiye-=cekmek;



        
          Console.Write($"HESABINIZDAN {cekmek}PARA ÇEKİLDE \n KALAN BAKİYENİZ:{bakiye}");
        }
        else
        {
          Console.Write("bakiye yetersiz");
        }
        break;
        case 3:
         Console.Write("NE KADAR PARA YATIRMAK İSTİYORSUNUZ : ");
         int yatırmak=Convert.ToInt32(Console.ReadLine());
         bakiye +=yatırmak;
         Console.WriteLine($"Güncel bakiyeniz : {bakiye}");
         break;
        
       default :
        Console.WriteLine("yanlış veya hatalı tuş tıkladınız lütfen tekrar deneyiniz");
        break;








    }
    

    
     
    }

      
      


      
    
} 