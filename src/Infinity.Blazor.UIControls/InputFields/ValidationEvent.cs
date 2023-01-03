namespace Infinity.Blazor.UIControls.InputFields;

public enum ValidationEvent
{
    Input,
    Change
}

public static class ValidationEventMapper
{
    public static Telerik.Blazor.ValidationEvent MapToTelerikValidationEvent(this ValidationEvent validationEvent)
    {
        return validationEvent switch
        {
            ValidationEvent.Input => Telerik.Blazor.ValidationEvent.Input,
            ValidationEvent.Change => Telerik.Blazor.ValidationEvent.Change,
            _ => Telerik.Blazor.ValidationEvent.Input
        };
    }
}
