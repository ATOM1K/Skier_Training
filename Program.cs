internal class Program
{
    /*
     *Начав тренировки, лыжник в первый день пробежал 10 км.
     *Каждый следующий день он увеличивал пробег на 10% от
     *пробега предыдущего дня. Определить:
        а) пробег лыжника за второй, третий, …, десятый день тренировок;
        б) какой суммарный путь он пробежал за первые 7 дней тренировок.
     */

    // (a/A)
    // (b/Б)
    public static void SevenDaysRange(float start)
    {
        float start1 = start;
        for (int i = 2; i <= 7; i++)
        {
            start1 = start1 * 1.1f;
            start = start + start1;
            Console.WriteLine($"Range of {i}-day is: {Math.Round(start1, 2)} kilometers.");
        }
        Console.WriteLine($"By 7 days skier runs {Math.Round(start, 2)} kilometers.");
    }
    private static void Main(string[] args)
    {
        Console.Write("Hello, there!\nEnter the number of kilometers the skier ran on the first day: ");
        int firstRunRange = int.Parse(Console.ReadLine());

        Console.WriteLine($"Range of {1}-day is: {10} kilometers.");
        SevenDaysRange(firstRunRange);
    }
}