using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        //f1.SetTop(1);
        //Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        //f2.SetTop(5);
        //Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        //f3.SetTop(3);
        //f3.SetBottom(4);
        //Console.WriteLine(f3.GetTop());
        //Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // or 
        /*
        Fraction f3 = new Fraction();
        //f3.SetTop(3);
        //f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
        */
    }
}