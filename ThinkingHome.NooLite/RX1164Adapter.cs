﻿
using System;
using System.Linq;
using System.Timers;
using HidLibrary;
using ThinkingHome.NooLite.Common;

namespace ThinkingHome.NooLite
{
	public class RX1164Adapter : BaseRxAdapter
	{
		#region fields & properties

		protected RX1164ReceivedCommandData lastReceivedData;
		private bool lastProcessedTogl;						// предыдущее значение TOGL
		private byte lastProcessedCommand = byte.MaxValue;	// предыдущая команда

		#endregion

		protected override HidDevice SelectDevice()
		{
			var hidDevice = HidDevices
				.Enumerate(VendorId, ProductId)
				.FirstOrDefault(a => StringComparer.InvariantCultureIgnoreCase.Equals(GetProductString(a), "rx1164"));

			return hidDevice;
		}

		protected override void TimerElapsed(object sender, ElapsedEventArgs e)
		{
			RX1164ReceivedCommandData prev, current;

			lock (lockObject)
			{
				var buf = ReadBufferData();

				prev = lastReceivedData;
				lastReceivedData = current = new RX1164ReceivedCommandData(buf);
				
				if (prev == null)
				{
					prev = current;
					lastProcessedTogl = current.ToggleFlag;
					lastProcessedCommand = current.Cmd;
				}
			}

			if (current.Equals(prev) &&
				(current.ToggleFlag != lastProcessedTogl || current.Cmd != lastProcessedCommand))
			{
				lastProcessedTogl = current.ToggleFlag;
				lastProcessedCommand = current.Cmd;

				OnCommandReceived(current);
			}
		}
	}
}
