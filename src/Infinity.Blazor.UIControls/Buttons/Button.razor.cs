using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Buttons;

partial class Button
{
    [Parameter]
    public ButtonType ButtonType { get; set; }

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Title { get; set; }
    
    [Parameter]
    public string Icon { get; set; }
    
    [Parameter]
    public string IconClass { get; set; }

    [Parameter]
    public string ImageUrl { get; set; }
    
    [Parameter]
    public string SpriteClass { get; set; }
    
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public EventCallback ClickHandler { get; set; }

    [Parameter]
    public string LabelText { get; set; }

    [Parameter]
    public bool Hidden { get; set; }

    [Parameter]
    public string FormId { get; set; }

    [Parameter]
    public FillMode FillMode { get; set; }

    [Parameter]
    public IconPosition IconPosition { get; set; }

    [Parameter]
    public RenderFragment IconTemplate { get; set; }
}
