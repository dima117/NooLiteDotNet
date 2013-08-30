using System;
using System.Linq;
using HidLibrary;

namespace ThinkingHome.NooLite
{
	public class RX1164Adapter : IDisposable
	{
		private const int VENDOR_ID = 0x16C0;
		private const int PRODUCT_ID = 0x05DC;

		private HidDevice device;

		public bool IsConnected
		{
			get { return device != null && device.IsConnected; }
		}

		public bool OpenDevice()
		{
			device = HidDevices.Enumerate(VENDOR_ID, PRODUCT_ID).FirstOrDefault();

			if (device != null)
			{
				device.OpenDevice();
				device.MonitorDeviceEvents = true;

				return true;
			}
			return false;
		}

		public void SendCommand(RX1164Command cmd, byte channel)
		{
			var data = new byte[] { 0x00, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

			data[1] = (byte)cmd;	
			data[2] = channel;		

			device.WriteFeatureData(data);
			System.Threading.Thread.Sleep(200);
		}

		public void Dispose()
		{
			if (device != null)
			{
				device.Dispose();
			}
		}
	}
}
