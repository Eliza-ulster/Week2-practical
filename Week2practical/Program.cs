/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author : Eliza Ann Benoy
 * Date: October
 */

static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1.Hello in Freanh");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3.Hello in German?");
    Console.WriteLine("4.Hello in Italian?");
    Console.WriteLine("0. Exit application");

}



static int InputOption()
{
    int Option;
    try
    {
        Option = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Option = 0;

    }
    return Option;


}

static string GetMessage(int language)
{
    string msg = "";
    switch( language )
    {
        case 0:
            Console.WriteLine("Goodbye");
            break;

        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:

            Console.WriteLine("Ola");
            break;

        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Enter a vaild option");
            break;



    }
    return msg;


}




Main();

 static void Main()

{
    string message = "";
    do
    {
        PrintMenu();
        int option = InputOption();
        message = GetMessage(option);
        Console.WriteLine(message);

    } while (message != "Goodbye");


}

