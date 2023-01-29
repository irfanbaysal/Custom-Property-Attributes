using System;
using UnityEditor;
using UnityEngine;

namespace PropertyAttributes.Editor
{
    [CustomPropertyDrawer(typeof(RangeWithDecimalAttribute))]
    public class RangeWithDecimalDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var range = (RangeWithDecimalAttribute)attribute;

            if (range == null) return;
            property.floatValue = (float)Math.Round(property.floatValue, range.Digit);

            if (property.propertyType == SerializedPropertyType.Float)
            {
                EditorGUI.Slider(position, property, range.Min, range.Max, label);
            }
            else
                EditorGUI.LabelField(position, label.text, "Use Range with float or int.");
        }
    }
}