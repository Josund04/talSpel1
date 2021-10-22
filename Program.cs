using System;

namespace arbete_talSpel
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
           int guess = 0;
           string hej = "Gissa ett nummer mellan 1 till 100, och du kommer aldrig komma ur det här";
           int num = rand.Next(1,100);
           Console.WriteLine(hej);


           int i = 0;

           while(guess != num) //denna loopen håller på tills använaren gissat rätt
           {
               try
               {
                   guess = Convert.ToInt32(Console.ReadLine());

                   if (guess > num)
                   {
                       Console.WriteLine("För högt testa igen");
                   }
                   else
                   {
                       Console.WriteLine("För lågt försök igen");
                   }
               }
               catch
               {
                   Console.WriteLine("Du måste skriva ett nummer inte en bokstav");
                   i--;
               }
               i++;
           }
           Console.WriteLine("Bra jobbat du hade rätt det tog " + i +" försök för dig");
           Console.ReadLine();
        }

    }
}
