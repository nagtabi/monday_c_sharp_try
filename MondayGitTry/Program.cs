﻿using System;
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
            string text = Welcome("Albert");
            Console.WriteLine(text);
            Console.ReadLine(); 
        }

        public static String Welcome(string name)
        {
            DateTime dateTime = DateTime.Now;
            int hour =  dateTime.Hour;
            string resume = string.Format("Jó szerencsét , {0} !" , name);
            if(hour>=4 && hour<11)
            {
                resume = string.Format("Jó reggelt , {0} !" , name);
            }
            if(hour>=11 && hour <19)
            {
                resume = string.Format("Jó napot , {0} !" , name);
            }
            //reggel 4-11 Jo reggelt {name}
            //11 - 18 Jo napot {name}
            // Jo szerencset {name}
            return resume;
        }
    }
}
