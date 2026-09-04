using homework1.Tasks.Chapter1;

var isRunning = true;

while (isRunning)
{
    Console.WriteLine("Выберите задание 1-3");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Task1.Run();
            break;
        case "2":
            break;
        default:
            Console.WriteLine("Такого задания нет");
            break;
    }
}