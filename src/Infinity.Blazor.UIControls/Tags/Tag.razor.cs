using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Tags;

partial class Tag
{
    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public bool CanRemove { get; set; }

    [Parameter]
    public TagType TagType { get; set; }

    public bool Removed { get; set; }

    public void RemoveIcon()
    {
        Removed = true;
    }
}
