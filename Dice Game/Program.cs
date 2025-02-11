namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            double money = 5.00;
            int dice1 = 0;
            int dice2 = 0;
            int dice3 = 0;
            string playon = Console.WriteLine("Do you want to play for 20p? Press Y or N";
            Console.ReadLine();
            while (playon == "Y") {
                if (money >= 0.20) ;
                {
                    dice1 = rnd.Next(1, 7);
                    dice2 = rnd.Next(1, 7);
                    dice3 = rnd.Next(1, 7);
                    if (dice1 == dice2)
                    {
                        Console.WriteLine("You have won £1");
                        money += 1;
                    }
                    else if (dice1 == dice3)
                    {
                        Console.WriteLine("You have won £1");
                        money += 1;
                    }
                    else if (dice2 == dice3)
                    {
                        Console.WriteLine("You have won £1");
                        money += 1;
                    }
                    else if (dice3 == dice1 && dice3 == dice2)
                    {
                        Console.WriteLine("You have won £2");
                        money += 2;
                    }
                    else { 
                        Console.WriteLine("You won nothing...");
                    }
                }
                else ();
            }
        }
    }
}
