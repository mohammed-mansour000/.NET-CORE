using AI;
using System;

namespace week_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Scanner();
            p.PlateNumberScanner += P_dania;
            p.PlateNumberScanner += P_sfarzo;
            p.BeforeScanning += P_BeforeScanning;
            p.AfterScanning += P_AfterScanning;
            p.Scan();

            //Jana j = new Jana(xyz);
            //j.Invoke("hamzi");
        }

        private static void P_AfterScanning()
        {
            Console.WriteLine("After Scanning...");
        }

        private static void P_BeforeScanning()
        {
            Console.WriteLine("Before Scanning... \n");
        }

        private static void P_dania(string plate)
        {
            Console.WriteLine(" + " + plate + " + ");
        }

        private static void P_sfarzo(string plate)
        {
            Console.WriteLine(" / " + plate + " / ");
        }

        public static void xyz(string x)
        {
            Console.WriteLine(x); 
        }
        
        public delegate void Jana(string msg);// it dictates what functions can be assigned to certain variable
    }
}
