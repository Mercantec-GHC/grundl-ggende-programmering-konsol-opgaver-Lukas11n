
//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

/*
int i = 0;
while (i == 0)
{
    Console.WriteLine("flip heads ot tails");
    Console.ReadLine();

    Random coin = new Random();
    int flip = coin.Next(0, 2);
    Console.WriteLine((flip == 0) ? "heads\n" : "tails\n");
}
*/


/*
string permission = "Admin|Manager";
Random level = new Random();
int RandomLevel = level.Next(20, 100);

if (permission.Contains("Admin"))
{
    if (RandomLevel > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
        Console.ReadLine();
    }
}
else if (permission.Contains("Manager"))
{
    if (RandomLevel >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
    Console.ReadLine();
}
*/

