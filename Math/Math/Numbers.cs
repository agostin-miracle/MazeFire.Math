namespace MazeFire
{
    /// <summary>
    /// Números
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Calcula o Fatorial de um número
        /// </summary>
        /// <param name="n">Número inteiro</param>
        /// <returns>int</returns>
        public static int Fatorial(int n)
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }

        /// <summary>
        /// Sequência de Fibonacci
        /// </summary>
        /// <param name="n">Iterações</param>
        /// <returns>o enésimo valor da sequênica de fibonacci</returns>
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}