using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PropertyAttributes;
public class PropertyAttributesHandler : MonoBehaviour
{
    [SerializeField][Range(0,1)] private float defaultSlider;
    [SerializeField][RangeWithDecimal(0,1,1)] private float oneDigitSlider;
    [SerializeField][RangeWithDecimal(0,1,2)] private float twoDigitSlider;

    [SerializeField] [MinMaxSlider(0, 1,1)] private Vector2 oneDigitMinMaxSlider;
    [SerializeField] [MinMaxSlider(0, 1,2)] private Vector2 twoDigitMinMaxSlider;
}
