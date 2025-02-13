Random toss = new Random();
int flip = toss.Next(0, 2);

Console.WriteLine(flip == 0 ? "Heads" : "Tails");