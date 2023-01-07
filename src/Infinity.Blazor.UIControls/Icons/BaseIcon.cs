using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Icons
{
    public interface IBaseIcon
    {
        string Class { get; set; }
        string Color { get; set; }
    }

    public class BaseIcon : ComponentBase, IBaseIcon
    {
        [Parameter]
        public string Class { get; set; } = "triquestra-icon";

        [Parameter]
        public string Color { get; set; } = "#202020";
    }
}
