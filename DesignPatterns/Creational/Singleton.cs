using System;

namespace CSC360_FinalProject.DesignPatterns.Creational {
	/// <summary>
	/// The singleton pattern ensures that only one instance of a class exists at any given time.
	/// This can be helpful in situations where you need to avoid duplicating data, such as when
	/// you're working with the filesystem or resources shared between multiple objects.
	/// </summary>
	public class Singleton {
		/// <summary>
		/// The private constructor ensures that no other class can create instances of the singleton,
		/// granting the singleton class full control over its own instantiation.
		/// </summary>
		private Singleton() {}

		/// <summary>
		/// The private static instance stores the single instance of the class and protects it
		/// from modification by any other class. In this case, it is also combined with the <c>Lazy</c>
		/// class to provide lazy initialization, ensuring that the singleton only gets initialized
		/// whenever it first gets used, improving startup times with the tradeoff of increased
		/// latency when the singleton first gets used.
		/// </summary>
		private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

		/// <summary>
		/// The public static property provides other classes a means to get, but not set, the
		/// singleton's instance.
		/// </summary>
		public static Singleton Instance {get {return instance.Value;}}
	}
}
