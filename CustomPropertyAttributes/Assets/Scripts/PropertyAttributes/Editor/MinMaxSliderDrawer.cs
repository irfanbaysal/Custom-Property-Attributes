using UnityEditor;
 using UnityEngine;
namespace PropertyAttributes.Editor
{

    [CustomPropertyDrawer(typeof(MinMaxSliderAttribute))]
    public class MinMaxSliderDrawer : PropertyDrawer
    {
        private const float ValueFieldHeight = 20;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.Vector2)
            {
                return base.GetPropertyHeight(property, label) + ValueFieldHeight;
            }
            else
            {
                return base.GetPropertyHeight(property, label);
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var range = property.vector2Value;
            var minValue = range.x;
            var maxValue = range.y;
            var attr = (MinMaxSliderAttribute)attribute;
            if (property.propertyType == SerializedPropertyType.Vector2)
            {

                EditorGUI.BeginChangeCheck();
                EditorGUI.MinMaxSlider(new Rect(position.x, position.y, position.width, position.height - ValueFieldHeight), label, ref minValue, ref maxValue, attr.MinLimit, attr.MaxLimit);
                if (EditorGUI.EndChangeCheck())
                {
                    range.x = minValue;
                    range.y = maxValue;
                    property.vector2Value = range;
                }
                  Rect valueRect = new Rect(position.x, position.y + position.height - ValueFieldHeight, position.width, ValueFieldHeight);
                  EditorGUI.LabelField(valueRect,  "Min : " +  minValue + " - " + "Max : " +  maxValue, EditorStyles.centeredGreyMiniLabel);
                  
            }
            else
            {
                EditorGUI.LabelField(position, label, "Use with Vector2 only.");
            }
       
        }
       
    }

}