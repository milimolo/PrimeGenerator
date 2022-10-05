using PrimeGeneratorApp;
using System.Diagnostics;

Console.WriteLine("Prime numbers in prime time!");

Console.WriteLine("Find primes.");
Console.WriteLine("Input the number you would like to start finding primes from: ");
long startNum = -1;
startNum = Convert.ToInt32(Console.ReadLine());

while (startNum < 0)
{
    Console.WriteLine("Please input a number above 0.");
    startNum = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Your start number: " + startNum);
Console.WriteLine("Input the number you would like to end the search for primes: ");
long endNum = -1;
endNum = Convert.ToInt32(Console.ReadLine());

while (endNum < startNum)
{
    Console.WriteLine("Please input a number above the start number.");
    endNum = Convert.ToInt32(Console.ReadLine());
}

PrimeGenerator pg = new PrimeGenerator();
var primes = pg.GetPrimesParallel(startNum, endNum);

int counter = 0;
int maxLength = 10;

Console.WriteLine("Your primes: ");

foreach (var prime in primes)
{
    counter++;
    if (counter == maxLength)
    {
        Console.Write("\n" + prime + " | ");
        counter = 0;
    }
    else { Console.Write(prime + " | "); }
}

/**
 * Uncomment the below code to test for assignment 3 tasks.
 */
//pg.TestAssignment3();

Console.ReadLine();

