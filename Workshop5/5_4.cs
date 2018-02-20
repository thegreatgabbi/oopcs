using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    // Note the overloaded arithmetic operators(+, -, * and /).
    // - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/overloadable-operators

    // - Include an overriding method ToString().
    // - How does these make using Rational easier?
    // Instead of ToStr() in Exercise 3, you can just use ToString()
    // to return a Rational object in the format x / y.


    public class Rational
    {
        private int numerator, denominator;

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public static Rational operator +(Rational num1, Rational num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int sum = numer1 + numer2;
            Rational result = new Rational(sum, commonDenom);
            return result;
        }

        public static Rational operator -(Rational num1, Rational num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int difference = numer1 - numer2;
            Rational result = new Rational(difference, commonDenom);
            return result;
        }

        public static Rational operator *(Rational num1, Rational num2)
        {
            int numer = num1.numerator * num2.GetNumerator();
            int denom = num1.denominator * num2.GetDenominator();
            Rational result = new Rational(numer, denom);
            return result;
        }

        public static Rational operator /(Rational num1, Rational num2)
        {
            int numer = num2.GetDenominator();
            int denom = num2.GetNumerator();

            Rational r = new Rational(numer, denom);
            Rational result = num1 * r;
            return result;
        }

        public override string ToString()
        {
            string result;

            if (numerator == 0)
                result = "0";
            else
            {
                if (denominator == 1)
                    result = numerator.ToString();
                else
                    result = numerator + "/" + denominator;
            }
            return result;
        }

        public Rational(int numer, int denom)
        {
            if (denom == 0)    // set denominator to 1 if
                denom = 1;      // argument is zero
            if (denom < 0)
            {   // make numerator "store" the sign
                numer = numer * -1;
                denom = denom * -1;
            }
            numerator = numer;
            denominator = denom;
            Reduce();          // calling a private method
        }

        private void Reduce()
        {
            if (numerator != 0)
            {
                int common = HCF(Math.Abs(numerator), denominator);
                numerator = numerator / common;
                denominator = denominator / common;
            }
        }

        private int HCF(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            return num1;
        }
    }
}
