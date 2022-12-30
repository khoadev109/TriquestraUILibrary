using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
namespace Infinity.Blazor.UIControls.Tabs;

partial class Tab
{
    [Parameter]
    public string Id { get; set; }
    
    [Parameter]
    public string SpriteClass { get; set; }

    [Parameter]
    public RenderFragment TabTemplate { get; set; }

    [Parameter]
    public TabType Type { get; set; }
}