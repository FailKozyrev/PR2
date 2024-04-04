namespace Kozyrev_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");

            double R = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle();

            Console.WriteLine($"Периметр окружности - {circle.CalculateRerimetrCircle(R)}") ;
            Console.WriteLine($"Площадь окружности - {circle.CalculateAreaCircle(R)}");

            Console.WriteLine("Введите сторону квадрата: ");

            double a = Convert.ToDouble(Console.ReadLine());
            Square square = new Square();
            Console.WriteLine($"Периметр квадрата - {square.CalculateRerimetrSquare(a)}");
            Console.WriteLine($"Площадь квадрата - {square.CalculateAreaSquare(a)}");

            Console.ReadKey();  
        }
    }
}
