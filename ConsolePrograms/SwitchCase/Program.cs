Console.WriteLine("Enter 0 For White BG");
Console.WriteLine("Enter 1 For Black BG");
Console.WriteLine("Enter 2 For Green BG");
int i = Convert.ToInt32(Console.ReadLine());
switch (i)
{
    case 0:
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        break;
    case 1:
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        break;
    case 2:
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;
    default:
        Console.WriteLine("Invalid Selection");
        break;
}