internal class Program
{
    class Rettangolo
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Area()
        {
            return X * Y;
        }

        public int Perimetro()
        {
            return 2 * (X + Y);
        }
    }
    private static void Main(string[] args)
    {
        Rettangolo rettangolo = new Rettangolo();

        Console.WriteLine("Larghezza e altezza:");
        rettangolo.X = int.Parse(Console.ReadLine());
        rettangolo.Y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {rettangolo.Area()}");
        Console.WriteLine($"Perimetro: {rettangolo.Perimetro()}");
        Console.WriteLine();

        for (int i = 0; i < rettangolo.X; i++)
        {
            Console.Write("+ ");
        }
        Console.WriteLine();

        for (int i = 0; i < rettangolo.Y - 2; i++)
        {
            Console.Write("+");
            for (int j = 0; j < 2 * rettangolo.X - 3; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("+");
        }

        for (int i = 0; i < rettangolo.X; i++)
        {
            Console.Write("+ ");
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}