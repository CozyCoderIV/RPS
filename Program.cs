class RPS
{
    // Attributes
    // Constructor
    // Methods

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the C# Rock, Paper, Scissors Program.");

        String[] options = { "Rock", "Paper", "Scissors" };

        bool gamestart = true;

        while (gamestart)
        {

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("[1] : Rock");
            Console.WriteLine("[2] : Paper");
            Console.WriteLine("[3] : Scissors\n");

            int playerOption = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int computerOption = random.Next(1, 4);

            Console.Write("\nPlayer: " + options[playerOption -1]);
            Console.Write("\nComputer: " + options[computerOption -1]);

            if (options[playerOption - 1] == options[computerOption - 1])
            {
                Console.WriteLine("\n\nIt's A Draw!!");
            } else
            {
                if (options[playerOption - 1] == "Rock" && options[computerOption - 1] == "Paper")
                {
                    Console.WriteLine("\n\nComputer Wins!!");
                }
                if (options[playerOption - 1] == "Rock" && options[computerOption - 1] == "Scissors")
                {
                    Console.WriteLine("\n\nPlayer Wins!!");
                }
                if (options[playerOption -1] == "Paper" && options[computerOption -1] == "Rock") {
                    Console.WriteLine("\n\nPlayer Wins !! ");
                }
                if (options[playerOption -1] == "Paper" && options[computerOption -1] == "Scissors") {
                    Console.WriteLine("\n\nComputer Wins !! ");
                }
                if (options[playerOption - 1] == "Scissors" && options[computerOption - 1] == "Paper") {
                    Console.WriteLine("\n\nPlayer Wins !! ");
                }
                if (options[playerOption -1] == "Scissors" && options[computerOption -1] == "Rock") {
                    Console.WriteLine("\n\nComputer Wins !! ");
                }
            }

            Console.WriteLine("\nWould you like to play again ?");
            Console.WriteLine("[Y] : yes");
            Console.WriteLine("[N] : no\n");

            char playerResponse = Convert.ToChar(Console.ReadLine());
            if (playerResponse == 'N')
            {
                gamestart = false;
            }
        }

        Console.WriteLine("\nThanks for Playing !!!");

        Console.ReadKey();
    }
}