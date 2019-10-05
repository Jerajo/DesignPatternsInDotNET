using DesignPatterns.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Services
{
	class ProgramFactory
	{
		LoggerService _logger;
		InputManagerService _inputManager;
		JSONManagerService _JSONManager;

		public ProgramFactory(LoggerService logger, InputManagerService inputManager, JSONManagerService jSONManager)
		{
			_logger = logger;
			_inputManager = inputManager;
			_JSONManager = jSONManager;
		}

		public IProgram Select()
		{
			var json = _JSONManager.Read("./Data/Programs.json");
			var programsList = json["Programs"].ToObject<string[]>();
			var lastIndex = programsList.Length - 1;
			var count = 0;

			_logger.Log($"Select an option between {0} and {lastIndex}:\n");

			foreach (var item in programsList)
				_logger.Log($"{count}: {programsList[count++]}");

			var response = _inputManager.RequestInt(min: 0, max: lastIndex);
			var programName = programsList[response];

			try
			{
				var type = Type.GetType($"DesignPatterns.Modules.{programName}");
				return (IProgram)Activator.CreateInstance(type, _logger);
			}
			catch (ArgumentNullException)
			{
				//_logger.Log(ex.Message, MessageType.Error);
				return new NullProgram(_logger, programName);
			}
		}
	}
}
