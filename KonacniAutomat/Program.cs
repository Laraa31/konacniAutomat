using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonacniAutomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int y=0;
           
            while (y==0)
            {
                Console.WriteLine("Upiši bit: ");
                if (Convert.ToString(Console.ReadLine()) == "1")
                {
                    Console.WriteLine("Upiši bit: ");
                    if (Convert.ToString(Console.ReadLine()) == "1")
                    {
                        Console.WriteLine("Upiši bit: ");
                        if (Convert.ToString(Console.ReadLine()) == "0")
                        {
                            Console.WriteLine("Upiši bit: ");
                            if (Convert.ToString(Console.ReadLine()) == "1")
                            {
                                Console.WriteLine("Diži rampu");
                                y++;
                            }
                        }
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
