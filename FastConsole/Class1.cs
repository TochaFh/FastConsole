using System;

namespace FastConsole
{
    public static class FastConsole
    {
        public static void Println(string value)
        {
            Console.WriteLine(value);
        }
        public static void Println(object value)
        {
            Println(value.ToString());
        }

        public static void Print(string value)
        {
            Console.Write(value);
        }
        public static void Print(object value)
        {
            Print(value.ToString());
        }
    }
}
