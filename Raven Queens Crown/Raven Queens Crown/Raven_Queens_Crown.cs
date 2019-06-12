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



H:\Muhammed Faizel Adam (100065402)\BIT-Year-1\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info






























        public static void Volcano()
        {
            int countStory = 0, countInventory = 0;

            StreamReader story = new StreamReader(@"H:\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Story.txt");
            StreamReader store = new StreamReader(@"H:\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Store in Inventory.txt");


            string storyLine, useInventory, storeInventory, use = "Use";

            storyLine = story.ReadToEnd();
            storeInventory = store.ReadToEnd();

            string[] storyLines = storyLine.Split('-');
            string[] inventory = storeInventory.Split(',');
            
            foreach (char displayStoryLine in storyLines[countStory])
            {
                Thread.Sleep(25);
                Console.Write(displayStoryLine);
            }           
            
            countStory++;

            string answer = Console.ReadLine();

            answer = answer.Replace(',' , ' ');

            string[] answerCheck = answer.Split(' ');

            foreach (string user in answerCheck)
            {
                foreach (string pick in inventory)
                {
                    if (user == pick)
                    {

                    }
                }
            }
            
            


            /*
            foreach (char display in question)
            {
                Thread.Sleep(75);
                Console.Write(display);
            }

            //Console.WriteLine(sentence.TrimEnd());*/
            Console.ReadLine();




























        }

        public static void Inventory()
        {
            string[] inventory = new string[4];


        }
    }

