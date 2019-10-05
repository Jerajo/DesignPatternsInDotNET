using System;
using Newtonsoft.Json.Linq;
using DesignPatterns.Services;

namespace DesignPatterns
{
	public class Program
	{
		public static void Main(string[] args)
		{
			if (args != null && args.Length > 0) { }
			else
			{

				var logger = new LoggerService();
				var jSONManager = new JSONManagerService();
				var inputManager = new InputManagerService(logger);

				var json = (JObject)jSONManager.Read("./Data/Programs.json");
				var programsList = json["Programs"].ToObject<string[]>();
				var lastIndex = programsList.Length - 1;
				var count = 0;

				logger.Log("Design Patterns in .Net Core C#.\n");
				logger.Log($"Select an option between {0} and {lastIndex}:\n");

				foreach (var item in programsList)
					logger.Log($"{count}: {programsList[count++]}");

				var response = inputManager.RequestInt(min: 0, max: lastIndex);
				var programName = programsList[response];

				var programFactory = new ProgramFactory(logger);

				var program = programFactory.Create(programName);
				program.Run();

				Console.ReadKey();
			}
		}
	}
}
