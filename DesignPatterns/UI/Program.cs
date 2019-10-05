using DesignPatterns.Services;
using System;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args != null && args.Length > 0) { }
			else
			{
				var logger = new LoggerService();
				var jSONManager = new JSONManagerService();
				var inputManager = new InputManagerService(logger);
				var programSelector = new ProgramFactory(logger, inputManager, jSONManager);


				logger.Log("Design Patterns in .Net Core C#.\n");
				var program = programSelector.Select();
				program.Run();

				Console.ReadKey();
			}
		}
	}
}
