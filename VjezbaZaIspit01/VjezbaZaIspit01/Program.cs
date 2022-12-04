using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            unos:   
            Console.WriteLine("Unesi stranicu a: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu b: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu c: ");
            z = Convert.ToInt32(Console.ReadLine());
 
            if(x < 0 || z < 0 || y < 0)
            {
                Console.WriteLine("Pogresan unos, pokusajte ponovno!");
                goto unos;
            }
            if(z == Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)))
            {
                Console.WriteLine("Trokut je pravokutan!");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan!");
            }
            Console.ReadKey();
        }
    }
}
