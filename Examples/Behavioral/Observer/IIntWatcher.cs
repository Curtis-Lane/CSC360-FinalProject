namespace CSC360_FinalProject.Examples.Behavioral.Observer {
	/// <summary>
	/// An interface that defines update methods for any object
	/// that wants to be notified when an <c>int</c> value changes.
	/// </summary>
	public interface IIntWatcher {
		/// <summary>
		/// An update method that allows any object that implements
		/// this interface to be notified whenever an <c>int</c>
		/// value changes for any reason.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Observer</c> pattern.
		/// </remarks>
		/// <param name="value">The new value of the watched <c>int</c>.</param>
		public void ValueUpdated(int value);
	}
}
