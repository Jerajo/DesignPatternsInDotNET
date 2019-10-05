using Newtonsoft.Json.Linq;

namespace DesignPatterns.Modules.Adapter
{
	public interface ITXTService
	{
		string PostTXT(string path);
	}
}