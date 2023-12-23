int total;
float per;
string res, grade;

Console.Write("Enter Marks 1 : ");
var m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks 2 : ");
var m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks 3 : ");
var m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks 4 : ");
var m4 = Convert.ToInt32(Console.ReadLine());
if (m1 <= 100 && m2 <= 100 && m3 <= 100 && m4 <= 100)
{
    total = m1 + m2 + m3 + m4;
    if (m1 >= 40 && m2 >= 40 && m3 >= 40 && m4 >= 40)
    {
        per = total / 4.0f;
        res = "PASS";
        if (per > 70)
        {
            grade = "A";
        }
        else if (per > 60)
        {
            grade = "B";
        }
        else if (per > 50)
        {
            grade = "C";
        }
        else
        {
            grade = "D";
        }
    }
    else
    {
        per = 0;
        res = "FAIL";
        grade = "E";
    }
    Console.WriteLine("Total is : " + total);
    Console.WriteLine("Percentage is : " + per);
    Console.WriteLine("Result is : " + res);
    Console.Write("Grade is : " + grade);
}
else
{
    Console.Write("Enter Marks Between 1 And 100");
}