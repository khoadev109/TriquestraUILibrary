using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarHalfCircle
{
    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    public string GetBarRorateDegree(double value) => $"{45 + (value * 1.8)}deg";

    [Parameter]
    public ProgressBarColor Color { get; set; }

    public string ColorCssClass => Color.GetBarColorCssClass();

    [Parameter]
    public ProgressBarSize Size { get; set; }

    public string Width => $"{Size.GetSizes().Item1}px";

    public string Height => $"{Size.GetSizes().Item2}px";

    public string FontSize => $"{Size.GetSizes().Item3}px";

    public string ContainerHeight => $"{(Size.GetSizes().Item2 + 8)}px";
}
