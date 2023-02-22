namespace z7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double z1 = (Math.Sin((3.14 / 2) + 3 * a)) / (1 - Math.Sin((3 * a - 3.14)));
            Console.WriteLine($"Ответ: {z1}");

            double z2 = (Math.Tan((5 / 4) * 3.14) + ((3 / 2) * a));
            Console.WriteLine($"Ответ: {z2}");
        }
    }
}