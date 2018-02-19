using System;
using ISS.LIB;

public class Dice
{
    // Attributes
    private int faceUp;

    // Properties
    public string StrFaceUp
    {
        get
        {
            return Convert.ToString(GetFaceUp());
        }
    }
   
    public void Throw()
    {
        faceUp = MyMath.RNDInt(6) + 1; // add 1 for zero-indexed
    }

    // Constructors
    public Dice()
    {
        Throw();
    }

    // Methods
    public int GetFaceUp()
    {
        return faceUp;
    }
}

public class CoinApp
{
    public static void Main()
    {
        double target;
        double counter = 0;
        double hits = 0;

        Console.Write("What number do you want to obtain? ");
        target = Convert.ToDouble(Console.ReadLine());

        Dice a = new Dice();
        Dice b = new Dice();

        for (int i = 0; i < 100000; i++)
        {
            a.Throw();
            b.Throw();

            if ( ( a.GetFaceUp() + b.GetFaceUp() ) == target)
            {
                hits++;
            }
            counter++;
        }

        Console.WriteLine("The probability is {0:P}", hits / counter);
    }
}