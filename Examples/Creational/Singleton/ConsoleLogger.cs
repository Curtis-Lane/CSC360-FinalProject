using System;

namespace CSC360_FinalProject.Examples.Creational.Singleton {
	/// <summary>
	/// A logging class that sends its output to the console. It uses the <c>Singleton</c>
	/// pattern to ensure that there will only ever be one instance of the class.
	/// </summary>
	public class ConsoleLogger {
		/// <summary>
		/// An enum representing various different output levels for the logger.
		/// </summary>
		public enum LogLevel {
			DEBUG,
			INFO,
			WARN,
			ERROR
		}

		/// <summary>
		/// Log a message to the console with the selected log level.
		/// </summary>
		/// <param name="message">The message to log.</param>
		/// <param name="logLevel">The level to log the message at.</param>
		public void Log(string message, LogLevel logLevel = LogLevel.INFO) {
			if(logLevel < MinimumLogLevel) return;

			switch(logLevel) {
				case LogLevel.DEBUG:
					Console.Write("DEBUG: ");
					break;
				case LogLevel.INFO:
					Console.Write("INFO: ");
					break;
				case LogLevel.WARN:
					Console.Write("WARN: ");
					break;
				case LogLevel.ERROR:
					Console.Write("ERROR: ");
					break;
			}

			Console.WriteLine(message);
		}

		/// <summary>
		/// A private constructor to ensure that the <c>ConsoleLogger</c>
		/// class has full control over its own instantiation.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Singleton</c> pattern.
		/// </remarks>
		private ConsoleLogger() {}

		/// <summary>
		/// A public static property that provides other classes access to
		/// the <c>ConsoleLogger</c>'s instance.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Singleton</c> pattern.
		/// </remarks>
		public static ConsoleLogger Instance {get {return instance.Value;}}

		/// <summary>
		/// Represents the minimum level of logs that the logger will output.
		/// Any attempts to log a message with a level lower than the minimum
		/// will be ignored.
		/// </summary>
		/// <remarks>
		/// Defaults to <c>LogLevel.INFO</c>.
		/// </remarks>
		public LogLevel MinimumLogLevel {get; set;} = LogLevel.INFO;

		/// <summary>
		/// A private static instance to store the single instance of the class
		/// and protect it from modification by any other class. We combine that
		/// with the <c>Lazy</c> class to provide lazy initialization.
		/// </summary>
		/// <remarks>
		/// Part of the <c>Singleton</c> pattern.
		/// </remarks>
		private static readonly Lazy<ConsoleLogger> instance = new Lazy<ConsoleLogger>(() => new ConsoleLogger());
	}
}
