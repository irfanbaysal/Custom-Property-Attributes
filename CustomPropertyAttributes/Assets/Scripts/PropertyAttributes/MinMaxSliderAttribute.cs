using System;
using UnityEngine;
namespace PropertyAttributes
{
    public class MinMaxSliderAttribute : PropertyAttribute
    {
        public readonly float MinLimit;
        public readonly float MaxLimit;
        public readonly int Digit;

        public MinMaxSliderAttribute(float minLimit, float maxLimit,int digit)
        {
            MinLimit = minLimit;
            MaxLimit = maxLimit;
            Digit = digit;
            
            MinLimit = (float)Math.Round(MinLimit, Digit);
            MaxLimit = (float)Math.Round(MaxLimit, Digit);
            Digit = Mathf.Clamp(Digit, 0, 3);
        }
    }
}