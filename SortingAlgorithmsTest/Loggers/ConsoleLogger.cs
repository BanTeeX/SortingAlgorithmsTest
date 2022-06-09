using SortingAlgorithmsTest.TestsSeries;

namespace SortingAlgorithmsTest.Loggers
{
	internal class ConsoleLogger : ILogger
	{
		private readonly object _locker = new();

		public void Log(object sender, string message)
		{
			lock (_locker)
			{
				if (sender.GetType() == typeof(Part1And2))
				{
					Console.SetCursorPosition(0, 1);
				}

				if (sender.GetType() == typeof(Part3))
				{
					Console.SetCursorPosition(0, 2);
				}

				Console.Write(message + new string(' ', Console.BufferWidth - message.Length));
			}
		}
	}
}
