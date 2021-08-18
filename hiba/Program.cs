using System; // It's just a way to shorten your code
class dania
    {
        static void Main()
        {        
            //  Types (built in) like Int ,double, float, boolean are just classes provided by .net core 
            //  Any class that "you" create (like Rectangle) is named Custom Type
            
            // antoun.maroun.com.Rectangle rc = new antoun.maroun.com.Rectangle();
            //rc.width = 10;
            //rc.height = 5;
            antoun.maroun.com.Rectangle rc = new antoun.maroun.com.Rectangle(60,80);
            
            
            double surface = rc.CalculateSurface();
            Console.WriteLine("the Surface of this Rectangle ");
            Console.WriteLine(surface);

            var d = antoun.maroun.com.Utlz.GetNow();
            Console.WriteLine(d);

            
            antoun.maroun.com.Circle cr = new antoun.maroun.com.Circle();
            cr.radius = 5.5;
            System.Console.WriteLine(cr.CalculateSurface());
            
        }
    }