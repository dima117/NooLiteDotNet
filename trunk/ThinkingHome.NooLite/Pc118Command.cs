using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ThinkingHome.NooLite
{
    /// <summary>
    /// Available commands for device
    /// </summary>
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