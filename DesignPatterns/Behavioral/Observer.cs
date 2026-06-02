using System;

namespace CSC360_FinalProject.DesignPatterns.Behavioral {
	/// <summary>
	/// In the <c>Observer</c> design pattern, the concrete observer
	/// implements behavior that will be triggered when the subject
	/// calls to notify observers of any changes.
	/// </summary>
	public class Observer : IObserver {
		/// <summary>
		/// An example update method to represent the behavior that
		/// would be triggered by the subject calling observers to
		/// notify them of any changes.
		/// </summary>
		public void Update() {
			Console.WriteLine("Hello World!");
		}
	}
}
