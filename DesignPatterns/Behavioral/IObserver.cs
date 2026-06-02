namespace CSC360_FinalProject.DesignPatterns.Behavioral {
	/// <summary>
	/// In the <c>Observer</c> design pattern, the observer interface
	/// (in this case the <c>IObserver</c>) defines the update methods
	/// that the subject will call to notify the observer of any changes.
	/// </summary>
	public interface IObserver {
		/// <summary>
		/// An example update method to represent what the subject would
		/// call to notify the observer of any changes.
		/// </summary>
		public void Update();
	}
}
