int[] a1 = new int[3];
a1[0] = 1;
a1[1] = 2;
a1[2] = 3;

Console.WriteLine("1D array : ");
foreach (var i in a1)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n\nRectangular array : ");
int[,] a2 = new int[2, 2];
a2[0, 0] = 1;
a2[0, 1] = 2;
a2[1, 0] = 3;
a2[1, 1] = 4;
foreach (var i in a2)
{
    Console.Write(i + " ");
}