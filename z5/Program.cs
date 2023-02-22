namespace z5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите радиус круга (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            double p = (3.14);
            double s = ((2 * p) * r)/10000;
            Console.WriteLine($"Площадь круга : {s} кв.см.");
        }
    }
}