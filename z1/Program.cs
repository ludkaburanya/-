namespace Z1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            Console.WriteLine($"{a}+{b}={c:.###}");
        }
    }
}