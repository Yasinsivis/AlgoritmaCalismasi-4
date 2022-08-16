using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje44
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Metni Girin :");
            string str = Console.ReadLine();
     
           
            string[] kelimeler = str.Split(' ');
          
       

            int totalCharacter = 0, totalLetterChar = 0, totalSpecialChar = 0;
           
            char[] strArray = str.ToCharArray();
            
            foreach (var item in strArray)
            {
                
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
          

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Girilen Metin : " + str);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Toplam Karakter Sayısı : " + totalCharacter);
            Console.WriteLine("Toplam Harf Sayısı : " + totalLetterChar);
            Console.WriteLine("Toplam Kelime Sayısı:" + kelimeler.Length);
      
            Console.ReadKey();
        
      }
    }
}
