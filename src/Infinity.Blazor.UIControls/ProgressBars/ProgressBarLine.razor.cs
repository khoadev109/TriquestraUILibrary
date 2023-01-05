﻿using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarLine
{
    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    public string GetRoundedPercentageValue(double value) => $"{(value.ToString("N0", CultureInfo.InvariantCulture))}%";

    [Parameter]
    public ProgressBarColor Color { get; set; }

    public string ColorCssClass => Color.GetBarColorCssClass();
}
