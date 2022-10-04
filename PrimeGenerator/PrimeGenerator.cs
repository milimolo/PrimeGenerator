using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGeneratorApp
{
    public class PrimeGenerator
    {

        public List<long> GetPrimesSequential(long first, long last)
        {
            var numbers = Enumerable.Range((int)first, (int)(last))
                .Where(number => IsPrime(number) && number <= last)
                .ToList();

            List<long> primes = numbers.Select(i => (long)i).ToList();
            primes.Sort();

            return primes;
        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            var numbers = Enumerable.Range((int)first, (int)(last)).ToList();

            var primeNumbers = new ConcurrentBag<long>();

            Parallel.ForEach(numbers, number =>
            {
                if (IsPrime(number) && number <= last)
                {
                    primeNumbers.Add(number);
                }
            });

            List<long> primes = primeNumbers.Select(i => (long)i).ToList();
            primes.Sort();
            return primes;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
