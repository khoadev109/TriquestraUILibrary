using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBar
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    public string RoundedPercentageValue => Math.Round(Value).ToString("P1", CultureInfo.InvariantCulture);

    [Parameter]
    public ProgressBarOrientation Orientation { get; set; } = ProgressBarOrientation.Vertical;

    [Parameter]
    public string Color { get; set; }
}
