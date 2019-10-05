using DesignPatterns.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Services
{
	public class ProgramFactory
	{
		LoggerService _logger;

		public ProgramFactory(LoggerService logger)
		{
			_logger = logger;
		}

		public IProgram Create(string programName)
		{
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
