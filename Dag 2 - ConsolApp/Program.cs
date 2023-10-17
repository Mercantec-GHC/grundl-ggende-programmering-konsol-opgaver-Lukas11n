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


/*
her bliver der taget brug af (Math) Math.Max i dette tilfælde for at få største verdi af de to veriabler
 
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/

