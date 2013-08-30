namespace ThinkingHome.NooLite
{
	/// <summary>
	/// Class for working wuth device
	/// </summary>
	public class PC11XXAdapter : BaseAdapter
	{
		public override int ProductId
		{
			get { return 0x05DF; }
		}

		public void SendLedCommand(
			PC11XXLedCommand cmd,
			byte channel,
			byte levelR = 0,
			byte levelG = 0,
			byte levelB = 0)
		{
			var format = cmd == PC11XXLedCommand.SetLevel ? AdapterCommandFormat.FourByteData : AdapterCommandFormat.LED;

			SendCommandInternal((byte)cmd, channel, format, levelR, levelG, levelB);
		}

		public void SendCommand(PC11XXCommand cmd, byte channel, byte level = 0)
		{
			var format = cmd == PC11XXCommand.SetLevel ? AdapterCommandFormat.OneByteData : AdapterCommandFormat.Undefined;

			SendCommandInternal((byte)cmd, channel, format, level);
		}

		private void SendCommandInternal(
			byte cmd,
			byte channel,
			AdapterCommandFormat format,
			byte level0 = 0,
			byte level1 = 0,
			byte level2 = 0)
		{
			var data = new byte[] { 0x00, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

			data[2] = cmd;		// command
			data[3] = (byte)format;	// format
			data[5] = channel;
			data[6] = level0;
			data[7] = level1;
			data[8] = level2;

			device.WriteFeatureData(data);
			System.Threading.Thread.Sleep(200);
		}
	}
}
