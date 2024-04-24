using System.Net.NetworkInformation;

namespace MathsLib;

public class Maths
{
    protected internal double PI  = 3.14;
    internal double G = 9.0;
    public double CalculateWeight(int mass)
    {
        double weight  = mass*G;
        return weight;
    }
}
