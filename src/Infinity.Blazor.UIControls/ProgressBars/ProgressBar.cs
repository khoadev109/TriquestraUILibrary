using System;
using Microsoft.AspNetCore.Components;

namespace Infinity.Blazor.UIControls.ProgressBars
{
    public class ProgressBar : ComponentBase
    {
        [Parameter]
        public double Max { get; set; } = 100;

        [Parameter]
        public double Value { get; set; }

        protected double CurrentPercentage => Value / Max * 100;

        [Parameter]
        public double LowThresholdMaxPercentage { get; set; } = 25;

        [Parameter]
        public double MidThresholdMaxPercentage { get; set; } = 50;

        [Parameter]
        public double HighThresholdMaxPercentage { get; set; } = 100;

        [Parameter]
        public string Width { get; set; } = "500px";

        private Dictionary<ProgressBarColor, double> MappedThresholdPercentangeColor => (new Dictionary<ProgressBarColor, double>
        {
            [ProgressBarColor.Red] = LowThresholdMaxPercentage,
            [ProgressBarColor.Yellow] = MidThresholdMaxPercentage,
            [ProgressBarColor.Green] = HighThresholdMaxPercentage,
        })
        .OrderBy(x => x.Value)
        .ToDictionary(x => x.Key, x => x.Value);

        protected string BarColorCssClass => CurrentPercentage.GetBarColorCssClass(MappedThresholdPercentangeColor);
    }
}
