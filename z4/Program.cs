namespace Z4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));

            Console.WriteLine($"Расстояние на плоскости между двумя точками: {d:.###}");
        }
    }
}