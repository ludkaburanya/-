namespace Z3
{
    class Program
    {
        static void Main()
        {
            double x = 3.5;
            double y = (Math.Pow(Math.Cos(x), 2)
                - Math.Sqrt((Math.Pow(x, 3) + 1))
                / (Math.Sin(x)) + Math.Pow(2.7, (Math.Log(2 * (x)))));
            Console.WriteLine($"Ответ: {y}");
        }
    }
}