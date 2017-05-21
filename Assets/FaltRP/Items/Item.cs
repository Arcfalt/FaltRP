using FaltRP.Abilities;
using FaltRP.Constants;
using FaltRP.Statistics;
using UnityEngine;

namespace FaltRP.Items
{
	/// <summary>
	/// Container for an item
	/// </summary>
	[CreateAssetMenu(fileName = "New Item", menuName = "ArcRP/Item", order = 1001)]
	public class Item : ScriptableObject
	{
		/// <summary>
		/// Name of the item
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Header("Text Display")]
		private string _name;

		/// <summary>
		/// Description of the item
		/// Prefix with @ to set as localized tag
		/// </summary>
		[SerializeField]
		[Multiline]
		private string _description;

		/// <summary>
		/// Base price of the item before any modifiers
		/// </summary>
		[SerializeField]
		[Header("Basic Properties")]
		private int _price;

		/// <summary>
		/// Weight of the individual item
		/// </summary>
		[SerializeField]
		private float _weight;

		/// <summary>
		/// Maximum stack amount of the item
		/// </summary>
		[SerializeField]
		[Range(1, ItemConsts.MAX_STACK)]
		private int _stackAmount;

		/// <summary>
		/// Stats required by the weilder of the item to use it
		/// </summary>
		[SerializeField]
		[Header("Stat Requirements")]
		private Stats _requiredStats;

		/// <summary>
		/// Reference to the ability that the item can be used to perform
		/// </summary>
		[SerializeField]
		[Header("Item Usage")]
		private AbilityRef _onUseAbility;
	}
}