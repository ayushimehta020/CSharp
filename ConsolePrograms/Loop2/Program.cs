int New = 0, old = 0, k = 1;
Console.Write("Enter Any Number : ");
var userInput = Console.ReadLine();
var success = int.TryParse(userInput, out var n);

if (success)
{
    Console.WriteLine("\nUsing for loop : ");
    for (var i = 1; i <= n; i++)
    {
        for (var j = 1; j <= i; j++, k++)
        {
            if (k <= 3)
            {
                Console.Write(k + " ");
                New = k;
                old = k - 1;
            }
            else
            {
                k = New * old;
                if (k > n)
                {
                    break;
                }
                Console.Write(k + " ");
                old = New;
                New = k;
            }
        }

        if (k > n)
        {
            break;
        }
        Console.WriteLine();
    }

    k = 1;
    Console.WriteLine("\nUsing while loop : ");
    var num = 1;
    while (num <= n)
    {
        var j = 1;
        while (j <= num)
        {
            if (k <= 3)
            {
                Console.Write(k + " ");
                New = k;
                old = k - 1;
            }
            else
            {
                k = New * old;
                if (k > n)
                {
                    break;
                }
                Console.Write(k + " ");
                old = New;
                New = k;
            }
            j++;
            k++;
        }

        if (k > n)
        {
            break;
        }
        Console.WriteLine();
        num++;
    }
    
    Console.WriteLine("\nUsing do...while loop : ");
    k = 1;
    num = 1;
    do
    {
        var j = 1;
        do
        {
            if (k <= 3)
            {
                Console.Write(k + " ");
                New = k;
                old = k - 1;
            }
            else
            {
                k = New * old;
                if (k > n)
                {
                    break;
                }
                Console.Write(k + " ");
                old = New;
                New = k;
            }
            j++;
            k++;
        } while (j <= num);

        if (k > n)
        {
            break;
        }
        Console.WriteLine();
        num++;
    } while (num <= n);
}
else
{
    Console.WriteLine("The input is not a valid number.");
}