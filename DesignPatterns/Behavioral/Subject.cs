using System.Collections.Generic;

namespace CSC360_FinalProject.DesignPatterns.Behavioral {
	/// <summary>
	/// In the <c>Observer</c> design pattern, the <c>Subject</c> is the object
	/// that is being observed. It maintains a list of observers and notifies
	/// them of any changes.
	/// </summary>
	public class Subject {
		/// <summary>
		/// Add an observer to the <c>Subject</c>'s list of observers. If the
		/// observer is already in the list, then this function does nothing.
		/// </summary>
		/// <param name="observer">The observer to add to the list.</param>
		public void AddObserver(IObserver observer) {
			if(!observers.Contains(observer)) {
				observers.Add(observer);
			}
		}

		/// <summary>
		/// Remove an observer from the <c>Subject</c>'s list of observers. If
		/// the observer is not in the list, then this function does nothing.
		/// </summary>
		/// <param name="observer">The observer to remove from the list.</param>
		public void RemoveObserver(IObserver observer) {
			observers.Remove(observer);
		}

		/// <summary>
		/// The <c>Subject</c>'s list of observers. The <c>Subject</c> is
		/// responsible for maintaining this list and for notifying the
		/// observers in it of any changes.
		/// </summary>
		private readonly List<IObserver> observers = new List<IObserver>();
	}
}
