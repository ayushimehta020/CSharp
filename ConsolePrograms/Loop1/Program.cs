int New = 0, old = 0;
Console.Write("Enter Any Number : ");
var userInput = Console.ReadLine();
var success = int.TryParse(userInput, out var n);
if (success)
{
    Console.WriteLine("\nUsing for loop : ");
    for (var i = 1; i <= n; i++)
    {
        if (i <= 3)
        {
            Console.Write(i + " ");
            New = i;
            old = i - 1;
        }
        else
        {
            i = New * old;
            if (i > n)
            {
                break;
            }
            Console.Write(i + " ");
            old = New;
            New = i;
        }
    }

    Console.WriteLine("\n\nUsing while loop : ");
    var j = 1;
    while (j <= n)
    {
        if (j <= 3)
        {
            Console.Write(j + " ");
            New = j;
            old = j - 1;
        }
        else
        {
            j = New * old;
            if (j > n)
            {
                break;
            }
            Console.Write(j + " ");
            old = New;
            New = j;
        }
        j++;
    }

    Console.WriteLine("\n\nUsing do...while loop : ");
    j = 1;
    do
    {
        if (j <= 3)
        {
            Console.Write(j + " ");
            New = j;
            old = j - 1;
        }
        else
        {
            j = New * old;
            if (j > n)
            {
                break;
            }
            Console.Write(j + " ");
            old = New;
            New = j;
        }
        j++;
    } while (j <= n);
}
else
{
    Console.WriteLine("The input is not a valid number.");
}