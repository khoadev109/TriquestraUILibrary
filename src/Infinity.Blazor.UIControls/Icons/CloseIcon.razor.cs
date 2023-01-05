using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Icons;

partial class CloseIcon : BaseIcon
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Color { get; set; }

    [Parameter]
    public EventCallback OnRemove { get; set; }
}
