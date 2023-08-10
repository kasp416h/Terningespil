namespace Terningespil
{
    public class Dice
    {
        private int sides;
        private Random rnd = new Random();
        public Dice(int numberOfSides)
        {
            sides = numberOfSides;
        }
        public int Roll()
        {
            return rnd.Next(1, sides + 1);
        }
    }
}
