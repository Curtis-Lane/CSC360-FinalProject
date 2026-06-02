using System.Collections.Generic;

namespace CSC360_FinalProject.Examples.Behavioral.Observer {
	/// <summary>
	/// A simple class that stores an integer and lets you add and
	/// subtract from it. It implements the <c>Subject</c> portion
	/// of the <c>Observer</c> pattern.
	/// </summary>
	public class Counter {
		/// <summary>
		/// Increase the value of <c>Count</c> by one.
		/// </summary>
		public void IncrementCount() {
			Count += 1;
		}

		/// <summary>
		/// Increase the value of <c>Count</c> by <c>addition</c>.
		/// </summary>
		/// <param name="addition">The amount to increase <c>Count</c> by.</param>
		public void AddCount(int addition) {
			Count += addition;
		}

		/// <summary>
		/// Decrease the value of <c>Count</c> by one.
		/// </summary>
		public void DecrementCount() {
			Count -= 1;
		}

		/// <summary>
		/// Decrease the value of <c>Count</c> by <c>subtraction</c>.
		/// </summary>
		/// <param name="subtraction">The amount to decrease <c>Count</c> by.</param>
		public void SubtractCount(int subtraction) {
			Count -= subtraction;
		}

		/// <summary>
		/// Add a watcher to the list of tracked watchers. If the watcher is
		/// already in the list, then this function does nothing.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Observer</c> pattern.
		/// </remarks>
		/// <param name="watcher">The watcher to add to the list.</param>
		public void AddWatcher(IIntWatcher watcher) {
			if(!watchers.Contains(watcher)) {
				watchers.Add(watcher);
			}
		}

		/// <summary>
		/// Remove a watcher from the list of tracked watchers. If the watcher
		/// is not in the list, then this function does nothing.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Observer</c> pattern.
		/// </remarks>
		/// <param name="watcher">The watcher to remove from the list.</param>
		public void RemoveWatcher(IIntWatcher watcher) {
			watchers.Remove(watcher);
		}

		/// <summary>
		/// A property to access the class's stored integer. Any changes
		/// made to this property notify all tracked watchers of the change.
		/// </summary>
		public int Count {
			get {
				return count;
			}

			private set {
				count = value;

				foreach(IIntWatcher watcher in watchers) {
					watcher.ValueUpdated(count);
				}
			}
		}

		/// <summary>
		/// The backing field for the <c>Count</c> property.
		/// </summary>
		private int count = 0;

		/// <summary>
		/// The list of tracked watchers. The watchers get notified any
		/// time a change is made to the <c>Count</c> property.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Observer</c> pattern.
		/// </remarks>
		private readonly List<IIntWatcher> watchers = new List<IIntWatcher>();
	}
}
