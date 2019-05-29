using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Raven_Queens_Crown
{
    class Raven_Queens_Crown
    {
        static void Main(string[] args)
        {
            //string answer = "";

            //answer = Console.ReadLine();

            //while (answer != "9999")
            //{                
                Volcano();
                //Forest();
                //Castle();
                //Mountain();
                //Desert();
            //} 
        }






















        public static void Volcano()
        {
            //Console.WriteLine("\nYou have finally found yourself at the entrance of Mount Doom, the only active volcano in (NAME OF PLACE)");
            //Console.WriteLine("Inside, you see a bridge that spans across a pit of molten hot lava.");
            //Console.WriteLine("On the other end of the bridge, you notice a sword, gleaming and blinding.");

            StreamReader sr = new StreamReader(@"C:\Users\mfada\Desktop\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Story.txt");

            string questions;

            string sentence = "";

            questions = sr.ReadToEnd();

            foreach (char display in questions)
            {
                Thread.Sleep(75);
                Console.Write(display);
            }

            //Console.WriteLine(sentence.TrimEnd());
            Console.ReadLine();




























        }
















































        public static void Forest()
        {






















































        }



















































        public static void Castle()
        {














































        }



















































        public static void Mountain()
        {













































        }

























































        public static void Desert()
        {

















































        }
    }
}
