
using System;
using System.Linq;
using System.Text;
using System.Timers;
using HidLibrary;
using ThinkingHome.NooLite.Common;

namespace ThinkingHome.NooLite
{
	public class RX1164Adapter : BaseAdapter
	{
		#region fields & properties

		private readonly object lockObject = new object();

		private readonly Timer timer;

		private RxAdapterType adapterType;
		private ReceivedCommandData currentCommandData;		// текущее содержимое буфера адаптера
		private bool lastProcessedTogl;						// предыдущий бит TOGL
		private byte lastProcessedCommand = byte.MaxValue;	// предыдущая команда


		public event Action<ReceivedCommandData> CommandReceived;

		public override int ProductId
		{
			get { return 0x05DC; }
		}

		#endregion

		#region IO

		public ReceivedCommandData ReadLatestCommand()
		{
			byte[] buf;
			device.ReadFeatureData(out buf);

			return new ReceivedCommandData(buf);
		}

		public void SendCommand(RX1164Command cmd, byte channel = 0)
		{
			var data = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

			data[1] = (byte)cmd;
			data[2] = channel;

			device.WriteFeatureData(data);
			System.Threading.Thread.Sleep(200);
		}

		#endregion

		public RX1164Adapter()
		{
			timer = new Timer(200);
		}

		protected override HidDevice SelectDevice()
		{
			var firstDevice = HidDevices
				.Enumerate(VendorId, ProductId)
				.Select(GetDeviceAdapterType)
				.OrderByDescending(x => x.Item1)
				.FirstOrDefault();

			if (firstDevice != null)
			{
				adapterType = firstDevice.Item1;
				return firstDevice.Item2;
			}

			return null;
		}

		private static Tuple<RxAdapterType, HidDevice> GetDeviceAdapterType(HidDevice hidDevice)
		{
			RxAdapterType adapterType = RxAdapterType.Other;
			byte[] bytes;

			if (hidDevice != null && hidDevice.ReadProduct(out bytes))
			{
				string productString = Encoding.UTF8.GetString(bytes).ToLower();

				switch (productString)
				{
					case "rx2164":
						adapterType = RxAdapterType.Rx2164;
						break;
					case "rx1164":
						adapterType = RxAdapterType.Rx1164;
						break;
				}
			}

			return new Tuple<RxAdapterType, HidDevice>(adapterType, hidDevice);
		}

		public override bool OpenDevice()
		{
			if (!base.OpenDevice())
			{
				return false;
			}

			switch (adapterType)
			{
				case RxAdapterType.Rx1164:
					timer.Elapsed += Rx1164TimerElapsed;
					timer.Start();
					break;
				case RxAdapterType.Rx2164:
					timer.Elapsed += Rx2164TimerElapsed;
					timer.Start();
					break;
			}

			return true;
		}

		private void Rx2164TimerElapsed(object sender, ElapsedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void Rx1164TimerElapsed(object sender, ElapsedEventArgs e)
		{
			ReceivedCommandData prev, current;

			lock (lockObject)
			{
				prev = currentCommandData;
				current = currentCommandData = ReadLatestCommand();

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

		protected virtual void OnCommandReceived(ReceivedCommandData obj)
		{
			var handler = CommandReceived;
			if (handler != null)
			{
				handler(obj);
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			timer.Dispose();
		}
	}
}
