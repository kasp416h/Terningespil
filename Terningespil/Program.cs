using static Terningespil.Dice;
namespace Terningespil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange terninger vil du slå med");
            int diceCount = Int32.Parse(Console.ReadLine());

            int trys = 0;

            while (true)
            {
                List<int> rolls = new List<int>();

                for (int index = 0; index < diceCount; index++)
                {
                    var dice = new Dice(6);
                    rolls.Add(dice.Roll());
                }

                bool isAllSix = true;

                foreach (int roll in rolls)
                {
                    Console.Write(roll + " ");
                    if (roll != 6) 
                    { 
                        isAllSix = false;
                    }
                }

                Console.WriteLine();
                trys++;

                if (isAllSix)
                {
                    Console.WriteLine(trys);
                    break;
                } else
                {
                    continue;
                }
            }
            
        }
    }
}