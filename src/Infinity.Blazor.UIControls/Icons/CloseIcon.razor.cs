using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Icons;

partial class CloseIcon
{
    [Parameter]
    public EventCallback OnRemove { get; set; }
}
