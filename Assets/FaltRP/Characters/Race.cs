using FaltRP.Statistics;
using UnityEngine;

namespace FaltRP.Characters
{
	[CreateAssetMenu(fileName = "New Race", menuName = "ArcRP/Race", order = 900)]
	public class Race : ScriptableObject
	{
		/// <summary>
		/// Name of the race
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Header("Text Display")]
		private string _name;

		/// <summary>
		/// Description of the race
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Multiline]
		private string _description;

		/// <summary>
		/// Stat modifications conferred by the race
		/// </summary>
		[Header("Stat Mods")]
		[SerializeField]
		private Stats _statMods;
	}
}