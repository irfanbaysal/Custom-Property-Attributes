using System;
using UnityEngine;

namespace PropertyAttributes
{
    public class RangeWithDecimalAttribute : PropertyAttribute
    {
        public readonly float Min;
        public readonly float Max;
        public readonly int Digit;

        public RangeWithDecimalAttribute(float min, float max,int digit)
        {
            Min = min;
            Max = max;
            Digit = digit;

            Min = (float)Math.Round(Min, Digit);
            Max = (float)Math.Round(Max, Digit);
            Digit = Mathf.Clamp(Digit, 0, 3);

        }
    }
}
    
