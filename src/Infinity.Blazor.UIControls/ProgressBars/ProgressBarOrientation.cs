namespace Infinity.Blazor.UIControls.ProgressBars;

public enum ProgressBarOrientation
{
    Horizontal,
    Vertical
}

public static class ProgressBarOrientationMapper
{
    public static Telerik.Blazor.ProgressBarOrientation MapToTelerikProgressBarOrientation(this ProgressBarOrientation progressBarOrientation)
    {
        return progressBarOrientation switch
        {
            ProgressBarOrientation.Horizontal => Telerik.Blazor.ProgressBarOrientation.Horizontal,
            ProgressBarOrientation.Vertical => Telerik.Blazor.ProgressBarOrientation.Vertical,
            _ => Telerik.Blazor.ProgressBarOrientation.Horizontal
        };
    }
}
