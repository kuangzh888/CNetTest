namespace ConsoleApp20260330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            int count = 0;
            foreach (char item in charArray)
            {
                int i = (int)item - '0';
                Console.WriteLine(i);
                count += i;
            }
            Console.WriteLine(count);
        }
    }
}
