namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string palindrom = Console.ReadLine();
            Console.WriteLine(CheckPalindrom(palindrom));
        }
        static bool CheckPalindrom (string palindrom)
        {
            bool result = true;
            for (int i = 0; i < palindrom.Length/2; i++)
            {
                if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
