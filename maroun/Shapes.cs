using System;
namespace antoun.maroun.com
{
    public class Shape
    {
        public string Background_Color {get;set;}
    }

    public class Rectangle : Shape
    {
        public int width;
        public int height;
        
        // Constructor
        // It has the same name as its class
        // It doesn't return even void
        public Rectangle() 
        {
            Console.WriteLine("Ana El Constructor!!!");
        }

        public Rectangle(int w, int h)  // <-- Overloading
        {
            this.width = w;
            this.height = h;
            Console.WriteLine("Ana teni  Constructor!!!");
        }

        public int CalculateSurface()
        {
            return this.width * this.height;
        }
    }

    public class Square : Rectangle
    {
         public int CalculateSurface()
        {
            if (this.width != this.height)
            {
                Console.WriteLine("A Square has to have the same width & hight");
                return 0; // <-- this a smart way to stop the execution of a certain function
            }
            return this.width * this.height;
        }
    }

    public class Circle : Shape
    {
        public double radius;

        public double CalculateSurface()
        {
            return 3.14 * (this.radius * this.radius);
        }
    }

    public static class Utlz
    {
        public static DateTime GetNow(){
            DateTime x = new DateTime();                                                
            return x;
        }

        public static int xyz()
        {
            int x = 1;
            return x;
        }

        public static void sendEmail(string from , string to , string title , string content)
        {

        }

        public static void sendEmail(string from , string to , string title , string content , string cc)
        {

        }

        public static void sendEmail(string from , string to , string title , string content , string cc , string bcc)
        {

        }

        public static void sendEmail(string from , string to , string title , string content , string cc , string bcc , string filepath)
        {

        }
    }
}