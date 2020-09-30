using System;
using System.Threading.Tasks;
using FastConsole;
using static System.ConsoleColor;

namespace ConsoleTest
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Task[] tasks = new[] { TaskOne(), TaskTwo(), TaskThree() };
            await Task.WhenAll(tasks);
        }

        static async Task TaskOne()
        {
            await Task.Yield();

            IPrinter p = new Printer(DarkYellow);

            p.Println("Hello " + "there ".I(Green) + ".");

            await Task.Delay(3000);
            
            p.Println("General Kenobi.");
            p.Println("You are a bold one.");
        }
        static async Task TaskTwo()
        {
            await Task.Yield();

            IPrinter p = new Printer(Cyan);

            p.Println("Hello " + "there ".I(Green) + ".");

            await Task.Delay(2000);

            p.Println("General Kenobi.");
            p.Println("You are a bold one.");
        }
        static async Task TaskThree()
        {
            await Task.Yield();

            IPrinter p = new Printer(Magenta);

            p.Println("Hello " + "there ".I(Green) + ".");

            await Task.Delay(4000);

            p.Println("General Kenobi.");
            p.Println("You are a bold one.");
        }
    }
}