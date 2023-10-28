static void DoJob(string str)
{
    Console.WriteLine("Enter a number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a > str.Length)
        Console.WriteLine(str.ToUpper());
    else if(a == str.Length)
        Console.WriteLine(str);
    else 
        Console.WriteLine(str.ToLower());       
}
DoJob("TelefON");

//===========================================

int x = 10;
int y = 15;
string result;
if(x > y)
    result = "x is greater than y.";
else if(x < y)
    result = "x is less than y.";
else if(x == y)
    result = "x is equal to y.";
else 
    result = "x and y are not comparable.";
System.Console.WriteLine(result);

//=================================================

System.Console.WriteLine("Hafta kunini kiriting: ");
string weekDay = Console.ReadLine();
weekDay.ToLower();
string output = "";
switch (weekDay)
{
    case "dushanba":
        output = "Monday";
        break;
    case "seshanba":
        output = "Tuesday";
        break;
    case "chorshanba":
        output = "Wednesday";
        break;
    case "payshanba":
        output = "Thursday";
        break;
    case "juma":
        output = "Friday";
        break;
    case "shanba":
        output = "Saturday";
        break;
    case "yakshanba":
        output = "Sunday";
        break;
    default:
        output = "Wrong input";
        break;
}
 System.Console.WriteLine($"{weekDay} - {output}");

