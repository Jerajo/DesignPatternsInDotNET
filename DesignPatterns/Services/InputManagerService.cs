using System;

namespace DesignPatterns.Services
{
	internal class InputManagerService
	{
		LoggerService _logger;

		public InputManagerService(LoggerService logger)
		{
			_logger = logger;
		}

		internal int RequestInt(int min, int max)
		{
			int option = min - 1;
			while (option < min || option > max)
			{
				_logger.Log("\nEnter the option:> ");
				var resoult = int.TryParse(Console.ReadLine(), out option);

				if (!resoult)
				{
					_logger.Log("You has to enter a valid number.");
					option = min - 1;
				}
				else if (option < min || option > max)
					_logger.Log("The selected options was out of range.");
			}
			return option;
		}
	}
}