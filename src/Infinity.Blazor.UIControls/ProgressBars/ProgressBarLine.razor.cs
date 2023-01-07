using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarLine
{
    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    [Parameter]
    public ProgressBarColor Color { get; set; }

    public string ColorCssClass => Color.GetBarColorCssClass();

    [Parameter]
    public string Width { get; set; } = "500px";
}
