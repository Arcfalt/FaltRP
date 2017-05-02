using System;
using UnityEngine;

namespace FaltRP.Abilities
{
	/// <summary>
	/// Reference to an ability
	/// </summary>
	[Serializable]
	public class AbilityRef
	{
		/// <summary>
		/// ID of the ability to reference
		/// </summary>
		[SerializeField]
		private string _abilityId;

		private Ability _abilityRef;

		public void FindReference()
		{
			// Todo - Find the ability in the loaded campaign data by ID
		}
	}
}