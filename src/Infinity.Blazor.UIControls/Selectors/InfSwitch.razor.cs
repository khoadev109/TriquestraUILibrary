using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Selectors;

partial class InfSwitch
{
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public bool Value { get; set; }

    [Parameter]
    public string OnLabel { get; set; }

    [Parameter]
    public string OffLabel { get; set; }

    [Parameter]
    public EventCallback OnChangeHandler { get; set; }

    [Parameter]
    public EventCallback OnBlurHandler { get; set; }
}
