// See https://aka.ms/new-console-template for more information
using PrimeGeneratorApp;
using System.Diagnostics;

Console.WriteLine("Prime numbers in prime time!");

PrimeGenerator pg = new PrimeGenerator();
var swSequential = Stopwatch.StartNew();
List<long> PrimesSequential = pg.GetPrimesSequential(1, 1000000);
swSequential.Stop();

var swParallel = Stopwatch.StartNew();
List<long> PrimesParallel = pg.GetPrimesParallel(1, 1000000);
swParallel.Stop();

Console.WriteLine($"Classical foreach loop | Total prime numbers : {PrimesSequential.Count} | Time Taken : {swSequential.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | Total prime numbers : {PrimesParallel.Count} | Time Taken : {swParallel.ElapsedMilliseconds} ms.");


//foreach (var n in PrimesParallel)
//{
//    Console.WriteLine(n);
//}
Console.ReadLine();

