﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumSharp.Core
{
    public static partial class np
    {
        public static int roll(NDArray nd, int shift, int axis = -1)
            => axis == -1 ? nd.roll(shift) : nd.roll(shift, axis);
    }
}
