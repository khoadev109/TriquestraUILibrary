using System.Linq.Expressions;
using Infinity.Blazor.UIControls.Icons;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.InputFields;

partial class InfTextBox
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Name { get; set; }

    [Parameter]
    public string PlaceHolder { get; set; }

    [Parameter]
    public bool Password { get; set; }

    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public string LabelText { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public int DebounceDelay { get; set; }

    [Parameter]
    public string Width { get; set; } = "500px";

    private string _value;

    [Parameter]
    public string Value
    {
        get => _value;
        set
        {
            if (!EqualityComparer<string>.Default.Equals(value, _value))
            {
                _value = value;
                ValueChanged.InvokeAsync(value);
            }
        }
    }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public Expression<Func<string>> ValueExpression { get; set; }

    [Parameter]
    public ValidationEvent ValidateOn { get; set; }

    private RenderFragment _iconTemplate;

    [Parameter]
    public RenderFragment IconTemplate
    {
        get => _iconTemplate;
        set
        {
            if (!string.IsNullOrWhiteSpace(LabelText))
            {
                value = null;
            }
            _iconTemplate = value;
        }
    }

    [Parameter]
    public IconPosition IconPosition { get; set; }

    public string IconClass => (IconPosition == IconPosition.Right
                                ? "triquestra-input-text-icon-right"
                                : "triquestra-input-text-icon-left");

    [Parameter]
    public EventCallback OnChangeHandler { get; set; }

    [Parameter]
    public EventCallback OnBlurHandler { get; set; }
}
