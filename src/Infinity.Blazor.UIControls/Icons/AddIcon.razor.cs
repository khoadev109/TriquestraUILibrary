using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Icons;

partial class AddIcon : BaseIcon
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Color { get; set; }
}
