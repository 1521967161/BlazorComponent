﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorComponent
{
    public partial class BSliderDefaultSlot<TValue,TInput> where TInput : ISlider<TValue>
    {
        public bool InverseLabel => Component.InverseLabel;
    }
}
