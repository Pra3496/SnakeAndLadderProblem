namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n----------------------------START--------------------------\n");

            Console.WriteLine("\tWelcome To Snake and Ladder Game Application");

            Console.WriteLine("\n-----------------------------------------------------------\n");

            int pos = 0;  // Position
            int dice = 0; // Dice

           

            //Position Initializing

            Random random = new Random();

            dice = random.Next(1, 7);

            Console.WriteLine("The position of player starts: {0} and random number of Dice: {1}", pos, dice);

        }
    }
}


