using System;
using System.Runtime.CompilerServices;

namespace AVOSCloud.RealtimeMessage
{
	public class AVGroupMessageReceivedEventArgs : EventArgs
	{
		public AVMessage Message
		{
			get;
			set;
		}

		public AVGroupMessageReceivedEventArgs()
		{
		}
	}
}