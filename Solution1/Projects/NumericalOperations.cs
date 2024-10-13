using System;



public static class Operators
{
    public static float Percentage(this int num, int total)
    {
        return (float)num * 100 / total;
    }

    public static float Multiply(this int num, int SecondHand)
    {
        return (float)num * SecondHand;
    }

    public static double Division(this int num, double devisor)
    {
        return (double)num / devisor;
    }

}