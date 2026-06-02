using System;

namespace CSC360_FinalProject.Examples.Behavioral.Observer {
	/// <summary>
	/// A watcher that prints double the value of the watched
	/// <c>int</c> any time it changes.
	/// </summary>
	public class DoubledIntWatcher : IIntWatcher {
		/// <summary>
		/// An update method that allows this object to be notified
		/// whenever the watched <c>int</c> changes.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Observer</c> pattern.
		/// </remarks>
		/// <param name="value">The new value of the watched <c>int</c>.</param>
		public void ValueUpdated(int value) {
			Console.WriteLine($"Value has been updated! Double the value is: {value * 2}");
		}
	}
}
