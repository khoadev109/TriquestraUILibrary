using Microsoft.AspNetCore.Components;
namespace Infinity.Blazor.UIControls.Tags;
partial class Tag
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Label { get; set; }
    
    [Parameter]
    public string SpriteClass { get; set; }
    
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public EventCallback OnRemove { get; set; }

    [Parameter]
    public bool IsRemove { get; set; } = false;

    [Parameter]
    public TagType Type { get; set; }
}