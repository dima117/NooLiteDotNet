using ThinkingHome.NooLite.Common;

namespace ThinkingHome.NooLite
{
	public class RX1164Adapter : BaseAdapter
	{
		public override int ProductId
		{
			get { return 0x05DC; }
		}

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
	}
}
