public static class ConsoleMenu
{
    public static void ShowMenu()
    {
        TranslatorFacade facade = TranslatorFacade.Instance();
        Console.WriteLine("Welcome to the Language Translator!");
        Console.WriteLine("1. Translate Text");
        Console.WriteLine("2. Translate Text with Auto-Detect");
        Console.WriteLine("3. Exit");
        Console.Write("Please select an option: ");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("\nYou selected: Translate Text");
                Console.WriteLine($"Translated Text: {facade.Translate(false)}");
                ShowMenu(); // Loop till they choose to exit
                break;
            case ConsoleKey.D2:
                Console.WriteLine("\nYou selected: Translate Text with Auto-Detect");
                Console.WriteLine($"Translated Text: {facade.Translate(true)}");
                ShowMenu(); // Loop till they choose to exit
                break;
            case ConsoleKey.D3:
                Console.WriteLine("\nExiting the application. Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nInvalid option. Please try again.");
                ShowMenu(); // Show the menu again for valid input
                break;
        }
    }
}