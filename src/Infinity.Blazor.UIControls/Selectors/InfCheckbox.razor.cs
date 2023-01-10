using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Selectors;

partial class InfCheckbox
{
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public bool Indeterminate { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public bool Value { get; set; }
    
    [Parameter]
    public EventCallback OnChangeHandler { get; set; }

    [Parameter]
    public EventCallback OnBlurHandler { get; set; }

    [Parameter]
    public EventCallback IndeterminateChangedHandler { get; set; }

    [Parameter]
    public string LabelText { get; set; }
}
