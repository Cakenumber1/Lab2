using System;
using System.Collections.Generic;

namespace Calc
{        /// <summary>
         /// Contains 7 functions of different maths actions.
         /// </summary>
         /// <value>Each function of the class gets 1 or 2 doubles and always returns 1 double</value>
    public class Func
    {
        /// <summary>
        /// Counts the summary of 2 numbers.
        /// </summary>
        /// <value>Gets 2 doubles, returns 1 double.</value>
        public double Sum(double a, double b) { return a + b; }
        /// <summary>
        /// Counts the differance of 2 numbers.
        /// </summary>
        /// <value>Gets 2 doubles, returns 1 double.</value>
        public double Dif(double a, double b) { return a - b; }
        /// <summary>
        /// Counts the composition of 2 numbers.
        /// </summary>
        /// <value>Gets 2 doubles, returns 1 double.</value>
        public double Comp(double a, double b) { return a * b; }
        /// <summary>
        /// Counts the quotient of 2 numbers.
        /// </summary>
        /// <value>Gets 2 double, returns 1 double.</value>
        public double Div(double a, double b) { return a / b; }
        /// <summary>
        /// Counts the square root a number.
        /// </summary>
        /// <value>Gets 1 double, returns 1 double.</value>
        public double Sqrt(double a) { return Math.Sqrt(a); }
        /// <summary>
        /// Counts the pervii double v stepeni vtorogo.
        /// </summary>
        /// <value>Gets 2 doubles, returns 1 double.</value>
        public double Pow(double a, double b) { return Math.Pow(a, b);}
        /// <summary>
        /// Counts the factorial of a number.
        /// </summary>
        /// <value>Gets 1 double, returns 1 double.</value>
        public double Fac(double a) { int ans=1; for (int i = 1; i <= a; i++) { ans *= i; } return ans; }
        /// <summary>
        /// Counts sin of an angle.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double Sin(double a) { return Math.Sin(a); }
        /// <summary>
        /// Counts cos of an angle.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double Cos(double a) { return Math.Cos(a); }
    }
}
