using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarLine
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }


    [Parameter]
    public ProgressBarOrientation Orientation { get; set; } = ProgressBarOrientation.Horizontal;
}
