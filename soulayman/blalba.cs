using System;
namespace  alabdallah.soulayman.com
{
    public class Rectangle
{
    public double width {get;set;} 
    public double height{get;set;} 


    // Overloading is a smart way to have more than one function having the same name!!!!!!
    // BUT DIFFER IN THE NUMBER OF PARAMTERS & TYYPES OF PARAMETERS
    public double CalculateSurface() // <-- this named Method Signature
    {
        return this.width * this.height;
    }
    public int CalculateSurface(int x)
    {   
        return (int)(this.width) * (int)this.height;
    }
}
}
