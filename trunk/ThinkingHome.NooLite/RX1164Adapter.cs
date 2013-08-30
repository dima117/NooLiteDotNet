using System;

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

			var result = new ReceivedCommandData();

			var flags = buf[1];
			result.Binding = (flags & 0x80) > 0;	// 6й бит 1-го байта
			result.ToggleFlag = (flags & 0x40) > 0;	// 7й бит 1-го байта

			result.Channel = buf[2];
			result.Cmd = buf[3];

			switch ((AdapterCommandFormat)buf[4])
			{
				case AdapterCommandFormat.OneByteData:
					result.Data = new[] { buf[5] };
					break;
				case AdapterCommandFormat.FourByteData:
					result.Data = new[] { buf[5], buf[6], buf[7], buf[8] };
					break;
				case AdapterCommandFormat.Undefined:
				case AdapterCommandFormat.LED:
					result.Data = new byte[0];
					break;
				default:
					throw new Exception("unknown command format");
			}

			return result;
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
