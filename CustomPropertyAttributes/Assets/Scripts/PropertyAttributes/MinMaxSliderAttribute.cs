using UnityEngine;
namespace PropertyAttributes
{

    public class MinMaxSliderAttribute : PropertyAttribute
    {
        public float MinLimit;
        public float MaxLimit;

        public MinMaxSliderAttribute(float minLimit, float maxLimit)
        {
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
        }
    }
}