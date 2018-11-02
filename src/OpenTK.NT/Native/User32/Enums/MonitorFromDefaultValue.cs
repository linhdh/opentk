﻿using DWORD = System.UInt32;

namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Specifies what values to return if
    /// <see cref="User32.Monitor.MonitorFromPoint"/> and
    /// <see cref="User32.Monitor.MonitorFromWindow(System.IntPtr, MonitorFromDefaultValue)"/>
    /// fail to find a monitor for the given arguments.
    /// </summary>
    public enum MonitorFromDefaultValue : DWORD
    {
        /// <summary>
        /// Returns null.
        /// </summary>
        DefaultToNull = 0,

        /// <summary>
        /// Returns a handle to the primary display monitor.
        /// </summary>
        DefaultToPrimary = 1,

        /// <summary>
        /// Returns a handle to the display monitor that is nearest to the window/display monitor.
        /// </summary>
        DefaultToNearest = 2
    }
}
