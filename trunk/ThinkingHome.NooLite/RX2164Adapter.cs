using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using HidLibrary;
using ThinkingHome.NooLite.Common;

namespace ThinkingHome.NooLite
{
	public class RX2164Adapter : BaseRxAdapter
	{
		protected RX2164ReceivedCommandData lastReceivedData;

		protected override HidDevice SelectDevice()
		{
			var hidDevice = HidDevices
				.Enumerate(VendorId, ProductId)
				.FirstOrDefault(a => StringComparer.InvariantCultureIgnoreCase.Equals(GetProductString(a), "rx2164"));

			return hidDevice;
		}

		protected override void TimerElapsed(object sender, ElapsedEventArgs e)
		{
			lock (lockObject)
			{
				var buf = ReadBufferData();
				var current = new RX2164ReceivedCommandData(buf);
				var prev = lastReceivedData ?? current;

				// обновляем поле с последней полученной командой
				lastReceivedData = current;

				// генерируем события
				if (current.ToggleValue != prev.ToggleValue)
				{
					OnCommandReceived(current);
				}
			}
		}
	}
}
