using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DesignPatterns.Services
{
	internal class JSONManagerService
	{
		internal JObject Read(string filePath)
		{
			var json = File.ReadAllText(filePath);
			return JObject.Parse(json);
		}
	}
}