namespace CSC360_FinalProject.Examples.Creational.Singleton {
	public class Demonstrate {
		public static void Run() {
			ConsoleLogger.Instance.Log("This is a test of the logging system.");
			ConsoleLogger.Instance.Log("This is a warning!", ConsoleLogger.LogLevel.WARN);
			ConsoleLogger.Instance.Log("This is an ERROR!", ConsoleLogger.LogLevel.ERROR);
			ConsoleLogger.Instance.Log("This won't be printed!", ConsoleLogger.LogLevel.DEBUG);

			ConsoleLogger.Instance.MinimumLogLevel = ConsoleLogger.LogLevel.DEBUG;

			ConsoleLogger.Instance.Log("Now this will be printed!", ConsoleLogger.LogLevel.DEBUG);
		}
	}
}
