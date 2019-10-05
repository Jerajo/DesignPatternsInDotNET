using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Services
{
	public class LoggerService
	{
		readonly string[] _messageType =
			{ "", "Info: ", "Warning: ", "Error: " };

		public void Log(string message, MessageType type = MessageType.Normal)
		{
			Console.WriteLine("{0}{1}", _messageType[(int)type], message);
		}
	}

	public enum MessageType
	{
		Normal = 0,
		Info = 1,
		Warnig = 2,
		Error = 3
	}
}
