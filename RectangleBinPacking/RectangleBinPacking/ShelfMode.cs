﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleBinPacking
{
    public enum ShelfMode
    {
        FitToFirst,
        FitToMinWidth,
        FitToMinHeight,
        FitToMinArea,
        FitToMaxWidth,
        FitToMaxHeight,
        FitToMaxArea
    }
}
