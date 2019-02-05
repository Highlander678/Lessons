using System;
using System.Globalization;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberformtinfo = new NumberFormatInfo()
            {

                NumberDecimalSeparator = "."


            };

            string ID = "2.1";
            string ID_1 = "3.2";

            //double A = Convert.ToDouble(ID, numberformtinfo);
            double A = double.Parse(ID, numberformtinfo);
            double B = double.Parse(ID_1, numberformtinfo);

            Console.WriteLine("{0}+{1} = {2}", A, B, A + B);



            Console.ReadKey();
        }
    }
}
