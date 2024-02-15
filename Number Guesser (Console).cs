public static void Main(string[] args) {
  int min = 1;
  int max = 10;
  Random rand = new Random();
  int pickedNumber = rand.Next(min, max+1);
  while (true) {
    Console.WriteLine("Pick a random number between "+min+" & "+max);
    string input = Console.ReadLine();
    int guess = Convert.ToInt32(input);
    
    if (guess > pickedNumber) {
    Console.WriteLine("Less");
    } else if (guess < pickedNumber) {
    Console.WriteLine("More");
    } else {
    Console.WriteLine("Correct!!");
    break;
    }
  }
}
