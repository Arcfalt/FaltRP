using FaltRP.Enums;
using FaltRP.Statistics;
using UnityEngine;

namespace FaltRP.Characters
{
	[CreateAssetMenu(fileName = "New Character", menuName = "ArcRP/Character", order = 1000)]
	public class Character : ScriptableObject
	{
		/// <summary>
		/// Base stats of the character
		/// </summary>
		[Header("Statistics")]
		[SerializeField]
		private Stats _baseStats;

		/// <summary>
		/// Name of the character
		/// </summary>
		[SerializeField]
		private string _name;

		/// <summary>
		/// Get the base stat of this character by type
		/// </summary>
		/// <param name="type">Stat type to get</param>
		/// <returns>Base stat of the character from given stat type</returns>
		public int GetBaseStat(Stat type)
		{
			return _baseStats[type];
		}
	}
}