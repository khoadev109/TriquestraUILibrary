using System;
using System.Drawing;

namespace Infinity.Blazor.UIControls.ProgressBars
{
	public enum ProgressBarColor
	{
		Red,
		Green,
		Yellow
	}

	public static class ProgressBarColors
	{
        public static Dictionary<ProgressBarColor, string> ColorCssClasses => new Dictionary<ProgressBarColor, string>
        {
            [ProgressBarColor.Red] = "#B00020",
            [ProgressBarColor.Green] = "#0CAF60",
            [ProgressBarColor.Yellow] = "#FFD023"
        };

        public static string GetBarColorCssClass(this double currentPercentage, Dictionary<ProgressBarColor, double> mappedThresholdPercentageColors)
        {
            foreach (var item in mappedThresholdPercentageColors)
            {
                if (currentPercentage <= item.Value)
                {
                    ColorCssClasses.TryGetValue(item.Key, out string cssClass);
                    return cssClass;
                }
            }

            return string.Empty;
        }
    }
}
