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

    public Dictionary<TagType, string> Types => new Dictionary<TagType, string>
    {
        [TagType.Primary] = "triquestra-tag-primary",
        [TagType.Success] = "triquestra-tag-success",
        [TagType.Warning] = "triquestra-tag-warning",
        [TagType.Error] = "triquestra-tag-error",
    };

    public string GetTagTypeCssClass()
    {
        Types.TryGetValue(TagType, out string cssClass);

        return cssClass;
    }

    public bool Removed { get; set; }

    public void RemoveIcon()
    {
        Removed = true;
    }
}
