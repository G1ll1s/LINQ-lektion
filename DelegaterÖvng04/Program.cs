namespace DelegaterÖvng04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("Winnie the Pooh", UpperOrLowerCase);
        }
        static void SomeMethod(string s, Func<bool> check)
        {
            if (check())
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }

        static bool UpperOrLowerCase()
        {
            Console.WriteLine("JA för stor bokstäver, inget för små bokstäver: ");
            string s = Console.ReadLine();
            bool trueOrFalse = s.ToUpper() == "JA";
            return trueOrFalse;
        }
    }
}
