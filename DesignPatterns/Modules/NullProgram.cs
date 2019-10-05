using DesignPatterns.Services;

namespace DesignPatterns.Modules
{
	public class NullProgram : IProgram
	{
		LoggerService _logger;
		string _programName;

		public NullProgram(LoggerService logger, string programName)
		{
			_logger = logger;
			_programName = programName;
		}

		public void Run()
		{
			_logger.Log($"\n{_programName}. Not available yet.");
		}
	}
}