using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Services
{
	class LoggerService
	{
		readonly string[] _messageType =
			{ "", "Info: ", "Warning: ", "Error: " };

		internal void Log(string message, MessageType type = MessageType.Normal)
		{
			Console.WriteLine("{0}{1}", _messageType[(int)type], message);
		}
	}

	enum MessageType
	{
		Normal = 0,
		Info = 1,
		Warnig = 2,
		Error = 3
	}
}
