using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class ProgressBarHalfCircle
{
    [Parameter]
    public double Max { get; set; } = 100;

    [Parameter]
    public double Value { get; set; }

    [Parameter]
    public ProgressBarColor Color { get; set; }

    public string ColorCssClass => Color.GetBarColorCssClass();

    // Css styles based on color

    private const string CircleBackgroundColor = "#DCDCDC";

    public string CircleLeftStyle => $"background: {(Value <= 0 ? CircleBackgroundColor : ColorCssClass)}";

    public string CircleRightStyle => $"background: {(Value <= 0 || Value < 100 ? CircleBackgroundColor : ColorCssClass)}";

    public string BarProgressedStyle => $@"
        transform: rotate({45 + (Value * 1.8)}deg);
        border-bottom-color: {(Value <= 0 ? "transparent" : ColorCssClass)};
        border-right-color: {(Value <= 0 ? "transparent" : ColorCssClass)};
        {(Value == Max ? $"border-color: {ColorCssClass}" : "")}";

    public string BarValueStyle => $"color: {ColorCssClass};";
}
