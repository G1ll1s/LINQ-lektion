namespace DelegateExample01
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("Hello World!");
        }

        static void HittePå()
        {
            Console.Beep(400, 1000);
        }
        
        

        public static void Main(string[] args)
        {
            // Tilldela variabeln a av typen Action metoden MyMethod. Action a = MyMethod;
            Action method = MyMethod;

            // Anropa metoden som variabeln a tilldelats. a();
            method();

            method = HittePå;
            method();
        }
    }
}
