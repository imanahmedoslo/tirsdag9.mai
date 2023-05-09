using System.ComponentModel.Design;

namespace tirsdag9.mai
{
    internal class Program
    {
        static string MyString = "krokkodille";
        static int firstNumber;
        static int secondNumber;
        static void Main(string[] args)
        {
            // printBokstaver();
            krokkodilleSpill(firstNumber, secondNumber);
        }

        static void printBokstaver()
        {
            foreach(var item in MyString)
            {
                Console.WriteLine(item);
            }
        }

        static void krokkodilleSpill(int x, int y)
        {
            Console.WriteLine("Du får to tall, skriv inn om det det første tallet er større, mindre enn eller lik det andre tallet. skrive hva som helst annet for å avslutte spillet.");
            var playerAnswer = "";
            var possibleAnswers = new string[] { ">", "<", "=" };
            var poeng = 0;
            do
            {
                x= new Random().Next(1, 12);
                y= new Random().Next(1, 12);
                Console.WriteLine($"{x} _ {y}");
                 playerAnswer = Console.ReadLine();
                if(x > y)
                {
                 switch(playerAnswer)
                    {
                        case string s when s == possibleAnswers[0] :
                            poeng++;
                            Console.WriteLine($"riktig svar, du har nå {poeng} poeng.");
                            break;
                        case string s when s == possibleAnswers[1]|| s == possibleAnswers[2]:
                            poeng--;
                            Console.WriteLine($"feil svar, riktig svar er {possibleAnswers[0]}, du har nå {poeng} poeng.");
                            break;
                    }  
                }
                else if (x<y)
                {
                    switch (playerAnswer)
                    {
                        case string s when s == possibleAnswers[1]:
                            poeng++;
                            Console.WriteLine($"riktig svar, du har nå {poeng} poeng.");
                            break;
                        case string s when s == possibleAnswers[0] || s == possibleAnswers[2]:
                            poeng--;
                            Console.WriteLine($"feil svar, riktig svar er {possibleAnswers[1]}, du har nå {poeng} poeng.");
                            break;
                    }

                } else if (x==y)
                {
                    switch (playerAnswer)
                    {
                        case string s when s == possibleAnswers[2]:
                            poeng++;
                            Console.WriteLine($"riktig svar, du har nå {poeng} poeng.");
                            break;
                        case string s when s == possibleAnswers[1] || s == possibleAnswers[0]:
                            poeng--;
                            Console.WriteLine($"feil svar, riktig svar er {possibleAnswers[2]}, du har nå {poeng} poeng.");
                            break;
                    }
                }
            } while ((playerAnswer==">"|| playerAnswer =="<"|| playerAnswer =="="|| playerAnswer =="")&&poeng<15);
            Console.WriteLine($"game over, du fikk {poeng} poeng");
            
        }
    }
}