
using System;
using System.Timers;
using ThinkingHome.NooLite.Common;

namespace ThinkingHome.NooLite
{
	public class RX1164Adapter : BaseAdapter
	{
		#region fields & properties

		private readonly object lockObject = new object();

		private readonly Timer timer;

		private ReceivedCommandData latestCommandData;

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
			timer = new Timer(100);
			timer.Elapsed += TimerElapsed;
		}

		public override bool OpenDevice()
		{
			if (!base.OpenDevice())
			{
				return false;
			}

			timer.Start();
			return true;
		}

		private void TimerElapsed(object sender, ElapsedEventArgs e)
		{
			ReceivedCommandData prev, current;

			lock (lockObject)
			{
				prev = latestCommandData;
				current = latestCommandData = ReadLatestCommand();
			}

			if (!current.Equals(prev))
			{
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
