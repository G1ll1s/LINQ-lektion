namespace DelegaterÖvng02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> printAction = PrintIt;
            printAction("Winne the Pooh!", true);
            printAction("Winnie the Pooh!", false);

        }
        static void PrintIt(string s, bool t)
        {
            if (t)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
        }
    }
}
