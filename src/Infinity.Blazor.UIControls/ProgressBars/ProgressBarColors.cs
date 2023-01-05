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

	public static class ProgressBars
	{
        public static Dictionary<ProgressBarColor, string> ColorCssClasses => new Dictionary<ProgressBarColor, string>
        {
            [ProgressBarColor.Red] = "#B00020",
            [ProgressBarColor.Green] = "#0CAF60",
            [ProgressBarColor.Yellow] = "#FFD023"
        };

        public static string GetBarColorCssClass(this ProgressBarColor color)
        {
            ColorCssClasses.TryGetValue(color, out string cssClass);

            return cssClass;
        }
    }
}
