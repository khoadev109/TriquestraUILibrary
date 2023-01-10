namespace Infinity.Blazor.UIControls.ProgressBars;

public enum ProgressBarHalfCircleSize
{
    Large,
    Small
}

public class ProgressBarHalfCircleStyle
{
    public string Width { get; set; }
    public string Height { get; set; }
    public string Thickness { get; set; }
    public string FontSize { get; set; }
}

public static class ProgressBarHalfCircleSizes
{
    public static ProgressBarHalfCircleStyle GetControlStyles(this ProgressBarHalfCircleSize size)
    {
        return size switch
        {
            ProgressBarHalfCircleSize.Small => new ProgressBarHalfCircleStyle
            {
                Width = "92px",
                Height = "48px",
                Thickness = "8px",
                FontSize = "20px"
            },
            ProgressBarHalfCircleSize.Large => new ProgressBarHalfCircleStyle
            {
                Width = "116px",
                Height = "61px",
                Thickness = "12px",
                FontSize = "28px"
            },
            _ => new ProgressBarHalfCircleStyle
            {
                Width = "116px",
                Height = "61px",
                Thickness = "12px",
                FontSize = "28px"
            }
        };
    }
}
