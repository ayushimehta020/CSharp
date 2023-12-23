// See https://aka.ms/new-console-template for more information

double per;
string result;
char grade;
Console.Write("Enter marks 1 : ");
var m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter marks 2 : ");
var m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter marks 3 : ");
var m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter marks 4 : ");
var m4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter marks 5 : ");
var m5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter marks 6 : ");
var m6 = Convert.ToInt32(Console.ReadLine());
if (m1 >= 40 && m2 >= 40 && m3 >= 40 && m4 >= 40 && m5 >= 40 && m6 >= 60)
{
    per = (m1 + m2 + m3 + m4 + m5 + m6) / 6.0;
    result = "PASS";
    if (per >= 90)
    {
        grade = 'o';
    }
    else if (per >= 80)
    {
        grade = 'A';
    }
    else if (per >= 70)
    {
        grade = 'B';
    }
    else if (per >= 60)
    {
        grade = 'C';
    }
    else if (per >= 50)
    {
        grade = 'D';
    }
    else
    {
        grade = 'E';
    }
}
else
{
    per = (m1 + m2 + m3 + m4 + m5 + m6) / 6.0;
    grade = 'E';
    result = "FAIL";
}
Console.WriteLine($"Percentage = {per}");
Console.WriteLine($"Result = {result}");
Console.WriteLine($"Grade = {grade}");