using System;

namespace CSC360_FinalProject.Examples.Behavioral.Observer {
	public class Demonstrate {
		public static void Run() {
			Counter counter = new Counter();

			counter.AddWatcher(new SimpleIntWatcher());
			counter.AddWatcher(new DoubledIntWatcher());
			counter.AddWatcher(new HalvedIntWatcher());

			bool quit = false;
			while(!quit) {
				int choice = GetInt(
					string.Concat([
						"\n",
						"Please make a choice:\n",
						"1. Increment the counter\n",
						"2. Add a custom amount to the counter\n",
						"3. Decrement the counter\n",
						"4. Subtract a custom amount from the counter\n",
						"5. Quit"
					]),
					1, 5
				);

				switch(choice) {
					case 1:
						counter.IncrementCount();

						break;
					case 2:
						{
							int value = GetInt("Please specify an amount");
							counter.AddCount(value);
						}

						break;
					case 3:
						counter.DecrementCount();

						break;
					case 4:
						{
							int value = GetInt("Please specify an amount");
							counter.SubtractCount(value);
						}

						break;
					default:
						quit = true;

						break;
				}
			}
		}

		public static int GetInt(string message, int lowerBounds = int.MinValue, int upperBounds = int.MaxValue) {
			while(true) {
				Console.WriteLine(message);
				string? input = Console.ReadLine();
				Console.Write('\n');

				if(int.TryParse(input, out int parsed)) {
					if(parsed >= lowerBounds && parsed <= upperBounds) {
						return parsed;
					} else {
						Console.WriteLine($"Input was out of bounds. The minimum value is {lowerBounds} and the maximum value is {upperBounds}.");
						Console.Write('\n');
					}
				} else {
					Console.WriteLine("Please only enter valid whole numbers.");
					Console.Write('\n');
				}
			}
		}
	}
}
