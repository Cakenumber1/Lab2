using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;



namespace Calc
{        /// <summary>
         /// Contains 2 functions, provides kind of an interface for user.
         /// </summary>
         /// <value>Each function of the class gets a string. ParserM returns string. StartMenu is void function</value>
    public class Menu
    {
        Func func = new Func();
        /// <summary>
        /// Recognize and do what action user expects if its possible, if not reports about it.
        /// </summary>
        /// <value>ParserM gets a string from user, through StartMenu, and doubles from Func. ParserM returns string.</value>
        public string ParserM(string q)
        {
            if (q.Contains(" "))
            {
                return "Input nekorrektnii";
            }
            if (q.StartsWith("Sqrt(") && q.EndsWith(")"))
            {
                string f = q.Substring(5, q.Length - 6);

                try
                {
                    double r = Convert.ToDouble(f);
                    return func.Sqrt(r).ToString();
                }
                catch (FormatException)
                {
                    return ("Input nekorrektnii");
                }


            }
            if (q.Contains("+") || q.Contains("-") || q.Contains("*") || q.Contains("/") || q.Contains("^"))
            {
                string[] words = q.Split(new char[] { '+', '-', '*', '/', '^' });
                try
                {
                    double f = Convert.ToDouble(words[0]);
                    double s = Convert.ToDouble(words[1]);
                    string znak = q.Substring(words[0].Length, q.Length - words[0].Length - words[1].Length);
                    if (znak == "+") { return func.Sum(f, s).ToString(); }
                    if (znak == "-") { return func.Dif(f, s).ToString(); }
                    if (znak == "*") { return func.Comp(f, s).ToString(); }
                    if (znak == "/") { return func.Div(f, s).ToString(); }
                    if (znak == "^") { return func.Pow(f, s).ToString(); }
                    return "Chto-to poshlo ne tak";
                }
                catch (FormatException)
                {
                    return ("Input nekorrektnii");
                }


            }
            if (q.EndsWith("!"))
            {
                try
                {
                    double d = Convert.ToDouble(q.Substring(0, q.Length - 1));
                    return func.Fac(d).ToString();
                }
                catch (FormatException)
                {
                    return ("Input nekorrektnii");
                }


            }

            return "Input nekorrektnii";
        }
        /// <summary>
        /// Recognize and do what action user expects if its possible, if not reports about it, provides templates.
        /// </summary>
        /// <value>StartMenu gets strings from user, and strings from ParserM. Returns nothing, but prints in console the results.</value>
        public void StartMenu()
        {
            Console.WriteLine("Vibor deistvia");
            Console.WriteLine("1.Spravka");
            Console.WriteLine("2.Vvod virazhenia");
            Console.WriteLine("3.Zacrit'");
            bool stf = true;
            while (stf)
            {
                string rs = Console.ReadLine();
                if (rs == "1")
                {
                    Console.WriteLine("Sum: double+double");
                    Console.WriteLine("Dif: double-double");
                    Console.WriteLine("Comp: double*double");
                    Console.WriteLine("Dif: double/double");
                    Console.WriteLine("Sqrt: Sqrt(double)");
                    Console.WriteLine("Pow: double^double");
                    Console.WriteLine("Fac: double!");
                    //Sum double+double
                    //Dif double-double
                    //Comp double*double
                    //Div double/double
                    //Sqrt Sqrt(double)
                    //Pow double^double
                    //Fac double!
                }
                if (rs == "2")
                {
                    Console.WriteLine("VVodi");
                    Console.WriteLine(ParserM(Console.ReadLine()));
                }

                if (rs == "3")
                {
                    stf = false;
                }
                else
                {
                    Console.WriteLine("Podumai eshe");
                    Console.WriteLine("Vibor deistvia");
                    Console.WriteLine("1.Spravka");
                    Console.WriteLine("2.Vvod virazhenia");
                    Console.WriteLine("3.Stop'");

                }

            }
        }

    }
}