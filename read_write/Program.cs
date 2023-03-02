using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tckimlikno, adi, soyadi;
            Console.Write("TC Kimlik Numarası:");
            tckimlikno = Console.ReadLine();
            Console.Write("adi:");
            adi = Console.ReadLine();
            Console.Write("soyadı:");
            soyadi = Console.ReadLine();
            Console.Write("Tc Kimlik No:{0} \n Adı:{1} \n Soyadı:{2}", tckimlikno, adi, soyadi);
            Console.ReadKey();

        }
    }
}
