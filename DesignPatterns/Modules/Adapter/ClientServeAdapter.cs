using System;
using System.IO;

namespace DesignPatterns.Modules.Adapter 
{
	public class ClientServeAdapter : IService
	{
		ITXTService _service;

		public ClientServeAdapter(ITXTService service)
		{
				_service = service;
		}

		public void Run(string[] args)
		{
			var filePath = args[0];

			if (File.Exists(filePath)) 
			{
				Console.WriteLine(_service.PostTXT(filePath));
			}
			else Console.WriteLine($"File not found: {filePath}");
		}
	}
}