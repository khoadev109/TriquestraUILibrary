using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarHalfCircle
{
    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    public string GetRoundedPercentageValue(double value) => $"{(value.ToString("N0", CultureInfo.InvariantCulture))}%";

    public string GetBarRorateDegree(double value) => $"{45 + (value * 1.8)}deg";

    [Parameter]
    public ProgressBarColor Color { get; set; }

    public string ColorCssClass => Color.GetBarColorCssClass();
}
