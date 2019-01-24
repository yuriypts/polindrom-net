using System;

namespace GetTheLongestPolindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "abc_12ababa_pxmalayalam";

            Console.WriteLine(str.GetPolindrom());

            Console.ReadKey();
        }
    }
}
