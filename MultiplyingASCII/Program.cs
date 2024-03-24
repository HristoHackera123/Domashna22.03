namespace MultiplyingASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input exactly 2 strings:");
            string[] strings = Console.ReadLine().Split().ToArray();
            string str1 = strings[0];
            string str2 = strings[1];

            DoEverything(str1, str2);
            
        }
        static void DoEverything(string str1, string str2)
        {
            string shorter = str2;
            int shrtIndex = 2;
            if (string.Compare(str1, str2) < 0)
            {
                shorter = str1;
                shrtIndex = 1;
            }
            else if (string.Compare(str1, str2) == 0)
            {
                shrtIndex = 0;
            }

            int count = 0;
            int sum = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                int result = str1[i] * str2[i];
                sum += result;
                count = i;
            }
            count++;
            if (shrtIndex == 2)
            {
                for (int i = count; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if (shrtIndex == 1)
            {
                for (int i = count; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
