using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Principal;
using System.Xml.Linq;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool isWeird = true;
            double ifFtTall = 6.4;
            decimal myMoney = 1000000m;


            Console.WriteLine("Hello, Mack or Seth! \n\n");
            Thread.Sleep(2000);
            Console.WriteLine("Enter the name of your favorite game: ");

            string name = Console.ReadLine();
            Console.WriteLine("\n \n");

            Thread.Sleep(2000);
            

            Console.WriteLine($"Wow noone would have ever guessed you favorite game is {name}!!!");
            Console.WriteLine("\n \n");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);

            Console.WriteLine($"Ok. Now I want you to guess how many times you have beaten {name}. \nGo ahead and type the WHOLE number.");
            string numberOfPlays = Console.ReadLine();

            if (int.TryParse(numberOfPlays, out int number)) 
            {
                Console.WriteLine("Wow what a nerd!");
            }
            else
            {
                Console.WriteLine("I said whole Number!!... Great now we gotta start over!!!");
            }
            

            Console.WriteLine("\n \n");

            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");

            Console.WriteLine($"Just kidding! {numberOfPlays} isnt that crazy.");

            Thread.Sleep(2000);
            
            Console.WriteLine($"Plus I've heard {name} is really fun.");
            Thread.Sleep(3000);
            Console.WriteLine("\n \n");


            Console.WriteLine("Alrighty. Now I want you to pick your favorite letter");

            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Console.WriteLine($"Really! {letter}... Out of all the letters your favorite is {letter}.");
            Console.WriteLine("\n \n");
            Thread.Sleep(1000);
            
            Thread.Sleep(3000);
            
            
            
            Console.WriteLine("well honestly that was unexpected. your a strage one. ");

            Thread.Sleep(3000);
            
            Console.WriteLine("\n \n");

            Console.WriteLine($"OK. so your favorite game is {name}. Yove beaten it {numberOfPlays}, and your favorite letter is letter is {letter}");

            Thread.Sleep(3000);

            Console.WriteLine("\n \n");

            Console.WriteLine($"Does it mean your a strange strange person if your favorite letter is {letter}");

            Thread.Sleep(4000);

            Console.WriteLine("\n \n");

            Console.WriteLine($"{isWeird}. I think most people will agree that is really weird");

            Thread.Sleep(4000);

            Console.WriteLine("\n \n");

            Console.WriteLine($"Ok and for no reason if you {ifFtTall} feet tall then youve won {myMoney}$");









        }
    }
}
