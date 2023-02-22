namespace Z2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четырехзначное число: ");
            int num = Convert.ToInt16(Console.ReadLine());

            int a = (num % 10);
            int b = (num / 10 % 10);
            int c = (num / 100 % 10);
            int d = (num / 1000);

            int x = (a + b + c + d);
            Console.WriteLine($"Ответ: {x}");
        }
    }
}