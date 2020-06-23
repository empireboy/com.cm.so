using UnityEngine;

namespace CM.SO
{
	/// <summary>
	/// Represents a ScriptableObject with a single value.
	/// </summary>
	/// <typeparam name="T">The single Type that this ScriptableObject holds.</typeparam>
	public class ValueSO<T> : ScriptableObject
	{
		/// <summary>
		/// The value that this ScriptableObject holds.
		/// </summary>
		public T value;
	}
}