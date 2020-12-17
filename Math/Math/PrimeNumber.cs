using System.Collections.Generic;

namespace MazeFire
{
    /// <summary>
    /// Números Primos
    /// </summary>
    public static partial class Math
    {

        /// <summary>
        /// Lista de Números Primos
        /// </summary>
        /// <param name="n">Limite de Números Primos</param>
        /// <returns>Lista de Números Primos</returns>

        public static List<long> Primes(long n)
        {
            List<long> r = new List<long>();

            long i = 1;
            long j = 1;
            while (i <= n)
            {
                if (IsPrime(j))
                {
                    r.Add(j);
                    i++;
                }
                j++;
            }
            return r;
        }


        /// <summary>
        /// Retorna true, se um número é primo
        /// </summary>
        /// <param name="n">Número</param>
        /// <returns>true, se o número é primo</returns>
        public static bool IsPrime(long n)
        {
            int _count = 0;
            for (long i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    _count++;
                }
            }
            return (_count == 2);
        }
    }
}
