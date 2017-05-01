using System;
using FaltRP.Constants;
using FaltRP.Enums;
using UnityEngine;

namespace FaltRP.Statistics
{
	/// <summary>
	/// Container of actor stat block
	/// </summary>
	[Serializable]
	public class Stats
	{
		#region Storage

		/// <summary>
		/// Base container of stat values
		/// </summary>
		[SerializeField]
		// ReSharper disable once FieldCanBeMadeReadOnly.Local
		private int[] _stats = new int[StatConsts.STAT_AMOUNT];

		#endregion

		#region Public Access

		/// <summary>
		/// Stat access by int index
		/// </summary>
		/// <param name="index">Index of desired stat</param>
		/// <returns>Desired stat</returns>
		public int this[int index]
		{
			get
			{
				if (index < 0 || index >= _stats.Length) return 0;
				return _stats[index];
			}
			set
			{
				if (index < 0 || index >= _stats.Length) return;
				_stats[index] = value;
			}
		}

		/// <summary>
		/// Stat access by stat type
		/// </summary>
		/// <param name="index">Type of desired stat</param>
		/// <returns>Desired stat</returns>
		public int this[Stat index]
		{
			get { return this[(int)index]; }
			set { this[(int)index] = value; }
		}

		#endregion
	}
}