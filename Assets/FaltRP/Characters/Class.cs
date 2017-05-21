using FaltRP.Statistics;
using UnityEngine;

namespace FaltRP.Characters
{
	[CreateAssetMenu(fileName = "New Class", menuName = "ArcRP/Class", order = 901)]
	public class Class : ScriptableObject
	{
		/// <summary>
		/// Name of the class
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Header("Text Display")]
		private string _name;

		/// <summary>
		/// Description of the class
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Multiline]
		private string _description;

		/// <summary>
		/// Stat modifications conferred by the class
		/// </summary>
		[Header("Stat Mods")]
		[SerializeField]
		private Stats _statMods;
	}
}