int[][] aaa = new int[3][];
aaa[0] = new int[6]{1, 2, 3, 4, 5, 6};
aaa[1] = new int[3]{1, 2, 3};
aaa[2] = new int[4]{1, 2, 3, 4};

for (int i = 0; i < aaa.Length; i++)
{
    for (int j = 0; j < aaa[i].Length; j++)
    {
        Console.Write(aaa[i][j] + " ");
    }
    Console.WriteLine();
}