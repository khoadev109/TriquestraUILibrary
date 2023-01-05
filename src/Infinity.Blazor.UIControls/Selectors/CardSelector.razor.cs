using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Selectors
{
    partial class CardSelector
	{
		[Parameter]
		public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string Width { get; set; }

        public bool Active { get; set; } = false;

        public void OnClick() => Active = true;
        
        public void OnHover() => Active = true;

        public void OnBlur() => Active = false;
    }
}
