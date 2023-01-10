using Infinity.Blazor.UIControls.Buttons;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars;

partial class InfProgressBarHalfCircle
{
    [Parameter]
    public ProgressBarHalfCircleSize Size { get; set; }

    protected ProgressBarHalfCircleStyle Styles => Size.GetControlStyles();

    // Css styles based on color

    private const string CircleBackgroundColor = "#DCDCDC";

    protected string CircleLeftStyle => $@"
        background: {(Value <= 0 ? CircleBackgroundColor : BarColorCssClass)};
        width: {Styles.Thickness};
        height: {Styles.Thickness};";

    protected string CircleRightStyle => @$"
        background: {(Value <= 0 || Value < Max ? CircleBackgroundColor : BarColorCssClass)};
        width: {Styles.Thickness};
        height: {Styles.Thickness};";

    protected string BarWrapperStyle => @$"
        width: {Styles.Width};
        height: {Styles.Height};";

    protected string BarProgressedStyle => $@"
        transform: rotate({45 + (CurrentPercentage * 1.8)}deg);
        width: {Styles.Width};
        height: {Styles.Width};
        border: {Styles.Thickness} solid #DCDCDC;
        border-bottom-color: {(Value <= 0 ? "transparent" : BarColorCssClass)};
        border-right-color: {(Value <= 0 ? "transparent" : BarColorCssClass)};
        {(Value == Max ? $"border-color: {BarColorCssClass}" : "")}";

    protected string BarValueStyle => @$"
        color: {BarColorCssClass};
        font-size: {Styles.FontSize};
        bottom: {(Size == ProgressBarHalfCircleSize.Large ? "4px" : "-10px")}";
}
