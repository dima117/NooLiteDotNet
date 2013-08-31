using System;
using System.Linq;
using HidLibrary;

namespace ThinkingHome.NooLite.Common
{
	public abstract class BaseAdapter : IDisposable
	{
		public int VendorId
		{
			get { return 0x16C0; }
		}

		public abstract int ProductId { get; }

		protected HidDevice device;

		public bool IsConnected
		{
			get { return device != null && device.IsConnected; }
		}

		public bool OpenDevice()
		{
			device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();

			if (device != null)
			{
				device.OpenDevice();
				device.MonitorDeviceEvents = true;
				return true;
			}
			return false;
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
