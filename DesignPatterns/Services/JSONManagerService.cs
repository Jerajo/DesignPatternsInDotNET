﻿using System.IO;
using Newtonsoft.Json.Linq;

namespace DesignPatterns.Services
{
	public class JSONManagerService : IFileService
	{
		public object Read(string filePath)
		{
			var json = File.ReadAllText(filePath);
			return JObject.Parse(json);
		}

		public void Write(string filePath, object document)
		{
			File.WriteAllLines(filePath, new string[] { (string)document });
		}
	}
}