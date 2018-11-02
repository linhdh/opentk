﻿using DWORD = System.UInt32;

namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Specifies the type of raw input device.
    /// </summary>
    public enum RawInputDeviceType : DWORD
    {
        /// <summary>
        /// Data comes from a mouse.
        /// </summary>
        Mouse = 0,

        /// <summary>
        /// Data comes from a keyboard.
        /// </summary>
        Keyboard = 1,

        /// <summary>
        /// Data comes from an HID that is not a keyboard or a mouse.
        /// </summary>
        Hid = 2
    }
}
