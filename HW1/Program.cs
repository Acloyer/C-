/*
// TASK 1
int selection=0;
Console.WriteLine("Enter number: ");
selection = Convert.ToInt32(Console.ReadLine());
if (selection > 100 && selection < 1)
{
    Console.WriteLine("Error;");
}
else if (selection % 3 != 0 && selection % 5 != 0)
{
    Console.WriteLine(selection);
}
else if (selection % 3 == 0 && selection % 5 == 0)
{
    Console.WriteLine("Fizz Buzz");
}
else if (selection % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else if (selection % 3 == 0)
{
    Console.WriteLine("Fizz");
}
*/

/*
// TASK 2
int num1=0, num2=0;
Console.WriteLine("Enter % of number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1}% ot {num2} =" + (num1*num2)/100);
*/

/*
// TASK 3
int num1=0,num2=1000,total=0;
while (num2 != 0)
{
    Console.WriteLine("Enter number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    total += num1 * num2;
    num2 /= 10;
}
Console.WriteLine($"Total number: {total}");*/

/*
//TASK 4
int num1=0, num2=100000, num3=0;
Console.WriteLine("enter num; ");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 100000 && num1 > 999999)
{
    Console.WriteLine("error");
}
else
{
    while (num1 != 0)
    {
        num3 += (num1%10) * num2;
        num1 /= 10;
        num2 /= 10;
    }
    Console.WriteLine(num3);
}
*/
/*
TASK 5
int year, month, day;
Console.WriteLine("Enter year: ");
year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter month: ");
month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter day: ");
day = Convert.ToInt32(Console.ReadLine());

if (year < 9999 && month < 12 && month > 0 && day > 0 && day < 31)
{
    DateTime dt = new DateTime(year, month, day);
    Console.WriteLine(dt.ToString("dd.MM.yyyy"));
    Console.WriteLine(dt.ToString("dddd @ hh:mm tt", System.Globalization.CultureInfo.InvariantCulture));
    
}
else
    Console.WriteLine("ERROR");

*/

/*
// TASK 6
int selection, num;
Console.WriteLine("Enter 1 if you convert to celsia\nEnter 2 if you want convert to faringeyt");
selection = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter temperature;");
num = Convert.ToInt32(Console.ReadLine());
if (selection == 1)
{
    Console.WriteLine($"Your temperature in CELSIA: {(num-32)*5/9}");
}
else if (selection == 2)
{
    Console.WriteLine($"Your temperature in Faringeyt: {(num*9/5)+32}");
}
else
{
    Console.WriteLine("ERROR");
}
 */

/*
// TASK 7
int num1, num2;

Console.WriteLine("Enter num1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num2: ");
num2 = Convert.ToInt32(Console.ReadLine());
for (int i = num1; i < num2+1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

