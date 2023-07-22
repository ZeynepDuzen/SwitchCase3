using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String degiskenler ile Switch Case Mevsim Uygulaması

            string mevsim;
            Console.WriteLine("Lütfen bir mevsim adı giriniz :");
            mevsim = Console.ReadLine().ToLower();

            switch (mevsim)
            {
                case "ilkbahar": Console.WriteLine("Mart,Nisan,Mayıs"); break;
                case "yaz":      Console.WriteLine("Haziran,Temmuz,Agustos"); break;
                case "sonbahar": Console.WriteLine("Eylül,Ekim,Kasım"); break;
                case "kıs":      Console.WriteLine("Aralık,Ocak,Subat"); break;
            }

            Console.Read();
        }
    }
}
