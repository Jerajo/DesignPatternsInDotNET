using DesignPatterns.Services;
using DesignPatterns.Modules.Adapter;

namespace DesignPatterns.Modules
{
	public class AdapterProgram : IProgram
	{
		LoggerService _logger;

		public AdapterProgram(LoggerService logger)
		{
			_logger = logger;
		}

		public void Run()
		{
			var service = new Service();
			var adapter = new ClientServeAdapter(service);
			var client = new Client(adapter);
			client.Launch(new string[] { "Data/Adapter.txt" });
		}
	}
}
