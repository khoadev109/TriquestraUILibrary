namespace Infinity.Blazor.UIControls.Buttons;

public enum ButtonType
{
    Submit,
    Button,
    Reset,
    Right,
    Left
}

public static class ButtonTypeMapper
{
    public static Telerik.Blazor.ButtonType MapToTelerikButtonType(this ButtonType buttonType)
    {
        return buttonType switch
        {
            ButtonType.Button => Telerik.Blazor.ButtonType.Button,
            ButtonType.Reset => Telerik.Blazor.ButtonType.Reset,
            ButtonType.Submit => Telerik.Blazor.ButtonType.Submit,
            _ => Telerik.Blazor.ButtonType.Submit
        };
    }
}