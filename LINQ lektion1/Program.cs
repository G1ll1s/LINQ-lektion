namespace LINQ_lektion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { Brand = "Volvo", Model = "XC90", LicenseNumber = "ABC 123", YearOfManufacure = 2023 },
                new Car() { Brand = "Saab", Model = "9-5", LicenseNumber = "SAA 345", YearOfManufacure = 1999 },
                new Car() { Brand = "Wolkswagen", Model = "Golf", LicenseNumber = "GOL 888", YearOfManufacure = 2002 },
                new Car() { Brand = "Toyota", Model = "Aygo Hybrid", LicenseNumber = "TOY 111", YearOfManufacure = 2021 },
            };

            cars.Sort(CompareByYearOfManufacture);
            cars.Sort(CompareByBrand);
            //Comparison // är en delegat (legacy)


            //Enumerable // Innehåller samtliga LINQ-metoder

            //LINQ  // Language Integrated Query
            cars = cars.OrderBy(CompareDataValue).ToList(); // Namngiven metod som argument
            cars = cars.OrderBy(c => c.LicenseNumber).ToList(); // Lambda uttryck som argument (är en metoddeklaration inline som argument)

        }

        static string CompareDataValue(Car c)
        {
            return c.LicenseNumber;
        }


        static int CompareByBrand(Car a, Car b)
        {
            return string.Compare(a.Brand, b.Brand);
        }


        static int CompareByYearOfManufacture(Car a, Car b) // -1 bil a före bil b, 0  om bil a är lika bil b, 1 om bil a är före bil b
        {
            if (a.YearOfManufacure < b.YearOfManufacure)
                return -1;
            else
                if (a.YearOfManufacure > b.YearOfManufacure)
                return 1;

            return 0;
        }

        static void DoSomething()
        {
            x += 10;
        }
    }
}
