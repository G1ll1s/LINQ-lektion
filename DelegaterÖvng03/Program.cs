namespace DelegaterÖvng03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> compareAction = IsLessThan;

            Console.WriteLine("Skriv in första siffran: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in andra siffran: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(compareAction(a, b));
        }
        static bool IsLessThan(int a, int b)
        {
            return a < b;
        }
    }
}
