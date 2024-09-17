namespace DelegaterÖvng01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();

            carAction = Decelerate;
            carAction();
        }

        static void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }

        static void Decelerate()
        {
            Console.WriteLine("Decelerating...");
        }
    }
}
