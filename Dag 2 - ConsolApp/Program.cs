// See https://aka.ms/new-console-template for more information


/*
Random use 

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
*/

/*
instanciering  
 
 Random dice = new Random();
*/



//her lavede jeg et lille terning spil ved brug af random

/*

int i = 0;

while (i < 1)
{
   Console.WriteLine("do you want to play? y/n");
   string awnser = Console.ReadLine();
   if (awnser == "y")
   {
       Random dice = new Random();
       int roll = dice.Next(1, 100);
       Console.WriteLine("if you roll over 50 you win");
        if (roll > 50)
        {
            Console.WriteLine($"you rolled an: {roll} and win");
            Console.ReadLine();
        }
        else
            Console.WriteLine($"you rolled an: {roll} and lose");
       
   }
   else if (awnser == "n")
   {
       Console.WriteLine("EXIT");
       Console.ReadLine();
       i++;
   }
   else
   {
       Console.WriteLine("invalid input");
       Console.ReadLine();
   }
}
*/

/*
her bliver der taget brug af (Math) Math.Max i dette tilfælde for at få største verdi af de to veriabler
 
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/

/*
int i = 0;

Random random = new Random();
int daysUntilExpiration = random.Next(12);

while (i == 0)
{
    Console.WriteLine("do you wnt to continue? y/n");
    string svar2 = Console.ReadLine();
    if (svar2 == "y")
    {
        Console.WriteLine("subscription service");
        Console.ReadLine();
       

        if (daysUntilExpiration <= 10)
        {
            if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine("Renew now and save 10%!");
                Console.ReadLine();
                if (daysUntilExpiration <= 1)
                {
                    if (daysUntilExpiration == 0)
                    {
                        Console.WriteLine("Your subscription has expired.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Your subscription expires within a day!");
                    Console.WriteLine("Renew now and save 20%!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
                Console.ReadLine();
            }
        }
        else if (daysUntilExpiration > 10)
        {
            Console.WriteLine("have a nice day");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("invalid input");
            Console.ReadLine();
        }
    }
    else if (svar2 == "n") 
    {
        Console.WriteLine("closing now");
        i++;
    }
    else 
    {
        Console.WriteLine("invalid input");
    }
}
*/

/*
 Array:

 string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
 */

/*
Array: 

 string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
*/

/*
foreach: 

 string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/
/*

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
*/

/*
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
*/



using System.Globalization;

int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }
foreach (int score in andrewScores)
        {
            andrewSum += score;
        }
foreach (int score in emmaScores)
        {
            emmaSum += score;
        }
foreach (int score in loganScores)
        {
            loganSum += score;
        }

decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal andrewScore = (decimal)andrewSum / currentAssignments;
decimal emmaScore = (decimal)emmaSum / currentAssignments;
decimal loganScore = (decimal)loganSum / currentAssignments;

string sophiaGrade = GetGrade(sophiaScore);
string andrewGrade = GetGrade(andrewScore);
string emmaGrade = GetGrade(emmaScore);
string loganGrade = GetGrade(loganScore);

decimal sophiaExtraCredit = 3.68m;
decimal andrewExtraCredit = 1.78m;
decimal emmaExtraCredit = 5.34m;
decimal loganExtraCredit = 1.92m;

decimal SophiaScoreAfterExtraCredit = sophiaScore + sophiaExtraCredit;
decimal andrewScoreAfterExtraCredit = andrewScore + andrewExtraCredit;
decimal emmaScoreAfterExtraCredit = emmaScore + emmaExtraCredit;
decimal loganScoreAfterExtraCredit = loganScore + loganExtraCredit;

string sophiaGradeExtraCredit = GetGrade(SophiaScoreAfterExtraCredit);
string andrewGradeExtraCredit = GetGrade(andrewScoreAfterExtraCredit);
string emmaGradeExtraCredit = GetGrade(emmaScoreAfterExtraCredit);
string loganGradeExtraCredit = GetGrade(loganScoreAfterExtraCredit);

Console.WriteLine("Student\t\tScore\tGrade\tExtra credit\tFinal score\tFinal grade\n");
Console.WriteLine("sophia:\t\t" + sophiaScore + "\t" + sophiaGrade + "\t(" + sophiaExtraCredit + " pts)\t" + SophiaScoreAfterExtraCredit + "\t" + sophiaGradeExtraCredit);
Console.WriteLine("andre:\t\t" + andrewScore + "\t" + andrewGrade + "\t(" + andrewExtraCredit + " pts)\t" + andrewScoreAfterExtraCredit + "\t" + andrewGradeExtraCredit);
Console.WriteLine("emma:\t\t" + emmaScore + "\t" + emmaGrade + "\t(" + emmaExtraCredit + " pts)\t" + emmaScoreAfterExtraCredit + "\t" + emmaGradeExtraCredit);
Console.WriteLine("logan:\t\t" + loganScore + "\t" + loganGrade + "\t(" + loganExtraCredit + " pts)\t" + loganScoreAfterExtraCredit + "\t" + loganGradeExtraCredit);

Console.WriteLine("Press the Enter key to exit");
Console.ReadLine();
    

    // her laver jeg en funktion som regner ud hvad deres karekter er i forhold til deres score
    //GetGrade har jeg lavet til en static metode hvilket metyder jeg kan bruge en uden at lave en instans af den
    // for at kalde metoden score skal man have en decimal som i dette tilfælde er deres score
static string GetGrade(decimal score)
{
    if (score >= 97)
        return "A+";
    else if (score >= 93)
        return "A";
    else if (score >= 90)
        return "A-";
    else if (score >= 87)
        return "B+";
    else if (score >= 83)
        return "B";
    else if (score >= 80)
        return "B-";
    else if (score >= 77)
        return "C+";
    else if (score >= 73)
        return "C";
    else if (score >= 70)
        return "C-";
    else if (score >= 67)
        return "D+";
    else if (score >= 63)
        return "D";
    else if (score >= 60)
        return "D-";
    else
        return "F";
}




