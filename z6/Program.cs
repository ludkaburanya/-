namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двухзначное число: ");
            string s = Console.ReadLine();

            int first = int.Parse(s[0].ToString());
            Console.WriteLine($"Первая цифра числа: {first}");

            int last = int.Parse(s[s.Length - 1].ToString());
            Console.WriteLine($"Вторая цифра числа: {last}");
        }
    }
} 