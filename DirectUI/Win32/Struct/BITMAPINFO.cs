﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectUI.Win32.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct BITMAPINFO
    {
        internal BITMAPINFOHEADER bmiHeader;
        internal RGBQUAD bmiColors;
    }
}
