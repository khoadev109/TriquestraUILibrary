using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Infinity.Blazor.UIControls.Icons;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Telerik.Blazor;

namespace Infinity.Blazor.UIControls.InputFields;

partial class TextBox
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Title { get; set; }
    
    [Parameter]
    public string SpriteClass { get; set; }
    
    [Parameter]
    public bool Enabled { get; set; } = true;

    [Parameter]
    public EventCallback OnChangeHandler { get; set; }

    [Parameter]
    public EventCallback OnBlurHandler { get; set; }

    [Parameter]
    public string LabelText { get; set; }

    [Parameter]
    public string PlaceHolder { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public ValidationEvent ValidateOn { get; set; }

    [Parameter]
    public RenderFragment<string> ValidationMessage { get; set; }

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public string BindValue { get; set; }

    [Parameter]
    public string Error { get; set; }

    [Parameter]
    public bool Password { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public IconPosition IconPosition { get; set; }
}
