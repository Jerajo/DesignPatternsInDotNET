using DesignPatterns.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Modules
{
	class AdapterProgram : IProgram
	{
		LoggerService _logger;

		public AdapterProgram(LoggerService logger)
		{
			_logger = logger;
		}

		public void Run()
		{
			_logger.Log("This is the adapter design pattern example program!");
		}
	}
}
