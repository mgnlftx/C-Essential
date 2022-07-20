namespace Circumference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double d = 3, l = Math.PI * d;

            Console.WriteLine($"Длина окружности с диаметром {d} см., равна {l} см.");

            Console.ReadKey();
        }
    }
}
