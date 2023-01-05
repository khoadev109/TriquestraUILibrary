using Infinity.Blazor.UIControls.ProgressBars;

namespace Infinity.Blazor.UIControls.Tags;

public enum TagType
{
    Primary,
    Success,
    Warning,
    Error
}

public static class TagTypes
{
    public static Dictionary<TagType, string> ColorCssClasses => new Dictionary<TagType, string>
    {
        [TagType.Primary] = "triquestra-tag-primary",
        [TagType.Success] = "triquestra-tag-success",
        [TagType.Warning] = "triquestra-tag-warning",
        [TagType.Error] = "triquestra-tag-error",
    };

    public static string GetTagTypeCssClass(this TagType tagType)
    {
        ColorCssClasses.TryGetValue(tagType, out string cssClass);

        return cssClass;
    }
}
