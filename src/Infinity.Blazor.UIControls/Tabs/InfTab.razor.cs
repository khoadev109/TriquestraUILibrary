using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;

namespace Infinity.Blazor.UIControls.Tabs;

partial class InfTab
{
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public int ActiveTabIndex { get; set; }

    [Parameter]
    public bool PersistTabContent { get; set; }

    [Parameter]
    public bool Scrollable { get; set; }

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public string Height { get; set; }

    [Parameter]
    public TabPosition TabPosition { get; set; }

    [Parameter]
    public IList<TabStrip> Tabs { get; set; } = new List<TabStrip>();

    public IList<TabStrip> VisibleTabs => Tabs.Where(x => x.Visible).ToList();

    public TelerikTabStrip TabRef { get; set; }
}
