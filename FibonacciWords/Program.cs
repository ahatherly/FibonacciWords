using System.Diagnostics;
using System.Text;

const bool SHOW_ALL_WORDS = false;
const bool SHOW_ALL_TIMINGS = false;

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("             Calculating Fibonacci Words             ");
Console.WriteLine("-----------------------------------------------------");

Console.Write("Enter a the number of iterations to generate: ");
string inputString = Console.ReadLine();

int iterations = 0;
try
{
    iterations = int.Parse(inputString);
    if (iterations < 2)
    {
        throw new Exception();
    }
}
catch (Exception ex)
{
    Console.WriteLine("Input not valid, aborting.");
    Environment.Exit(1);
}

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

int iteration = 0;
string wordBefore = "";
string previousWord = "";
string word = "";

while (iteration++ < iterations)
{
    if (iteration == 1)
        word = "a";
    else if (iteration == 2)
        word = "b";
    else
    {
        word = wordBefore + previousWord;
    }
    wordBefore = previousWord;
    previousWord = word;

    if (SHOW_ALL_WORDS) 
        Console.WriteLine(word);
    if (SHOW_ALL_TIMINGS)
        Console.WriteLine("Time for {0} iterations: {1} seconds", iteration, (stopWatch.ElapsedMilliseconds/1000));
}

int a = 0;
int b = 0;
foreach (char c in word)
{
    if (c == 'a')
        a++;
    if (c == 'b')
        b++;
}

Console.WriteLine("There are {0} a's and {1} b's", a, b);