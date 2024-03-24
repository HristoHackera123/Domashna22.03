using System.Diagnostics;

namespace Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();
            char[] mod = DoReverse(input);
            Console.WriteLine(string.Join("", mod));
            
        }
        static char[] DoReverse(string input)
        {
            Stopwatch sw = Stopwatch.StartNew();
            char[] mod = input.ToArray();
            // char[] mod = input.Reverse().ToArray();
            // bez reverse e 3x po-burzo
            for (int i = 0; i < mod.Length / 2; i++)
            {
                char swap = mod[i];
                mod[i] = mod[mod.Length - 1 - i];
                mod[mod.Length - 1 - i] = swap;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
            return mod;
        }
    }
}
