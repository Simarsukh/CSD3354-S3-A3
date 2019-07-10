using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
            Blue b1 = new Blue();
            b1.SayFavoriteFood(Red.Favoritefood);
        }
    }

    class TextProcessing
    {
        public void Run()
        {
            // Open the names file and access the data
            using (StreamReader file = new StreamReader("U:/Users/739292/Assignment_3/ConsoleApp1/TextFile1.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
            Console.ReadLine();
        }
       
    }
    class PlayingWithstacks
    {

    }
    class Workbench
    {

    }
    class Red{
        public static string Favoritefood = "carrots";

    }
    class Blue{
        public void SayFavoriteFood(string FavFood)
        {
            Console.WriteLine(Red.Favoritefood);
        }
    }

}