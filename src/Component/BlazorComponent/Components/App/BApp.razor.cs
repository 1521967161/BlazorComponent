﻿namespace BlazorComponent
{
    public abstract partial class BApp : BDomComponentBase, IDefaultsProvider
    {
        [Inject]
        private IPopupProvider PopupProvider { get; set; } = null!;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected bool IsMasaBlazorReady { get; set; }

        protected virtual bool IsDark => false;

        public virtual IDictionary<string, IDictionary<string, object?>?>? Defaults { get; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            PopupProvider.StateChanged += OnStateChanged;
        }

        private void OnStateChanged(object? sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            PopupProvider.StateChanged -= OnStateChanged;
        }
    }
}
