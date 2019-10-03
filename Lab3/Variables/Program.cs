using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations p. 68
            int myInt;
            long myLong = 0;
            double myDouble = 0.0;
            string myStr = "some text";

            #endregion

            #region printing p.63-67
            // build errors and warnings
            //Console.WriteLine("myInt: {0}", myInt);

            Console.WriteLine("myLong:   {0}", myLong);

            // formatting example
            // c stands for currency
            Console.WriteLine("myLong c: {0:c}", myLong);
            //d6 tells how many places out to go for the decimal
            Console.WriteLine("myLong d6: {0:d6}", myLong);
            //x stands for hexidecimal
            Console.WriteLine("myLong x: {0:X}", 31);
            // if you write nothing in parameters you just get a blankl line
            Console.WriteLine();

            #endregion
            #region casting p.88-90

            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1);
            // so if i add the value of myByte of 255 to 1, it starts over
            // it can only contain 255, so 256 is not valid, you get to the end instead
            // sort of like an odometer clocking over?
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);

            #endregion
            #region strings p. 79-88

            string hello = "hello";
            string world = "world";
            string str;

            Console.WriteLine("length of hello: {0}", hello.Length);
            // different ways to do comparisions, can use == or property of Equals
            Console.WriteLine("test ==: {0}", hello == "hello2");
            Console.WriteLine("test ==: {0}", hello == "hello");
            // built in comparison function Equals
            Console.WriteLine("test ==: {0}", hello.Equals("hello"));
            Console.WriteLine("test ==: {0}", hello.Equals("Hello"));

            //built in compare function, uses lexographic order to compare
            Console.WriteLine("test ==: {0}", hello.CompareTo(world));
            Console.WriteLine("test ==: {0}", hello.CompareTo(hello));

            // concatenation
            str = hello + " " + world;
            Console.WriteLine(str);

            // verbatim
            // the verbatim sign with the @ gets around having to use an escape backslash to type a backslash
            // normally you need to type a backslash in order to display a backslash
            // with the @ you don't need to type the backslash for a backslash
            // you would use this with typing paths for example
            str = @"c:\MyApp\bin\debug";
            string str2 = "c:\\MyApp\\bin\\debug";
            #endregion

        }
    }
}
