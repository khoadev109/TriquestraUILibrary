using System;
using System.Globalization;
using Infinity.Blazor.UIControls.Tags;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBar
{
    [Parameter]
    public ProgressBarColor Color { get; set; }

    public Dictionary<ProgressBarColor, string> BarColorsCssClasses => new Dictionary<ProgressBarColor, string>
    {
        [ProgressBarColor.Red] = "#B00020",
        [ProgressBarColor.Green] = "#0CAF60",
        [ProgressBarColor.Yellow] = "#FFD023"
    };

    public string GetBarColorCssClass()
    {
        BarColorsCssClasses.TryGetValue(Color, out string cssClass);

        return cssClass;
    }

    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    public string GetRoundedPercentageValue(double value) => $"{(value.ToString("N0", CultureInfo.InvariantCulture))}%";

    public string GetBarRorateDegree(double value) => $"{45 + (value * 1.8)}deg";
}
