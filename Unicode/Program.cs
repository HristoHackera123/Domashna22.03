using System.Globalization;

namespace Unicode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                int un = (int)input[i];
                Console.Write(un + " ");
            }
            //nikoi ne e kazval kak se bachka s unicode
        }
    }
}
