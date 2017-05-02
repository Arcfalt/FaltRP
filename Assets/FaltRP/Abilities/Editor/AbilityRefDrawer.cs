using UnityEditor;
using UnityEngine;

namespace FaltRP.Abilities.Editor
{
	/// <summary>
	/// Custom inspector property drawer to display an ability reference
	/// </summary>
	[CustomPropertyDrawer(typeof(AbilityRef))]
	public class AbilityRefDrawer : PropertyDrawer
	{
		/// <summary>
		/// Draw the class as a string input that fills into the ID of the ability reference
		/// </summary>
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginProperty(position, label, property);
			SerializedProperty idProp = property.FindPropertyRelative("_abilityId");
			EditorGUI.PropertyField(new Rect(position.x, position.y, position.width, position.height), idProp, label);
			EditorGUI.EndProperty();
		}
	}
}