using System.IO;
using Newtonsoft.Json.Linq;

namespace DesignPatterns.Services
{
	public class TXTManagerService : IFileService
	{
		public object Read(string filePath) =>
			File.ReadAllText(filePath);

		public void Write(string filePath, object document)
		{
			File.WriteAllLines(filePath, new string[] { (string)document });
		}
	}
}