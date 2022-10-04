using PrimeGeneratorApp;
using System.Diagnostics;

Console.WriteLine("Prime numbers in prime time!");

PrimeGenerator pg = new PrimeGenerator();
var swSequential = Stopwatch.StartNew();
pg.GetPrimesSequential(1, 1000000);
swSequential.Stop();

var swParallel = Stopwatch.StartNew();
pg.GetPrimesParallel(1, 1000000);
swParallel.Stop();

//-----------------------------------------------

var swSeq1To10Mil = Stopwatch.StartNew();
pg.GetPrimesSequential(1, 10000000);
swSeq1To10Mil.Stop();

var swPara1To10Mil = Stopwatch.StartNew();
pg.GetPrimesParallel(1, 10000000);
swPara1To10Mil.Stop();

//-----------------------------------------------

var swSeq1MilTo2Mil = Stopwatch.StartNew();
pg.GetPrimesSequential(1, 10000000);
swSeq1MilTo2Mil.Stop();

var swPara1MilTo2Mil = Stopwatch.StartNew();
pg.GetPrimesParallel(1, 10000000);
swPara1MilTo2Mil.Stop();

//-----------------------------------------------

var swSeq10MilTo20Mil = Stopwatch.StartNew();
pg.GetPrimesSequential(1, 10000000);
swSeq10MilTo20Mil.Stop();

var swPara10MilTo20Mil = Stopwatch.StartNew();
pg.GetPrimesParallel(1, 10000000);
swPara10MilTo20Mil.Stop();

// a
Console.WriteLine($"Sequential foreach loop | 1 - 1.000.000 | Time Taken : {swSequential.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | 1 - 1.000.000 | Time Taken : {swParallel.ElapsedMilliseconds} ms.\n");

// b
Console.WriteLine($"Sequential foreach loop | 1 - 10.000.000 | Time Taken : {swSeq1To10Mil.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | 1 - 10.000.000 | Time Taken : {swPara1To10Mil.ElapsedMilliseconds} ms.\n");

// c
Console.WriteLine($"Sequential foreach loop | 1.000.000 - 2.000.000 | Time Taken : {swSeq1MilTo2Mil.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | 1.000.000 - 2.000.000 | Time Taken : {swPara1MilTo2Mil.ElapsedMilliseconds} ms.\n");

// d
Console.WriteLine($"Sequential foreach loop | 10.000.000 - 20.000.000 | Time Taken : {swSeq10MilTo20Mil.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | 10.000.000 - 20.000.000 | Time Taken : {swPara10MilTo20Mil.ElapsedMilliseconds} ms.");

Console.ReadLine();

