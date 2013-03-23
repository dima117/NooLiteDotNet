namespace ThinkingHome.NooLite
{
	public enum Pc118Command : byte
	{
		On = 0x02,
		Off = 0x00,
		Switch = 0x04,
		SetLevel = 0x06,
		Bind = 0x0f,
		UnBind = 0x09,
	}
}