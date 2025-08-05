using AlgorithmsLibrary;

class ChooseAlgorithm
{
    static void Main()
    {
        Console.WriteLine("This is a examples of Algorithms on C#");
        Console.WriteLine("Choose a algorithm:");
        Console.WriteLine();
        Console.WriteLine("1. Bynary search");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":

                 AlgorithmsLibrary.Check.Checkout();
                break;
        }
    }
}