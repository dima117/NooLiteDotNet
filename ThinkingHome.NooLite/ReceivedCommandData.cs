namespace ThinkingHome.NooLite
{
	public class ReceivedCommandData
	{
		private readonly byte[] buf;

		public ReceivedCommandData(byte[] buf)
		{
			this.buf = (byte[])buf.Clone();
		}

		public bool ToggleFlag
		{
			get
			{
				return (buf[1] & 0x80) > 0;	// 7й бит 1-го байта
			}
		}	

		public bool Binding
		{
			get
			{
				return (buf[1] & 0x40) > 0;	// 6й бит 1-го байта
			}
		}

		public byte Cmd
		{
			get { return buf[3]; }
		}

		public byte Channel
		{
			get { return buf[2]; }
		}

		public byte[] Data
		{
			get
			{
				switch ((AdapterCommandFormat)buf[4])
				{
					case AdapterCommandFormat.OneByteData:
						return new[] { buf[5] };
					case AdapterCommandFormat.FourByteData:
						return new[] { buf[5], buf[6], buf[7], buf[8] };
					case AdapterCommandFormat.Undefined:
					case AdapterCommandFormat.LED:
						return new byte[0];
					default:
						return new byte[0];
				}
			}
		}
	}
}
