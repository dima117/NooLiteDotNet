namespace ThinkingHome.NooLite
{
	public class ReceivedCommandData
	{
		public bool ToggleFlag { get; set; }

		public bool Binding { get; set; }

		public byte Cmd { get; set; }

		public byte Channel { get; set; }

		public byte[] Data { get; set; }
	}
}
