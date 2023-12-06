using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Mathe
    {
        /// <summary>
        /// Summiere zwei Werte
        /// </summary>
        /// <param name="a">Summand 1</param>
        /// <param name="b">Summand 2</param>
        /// <returns>Summe</returns>        
        public static int Summieren(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtrahiere zwei Werte
        /// </summary>
        /// <param name="a">Minuend</param>
        /// <param name="b">Subtrahend</param>
        /// <returns>Differenz</returns>
        public static int Subtrahieren(int a, int b)
        {
            return a - b;
        }
        public static int Multiplizieren(int a, int b)
        {
            return (int)(a * b);
        }
        public static int Dividieren(int a, int b) 
        {
            //if (b == 0)
            //    throw new ArgumentException();

            return (int)(a / b); 
        }
    }
}
