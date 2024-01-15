using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayGitTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Welcome("...");
            Console.WriteLine(text);
            Console.ReadLine(); 
        }

        public static String Welcome(string name)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Kérlek add meg a neved!");
            string neved = Console.ReadLine();
            if (now.Hour >= 4 && now.Hour < 11) 
            {
                Console.WriteLine("Jó reggelt " + neved);
            }
            else if (now.Hour >= 11 && now.Hour < 18) 
            {
                Console.WriteLine("Jó napot " + neved);
            }
            else
            {
                Console.WriteLine("Jó szerencsét " + neved);
            }
            return "";
            //reggel 4-11 Jo reggelt {name}
            //11 - 18 Jo napot {name}
            // Jo szerencset {name}
        }
    }
}
