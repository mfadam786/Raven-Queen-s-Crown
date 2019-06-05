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

            Console.WriteLine("You are standing in a busy street in *Base Point*, you must find The Raven Queens Crown. To travel north to the volcano to the press \'n\' To check the Mountain in the west press \'w' " +
                "To search the southern forest press \'s\' To plunder the eastern castle press \'e\' ");
            string direction = Console.ReadLine();
            switch (direction)
        {
                case "n":
                    Volcano();
                    break;
                case "w":
                    Mountain();
                    break;
                case "s":
                    Forest();
                    break;
                case "e":
                    Castle();
                    break;
           
            
            //Desert();
            //} 
        }
        }
        





















        public static void Volcano()
        {
            //Console.WriteLine("\nYou have finally found yourself at the entrance of Mount Doom, the only active volcano in (NAME OF PLACE)");
            //Console.WriteLine("Inside, you see a bridge that spans across a pit of molten hot lava.");
            //Console.WriteLine("On the other end of the bridge, you notice a sword, gleaming and blinding.");

            StreamReader sr = new StreamReader(@"H:\Professional Practice\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Story.txt");

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

            //Objective of the game is to find the crown

            Console.WriteLine("You have reached the outskirts of a Castle to enter press \'e\'");
            char outskirts = Convert.ToChar(Console.ReadLine());

            if (outskirts == 'e')
            {
                Console.WriteLine("You enter the Castle passing a sign saying \"Castle Luna\" " +
                    "it is dark inside to your left is a torch to grab the torch press \'k\'");
                char torch = Convert.ToChar(Console.ReadLine());

                if (torch == 'k')
                {
                    Console.WriteLine("You picked up the torch");
                }

                Console.WriteLine("\nTo your left are some poison darts to pick them up press \'p\'");
                string poison = Console.ReadLine();

                if (poison == "p")
                {
                    string inventory = poison;
                    Console.WriteLine("You pick up the poison darts, they are now added to your inventory, to throw press \'p\'");
                }

                //if user moves forward
                Console.WriteLine("A cat bounds forward");
                char cat = Convert.ToChar(Console.ReadLine());
                if (cat == 'p')
                {
                    Console.WriteLine("You threw poison darts at the cat, its a direct hit");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You died");
                    Console.ReadLine();
                }

            }















































        }



















































        public static void Mountain()
        {













































        }

























































        public static void Desert()
        {

















































        }
    }
}
