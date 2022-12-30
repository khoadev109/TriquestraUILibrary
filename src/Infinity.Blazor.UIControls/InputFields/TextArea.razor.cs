using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.InputFields;

partial class TextArea
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Title { get; set; }
    
    [Parameter]
    public string SpriteClass { get; set; }
    
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public EventCallback ChangeHandle { get; set; }

    [Parameter]
    public string LabelText { get; set; }

    [Parameter]
    public string PlaceHolder { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public string Error { get; set; }

    [Parameter]
    public bool Password { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public InputType IconPosition { get; set; }
}