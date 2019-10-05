using DesignPatterns.Services;
using Newtonsoft.Json.Linq;

namespace DesignPatterns.Modules.Adapter 
{
	public class Service : ITXTService
	{
			TXTManagerService _service;

			public Service()
			{
					_service = new TXTManagerService();
			}

			public string PostTXT(string path)
			{
				return (string)_service.Read(path);
			}
	}
}