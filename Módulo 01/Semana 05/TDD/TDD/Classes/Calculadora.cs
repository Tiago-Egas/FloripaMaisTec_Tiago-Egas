using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Classes
{
    public class Calculadora
    {
        /// <summary>
        /// It adds two numbers together.
        /// </summary>
        /// <returns>
        /// The result of the sum operation.
        /// </returns>
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// It adds two numbers together.
        /// </summary>
        /// <returns>
        /// The result of the division operation.
        /// </returns>
        public static decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// It returns a boolean value that indicates whether the first parameter is divisible by the
        /// second parameter
        /// </summary>
        /// <returns>
        /// The result of the modulo operation.
        /// </returns>
        public static bool DivisivelPor(int dividendo, int divisor)
        {
            bool result = dividendo % divisor == 0 ? true : false;

            return result;
        }
    }
}
