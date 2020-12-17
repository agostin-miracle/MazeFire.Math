using System;
using System.Collections.Generic;

namespace MazeFire
{
    public static partial class Math
    {

        /// <summary>
        /// Divisores de um número
        /// </summary>
        /// <param name="value">Número</param>
        /// <returns>Lista de Divisores de um número</returns>
        public static PrimeDividers Dividers(int value)
        {
            List<long> b = Primes(100);
            PrimeDividers r = new PrimeDividers();
            long n = value;
            int i = 0;
            while (n != 1)
            {
                int divider = Convert.ToInt32(b[i]);
                Console.WriteLine("divider {0}", i);

                if ((n % divider) == 0)
                {

                    PrimeDivider pd = new PrimeDivider(divider, 1);
                    r.Add(pd);
                    n /= divider;
                }
                else
                    i++;
            }
            return r;
        }


        public static double MDC(params int[] n)
        {
            int indexer = -1;
            double value = 0;
            int size = n.Length;
            double val = 0;
            PrimeDividers[] r = new PrimeDividers[size];

            for (int i = 0; i < n.Length; i++)
            {
                r[i] = Dividers(n[i]);
            }

            //if (size > 1)
            //{
            for (int i = 0; i < r[0].Content.Count; i++)
            {
                //value = Math.Pow(r[0].Content[i].Divider, r[0].Content[i].Exponent);
                for (int j = 1; j < size; j++)
                {
                    int l = r[j].Content.Count;
                    for (int k = 0; k < l; k++)
                    {
                        if ((r[j].Content[k].Divider == r[0].Content[i].Divider)
                            && (r[j].Content[k].Exponent == r[0].Content[i].Exponent))
                        {
                            val = System.Math.Pow(r[j].Content[k].Divider, r[j].Content[k].Exponent);
                            if (val > value)
                            {
                                indexer = i;
                                value = val;
                                Console.WriteLine("divider pow({0},{1})", r[j].Content[k].Divider, r[j].Content[k].Exponent);
                            }
                        }
                    }
                }

            }
            //}

            if (value == 0)
                return 1;
            return value;
        }

    }


    /// <summary>
    ///  Retêm a Lista de Divisores de um número
    /// </summary>
    public class PrimeDividers
    {
        /// <summary>
        /// Conteúdo de Divisores de um numero
        /// </summary>
        public List<PrimeDivider> Content = new List<PrimeDivider>();

        /// <summary>
        /// Adiciona um divisor de uma número à lista
        /// </summary>
        /// <param name="item"></param>
        public void Add(PrimeDivider item)
        {
            int j = 0;
            for (int i = 0; i < Content.Count; i++)
            {
                if (Content[i].Divider == item.Divider)
                {
                    Content[i].Exponent = Content[i].Exponent + 1;
                    j = 1;
                    break;
                }
            }

            if (j == 0)
            {
                Content.Add(item);
            }
        }
    }


    /// <summary>
    /// Classe de Rtenção de um divisor de um número
    /// </summary>
    public class PrimeDivider
    {
        /// <summary>
        /// Divisor
        /// </summary>
        public int Divider { get; set; } = 0;
        /// <summary>
        /// Número de Expoentes (Potência de um número)
        /// </summary>
        public int Exponent { get; set; } = 0;

        /// <summary>
        /// Construtor Base
        /// </summary>
        public PrimeDivider() { }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="divider">Divisor</param>
        /// <param name="exponent">Número de Expoentes</param>
        public PrimeDivider(int divider, int exponent)
        {
            this.Divider = divider;
            if (this.Exponent != 0)
                this.Exponent = this.Exponent + 1;
            else
                this.Exponent = exponent;
        }
    }


}