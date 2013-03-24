﻿using System;
using System.Linq;
using HidLibrary;
using ThinkingHome.NooLite;

namespace ThinkingHome.NooLite
{
	public class PC118Adapter : IDisposable
    {
        private const int VENDOR_ID = 0x16C0;
        private const int PRODUCT_ID = 0x05DF;

        private HidDevice device;

		public bool IsConnected
		{
			get { return device != null && device.IsConnected; }
		}

		public bool OpenDevice()
        {
            try
            {
                device = HidDevices.Enumerate(VENDOR_ID, PRODUCT_ID).FirstOrDefault();

                if (device != null)
                {
                    device.OpenDevice();
                    device.MonitorDeviceEvents = true;
                    return true;
                }
            }
            catch
            {
                System.Diagnostics.Debug.Write(this, "Can't connect to device");
            }
            return false;

	        
        }

        public void SendCommand(Pc118Command cmd, byte channel, byte level = 0)
        {
            var data = new byte[] { 0x00, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            data[2] = (byte)cmd;
            data[5] = channel;

            if (cmd == Pc118Command.SetLevel)
            {
                data[3] = 0x01;
                data[6] = level;
            }

            device.WriteFeatureData(data);
            System.Threading.Thread.Sleep(20);
            //device.Write(data);
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
