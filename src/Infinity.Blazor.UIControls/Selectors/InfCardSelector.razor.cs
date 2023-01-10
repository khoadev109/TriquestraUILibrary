using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Selectors
{
    partial class InfCardSelector
	{
		[Parameter]
		public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string Width { get; set; } = "500px";

        public bool Active { get; set; } = false;

        [Parameter]
        public EventCallback OnClick { get; set; }

        public void OnHover() => Active = true;

        public void OnBlur() => Active = false;
    }
}
