Console.WriteLine("Welcome to Guess The Number!");

Random rand = new Random();
int number = rand.Next(1, 20);

while (true) {
    try {
        Console.WriteLine("Type your answer:");
        string? rawAnswer = Console.ReadLine();
        int answer = Convert.ToInt32(rawAnswer);
        if (number == answer) {
            Console.WriteLine("You're right!");
            break;
        } 
        if (answer < 1 || answer > 20) {
            Console.WriteLine("Please only type numbers between 1 and 20.");
        }
        else {
            Console.WriteLine("Wrong!");
        }
    }
    catch (Exception e) {
        if (e is FormatException) {
            Console.WriteLine("Please only type numeric characters.");
        } else {
            Console.WriteLine(e);
        }
    }
}
