using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace AutoSleep
{
  public static class InputData
  {
    public static TimeSpan TimeSinceLastInput
    {
      get
      {
        LASTINPUTINFO info = new LASTINPUTINFO();
        info.cbSize = LASTINPUTINFO.SizeOf;
        if (!GetLastInputInfo(ref info))
          return TimeSpan.Zero;

        return TimeSpan.FromMilliseconds(Environment.TickCount - info.dwTime);
      }
    }

    [DllImport("user32.dll")]
    private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

    [StructLayout(LayoutKind.Sequential)]
    private struct LASTINPUTINFO
    {
      public static readonly UInt32 SizeOf = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO));

      [MarshalAs(UnmanagedType.U4)]
      public UInt32 cbSize;

      [MarshalAs(UnmanagedType.U4)]
      public UInt32 dwTime;
    }
  }
}