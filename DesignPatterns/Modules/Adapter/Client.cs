namespace DesignPatterns.Modules.Adapter 
{
	public class Client
	{
			IService _service;

			public Client(IService service)
			{
					_service = service;
			}

			public void Launch(string[] args)
			{
				_service.Run(args);
			}
	}
}