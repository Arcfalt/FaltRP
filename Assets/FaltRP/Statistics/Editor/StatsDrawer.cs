using System;
using FaltRP.Constants;
using FaltRP.Constants.Editor;
using FaltRP.Enums;
using UnityEditor;
using UnityEngine;

namespace FaltRP.Statistics.Editor
{
	/// <summary>
	/// Custom inspector property drawer to display stats
	/// </summary>
	[CustomPropertyDrawer(typeof(Stats))]
	public class StatsDrawer : PropertyDrawer
	{
		private const int _PER_ROW = EditorConstants.STATS_PER_ROW;
		private const int _ROW_HEIGHT = EditorConstants.DRAWER_ROW_HEIGHT;

		/// <summary>
		/// Render the stat array as a grid instead of an array
		/// </summary>
		public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
		{
			EditorGUI.BeginProperty(pos, label, prop);

			SerializedProperty arrayProp = prop.FindPropertyRelative("_stats");
			if (!arrayProp.isArray) return;

			if (arrayProp.arraySize != StatConsts.STAT_AMOUNT)
			{
				arrayProp.arraySize = StatConsts.STAT_AMOUNT;
			}

			float size = pos.width / _PER_ROW;
			float halfSize = size * .5f;

			for (int i = 0; i < StatConsts.STAT_AMOUNT; i++)
			{
				string name = Enum.GetName(typeof(Stat), i);
				SerializedProperty statProp = arrayProp.GetArrayElementAtIndex(i);

				int rows = i / _PER_ROW;
				float xPos = size * (i % _PER_ROW);

				EditorGUI.LabelField(new Rect(pos.x + xPos, pos.y + _ROW_HEIGHT * rows, halfSize, _ROW_HEIGHT), name);
				EditorGUI.PropertyField(new Rect(pos.x + xPos + halfSize, pos.y + _ROW_HEIGHT * rows, halfSize, _ROW_HEIGHT), statProp, new GUIContent());
			}

			EditorGUI.EndProperty();
		}

		/// <summary>
		/// Find the desired pixel height of the drawer
		/// </summary>
		/// <returns>Pixel height of the display</returns>
		public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
		{
			int rows = Mathf.CeilToInt(StatConsts.STAT_AMOUNT / (float)_PER_ROW);
			return rows * _ROW_HEIGHT;
		}
	}
}