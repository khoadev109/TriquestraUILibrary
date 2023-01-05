using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Icons;

partial class ListAltIcon : BaseIcon
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Color { get; set; }

    [Parameter]
    public int Width { get; set; }

    [Parameter]
    public int Height { get; set; }
}
