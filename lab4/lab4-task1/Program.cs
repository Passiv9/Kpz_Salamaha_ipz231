using System;

public abstract class SupportHandler
{
    protected SupportHandler _nextHandler;

    public void SetNextHandler(SupportHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void HandleRequest(int choice);
}

public class Level1SupportHandler : SupportHandler
{
    public override void HandleRequest(int choice)
    {
        if (choice == 1)
        {
            Console.WriteLine("Ви обрали рівень 1 підтримки: Загальні питання.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(choice);
        }
        else
        {
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
        }
    }
}

public class Level2SupportHandler : SupportHandler
{
    public override void HandleRequest(int choice)
    {
        if (choice == 2)
        {
            Console.WriteLine("Ви обрали рівень 2 підтримки: Технічні проблеми.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(choice);
        }
        else
        {
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
        }
    }
}

public class Level3SupportHandler : SupportHandler
{
    public override void HandleRequest(int choice)
    {
        if (choice == 3)
        {
            Console.WriteLine("Ви обрали рівень 3 підтримки: Проблеми з рахунком.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(choice);
        }
        else
        {
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
        }
    }
}

public class Level4SupportHandler : SupportHandler
{
    public override void HandleRequest(int choice)
    {
        if (choice == 4)
        {
            Console.WriteLine("Ви обрали рівень 4 підтримки: Складні запити.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(choice);
        }
        else
        {
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var level1Handler = new Level1SupportHandler();
        var level2Handler = new Level2SupportHandler();
        var level3Handler = new Level3SupportHandler();
        var level4Handler = new Level4SupportHandler();

        level1Handler.SetNextHandler(level2Handler);
        level2Handler.SetNextHandler(level3Handler);
        level3Handler.SetNextHandler(level4Handler);

        while (true)
        {
            Console.WriteLine("Виберіть рівень підтримки:");
            Console.WriteLine("1 - Загальні питання");
            Console.WriteLine("2 - Технічні проблеми");
            Console.WriteLine("3 - Проблеми з рахунком");
            Console.WriteLine("4 - Складні запити");
            Console.WriteLine("Інше - Завершити");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Завершення роботи.");
                    break;
                }

                level1Handler.HandleRequest(choice);
            }
            else
            {
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            }
        }
    }
}
