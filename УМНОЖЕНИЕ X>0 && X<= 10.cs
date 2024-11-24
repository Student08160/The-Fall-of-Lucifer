static void Main(string[] args)
{
    try
    {
        // Объявляем необходимые переменные.
        int a = -1, b = -1;
        while (true)
        {
            // Считываем исходные данные от пользователя.
            Console.Write("Пожалуйста, введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Пожалуйста, введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            // Делаем условие вычисления.
            if ((a >= 0 && a <= 10) && (b >= 0 && b <= 10))
            {
                // Производим вычисления.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Результат: {a * b}");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            } 
            else // ((a < 0 && a > 10) && (b < 0 && b > 10))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введённые числа недопустимы.");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Пожалуйста, попробуйте ещё раз.");
                Console.ForegroundColor = ConsoleColor.White;

                continue;

            }
        }
    }
    catch (System.FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный формат данных.");
        Console.ForegroundColor = ConsoleColor.White;
        Main(args);
    }
}
