namespace Infinity.Blazor.UIControls.Buttons;

public enum FillMode
{
    Solid,
    Flat,
    Outline,
    Link
}

public static class FillModeMapper
{
    public static string MapToTelerikFillMode(this FillMode fillMode)
    {
        return fillMode switch
        {
            FillMode.Solid => Telerik.Blazor.ThemeConstants.Button.FillMode.Solid,
            FillMode.Flat => Telerik.Blazor.ThemeConstants.Button.FillMode.Flat,
            FillMode.Outline => Telerik.Blazor.ThemeConstants.Button.FillMode.Outline,
            FillMode.Link => Telerik.Blazor.ThemeConstants.Button.FillMode.Link,
            _ => Telerik.Blazor.ThemeConstants.Button.FillMode.Solid
        };
    }
}