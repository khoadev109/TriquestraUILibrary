using Infinity.Blazor.UIControls.Icons;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.Selectors;

partial class Checkbox
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string SpriteClass { get; set; }

    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public string LabelText { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public string Width { get; set; }

    private bool _value;

    [Parameter]
    public bool Value
    {
        get => _value;
        set
        {
            if (!EqualityComparer<bool>.Default.Equals(value, _value))
            {
                _value = value;
                ValueChanged.InvokeAsync(value);
            }
        }
    }

    [Parameter]
    public EventCallback<bool> ValueChanged { get; set; }


    [Parameter]
    public EventCallback OnChangeHandler { get; set; }
}
