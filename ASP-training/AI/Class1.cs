using System;
using System.Collections.Generic;

namespace AI
{
    public delegate void Dummy();
    public delegate void Notify(string plate);
    public class Scanner
    {
        public event Notify PlateNumberScanner;//its like a box that will be filled from main class
        public event Dummy BeforeScanning;
        public event Dummy AfterScanning;
        public void Scan()
        {
            if(BeforeScanning != null)
            {
                this.BeforeScanning();
            }

            Console.WriteLine("Start Reading the Camera");
            Console.WriteLine("Detects all the Cars in the Image");
            Console.WriteLine("Get Plate # of each Car");
            List<string> oList_Plates = new List<string>()
            {
                "2324244", "645343", "1303232", "839232", "7126831","hamzi"
            };

            foreach (var item in oList_Plates)
            {
                if(this.PlateNumberScanner != null)
                {
                    this.PlateNumberScanner(item);
                }
            }

            Console.WriteLine("Reading image is done");
            Console.WriteLine("Save data into excel file");
            Console.WriteLine("wait 1 second, and Re-Do the same process \n");

            if (AfterScanning != null)
            {
                this.AfterScanning();
            }
        }
    }
}
