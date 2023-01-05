public enum TabPosition
{
    Top,
    Left,
    Right,
    Bottom
}

public static class TabPositionMapper
{
    public static Telerik.Blazor.TabPosition MapToTelerikTabPosition(this TabPosition buttonType)
    {
        return buttonType switch
        {
            TabPosition.Top => Telerik.Blazor.TabPosition.Top,
            TabPosition.Left => Telerik.Blazor.TabPosition.Left,
            TabPosition.Right => Telerik.Blazor.TabPosition.Right,
            TabPosition.Bottom => Telerik.Blazor.TabPosition.Bottom,
            _ => Telerik.Blazor.TabPosition.Top
        };
    }
}