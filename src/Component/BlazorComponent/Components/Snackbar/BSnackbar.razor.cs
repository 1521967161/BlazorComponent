﻿using Microsoft.AspNetCore.Components;

namespace BlazorComponent
{
    public partial class BSnackbar : BDomComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
