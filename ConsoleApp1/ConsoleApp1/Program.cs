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
        }
    }

    class TextProcessing
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {

          
            using (StreamReader file = new StreamReader("U:/Users/739292/Assignment_3/ConsoleApp1/TextFile1.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
               
                PlayingWithStacks.Run(names);
            }
        }
    }

    class PlayingWithStacks
    {
        public static void Run(Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
           
            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());
            }
        }
    }

    class Workbench { }

    class Red
    {
        public static string FavoriteFood = "Carrots";
    }

    class Blue
    {
        public void SayFavoriteFood(string FavFood)
        {
            Console.WriteLine(Red.FavoriteFood);
        }
    }
    Console.ReadLine();

}
