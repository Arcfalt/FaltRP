using UnityEngine;

namespace FaltRP.Abilities
{
	/// <summary>
	/// Container for a usable ability
	/// </summary>
	[CreateAssetMenu(fileName = "New Ability", menuName = "ArcRP/Ability", order = 1002)]
	public class Ability : ScriptableObject
	{
		/// <summary>
		/// Action point cost of the ability
		/// </summary>
		[SerializeField]
		private int _apCost;
	}
}