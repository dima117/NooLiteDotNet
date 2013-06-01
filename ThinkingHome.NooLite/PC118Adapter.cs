using System;
using System.Linq;
using HidLibrary;

namespace ThinkingHome.NooLite
{
    /// <summary>
    /// Class for working wuth device
    /// </summary>
    public class Pc118Adapter : IDisposable
    {
	    private enum PC11XXAdapterFormat
	    {
			Undefined = 0x00,
			SetLevel = 0x01,
			SetLevelRgb = 0x03,
			LED = 0x04
	    }

	    private const int VENDOR_ID = 0x16C0;
        private const int PRODUCT_ID = 0x05DF;

        private HidDevice device;

        public bool IsConnected
        {
            get { return device != null && device.IsConnected; }
        }

        public bool OpenDevice()
        {
            device = HidDevices.Enumerate(VENDOR_ID, PRODUCT_ID).FirstOrDefault();

            if (device != null)
            {
                device.OpenDevice();
                device.MonitorDeviceEvents = true;
                return true;
            }
            return false;
        }

        public void SendLedCommand(
			PC11XXLedCommand cmd, 
			byte channel, 
			byte levelR = 0, 
			byte levelG = 0, 
			byte levelB = 0)
        {
			var format = cmd == PC11XXLedCommand.SetLevel ? PC11XXAdapterFormat.SetLevelRgb : PC11XXAdapterFormat.LED;

			SendCommandInternal((byte)cmd, channel, format, levelR, levelG, levelB);
        }

        public void SendCommand(PC11XXCommand cmd, byte channel, byte level = 0)
        {
	        var format = cmd == PC11XXCommand.SetLevel ? PC11XXAdapterFormat.SetLevel : PC11XXAdapterFormat.Undefined;

			SendCommandInternal((byte)cmd, channel, format, level);
        }

	    private void SendCommandInternal(
			byte cmd, 
			byte channel, 
			PC11XXAdapterFormat format, 
			byte level0 = 0,
			byte level1 = 0,
			byte level2 = 0)
	    {
		    var data = new byte[] {0x00, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

		    data[2] = cmd;		// command
		    data[3] = (byte) format;	// format
			data[5] = channel;
			data[6] = level0;
			data[7] = level1;
			data[8] = level2;

		    device.WriteFeatureData(data);
		    System.Threading.Thread.Sleep(200);
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
