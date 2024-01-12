using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Functions
    {
        public static int MainMenu()
        {
            Console.WriteLine("Pulun miqdarı: 1\nPul əlavə et: 2\nPul çək: 3\nHesabdan çıx: 4\n");
            int value = int.Parse(Console.ReadLine());

            return value;
        }

    }
}
