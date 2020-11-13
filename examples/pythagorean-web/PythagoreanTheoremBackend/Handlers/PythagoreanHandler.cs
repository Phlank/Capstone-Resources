using System;
using System.Collections.Generic;
using System.Text;

namespace PythagoreanTheoremBackend.Handlers
{
    public class PythagoreanHandler
    {
        public static double GetHypotenuse(double sideOne, double sideTwo)
        {
            return Math.Sqrt(sideOne * sideOne + sideTwo * sideTwo);
        }
    }
}
