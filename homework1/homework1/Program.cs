using homework1.Tasks.Chapter1;

void ChapterOneHandler()
{
    Console.WriteLine("Выберите задание 1-5: ");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Task1.Run();
            break;
        case "2":
            Task2.Run();
            break;
        case "3":
            Task3.Run();
            break;
        case "4":
            Task4.Run();
            break;
        case "5":
            Task5.Run();
            break;
        default:
            Console.WriteLine("Такого задания нет");
            break;
    }
}

void Run()
{
    var isRunning = true;

    while (isRunning)
    {
        Console.WriteLine("Выберите часть 1-2 (0 - выход): ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                ChapterOneHandler();
                break;
            case "2":
                break;
            case "0": 
                isRunning = false;
                break;
            default:
                Console.WriteLine("Такой части нет");
                break;
        }
    }
}

Run();