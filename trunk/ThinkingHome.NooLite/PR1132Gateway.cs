using System;
using System.IO;
using System.Net;
using ThinkingHome.NooLite.PR1132;

namespace ThinkingHome.NooLite
{
	public class PR1132Gateway : IDisposable
	{
		private readonly WebClient client = new WebClient();

		public Uri Host { get; private set; }

		public PR1132Gateway(string host)
		{
			Host = new Uri("http://" + host);
		}

		public void SendCommand(PC11XXCommand cmd, byte channel, byte level = 0)
		{
			var format = cmd == PC11XXCommand.SetLevel ? CommandFormat.OneByteData : CommandFormat.Undefined;

			SendCommandInternal((byte)cmd, channel, format, level);
		}

		public void SendLedCommand(
			PC11XXLedCommand cmd,
			byte channel,
			byte levelR = 0,
			byte levelG = 0,
			byte levelB = 0)
		{
			var format = cmd == PC11XXLedCommand.SetLevel ? CommandFormat.FourByteData : CommandFormat.LED;

			SendCommandInternal((byte)cmd, channel, format, levelR, levelG, levelB);
		}

		public PR1132Configuration LoadConfiguration()
		{
			var url = GetUrl("noolite_settings.bin");

			using (var client = new WebClient())
			{
				var bytes = client.DownloadData(url);

				using (var stream = new MemoryStream(bytes))
				{
					return PR1132Configuration.Deserialize(stream);
				}
			}
		}

		private Uri GetUrl(string relativeUrl)
		{
			return new Uri(Host, relativeUrl);
		}

		private void SendCommandInternal(
			byte cmd,
			byte channel,
			CommandFormat format,
			byte level0 = 0,
			byte level1 = 0,
			byte level2 = 0)
		{
			const string URL_FORMAT = "api.htm?ch={0}&cmd={1}";
			var relativeUrl = string.Format(URL_FORMAT, channel, cmd);

			switch (format)
			{
				case CommandFormat.OneByteData:
					relativeUrl += string.Format("&fmt={0}&d0={1}", (byte) format, level0);
					break;
				case CommandFormat.FourByteData:
				case CommandFormat.LED:
					relativeUrl += string.Format("&fmt={0}&d0={1}&d1={2}&d2={3}", (byte) format, level0, level1, level2);
					break;
			}
			
			var url = GetUrl(relativeUrl);

			client.DownloadString(url);
		}

		public void Dispose()
		{
			client.Dispose();
		}
	}
}
