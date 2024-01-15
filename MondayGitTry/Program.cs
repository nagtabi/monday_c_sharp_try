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
            string text = Welcome("Bence");
            Console.WriteLine(text);
            Console.ReadLine();
        }

        public static String Welcome(string name)
        {
            DateTime jelengeliIdo = DateTime.Now;
            int ora = jelengeliIdo.Hour;

            if (ora >= 4 && ora < 11)
            {
                return "Jo reggelt " + name;
            }
            else if (ora >= 11 && ora < 18)
            {
                return "Jo napot " + name;
            }
            else
            {
                return "Jo szerencset " + name;
            }


            //reggel 4-11 Jo reggelt {name}
            //11 - 18 Jo napot {name}
            // Jo szerencset {name}
        }
    }
}
