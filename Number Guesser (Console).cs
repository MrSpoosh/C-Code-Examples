namespace Project
{
    class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("What's Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+name+" We are playing a number guessing game");
            Console.WriteLine("Pick a min number");
            string minString = Console.ReadLine();
            Console.WriteLine("Pick a max number");
            string maxString = Console.ReadLine();

            int min = Convert.ToInt16(minString);
            int max = Convert.ToInt16(maxString);

            Random rand = new Random();
            int pickedNumber = rand.Next(min, max+1);
            Console.WriteLine("Pick a random number between "+min+" & "+max);

            while (true) {
                string input = Console.ReadLine();
                if (input == "/c") {Console.WriteLine("The number was "+pickedNumber); break;}

                int guess = Convert.ToInt16(input);

                if (guess > pickedNumber) {
                    Console.WriteLine("Less");
                } else if (guess < pickedNumber) {
                    Console.WriteLine("More");
                } else {
                    Console.WriteLine("Correct!");
                    break;
                }
            }
        }
    }
}
