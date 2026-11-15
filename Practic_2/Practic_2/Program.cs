string? task1(int month)
{
    if (month < 1 || month > 12)
    {
        return "error"; 
    }

    if (month == 12 || month == 1 || month == 2)
    {
        return "winter";
    }
    else if (month >= 3 && month <= 5)
    {
        return "spring";
    }
    else if (month >= 6 && month <= 8)
    {
        return "summer";
    }
    return "autumn";

}

do
{
    Console.Write("Выберите номер задания: ");
    var numOfTask = Console.ReadLine();
    switch (numOfTask)
    {
        case "1":
            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine(task1(month)); 
            break;
        case "2":
            List<int> results = new List<int>();
            Console.Write("Введите количество конечных автоматов: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь введите значения для каждого автомата");
            for (int i = 0; i < k; i++)
            {
                string[] numbers = Console.ReadLine().Split(" ");
                var n = Convert.ToInt32(numbers[0]);
                var m = Convert.ToInt32(numbers[1]);
                int res = 19 * m + (n + 239) * (n + 366) / 2;
                results.Add(res);
            }
            Console.WriteLine("\nВаш ответ:A");
            foreach(int i in results)
            {
                Console.WriteLine(i);
            }
            break;
    }
    Console.WriteLine("Хотите продолжить? Нажмите Y, если да. Нажмите N, если нет");
} while(Console.ReadKey(true).Key == ConsoleKey.Y);

