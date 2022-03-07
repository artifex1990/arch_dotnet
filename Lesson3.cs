using System;

namespace architekt
{
    public class Lesson3
    {
        public static double[] solve(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            
            if (d > 0)
            {
                return new[] {(-b + Math.Sqrt(d) / 2 * a), (-b - Math.Sqrt(d) / 2 * a)};
            } 
            
            if (d == 0)
            {
                return new[] {(-b / 2 * a)};
            }
            
            return new double[0];
        }
    }
}