using System;
namespace Infinity.Blazor.UIControls.ProgressBars
{
	public enum ProgressBarSize
	{
		Large,
		Small
	}

	public static class ProgressBarSizes
	{
		public static (int, int, int) GetSizes(this ProgressBarSize progressBarSize)
		{
            return progressBarSize switch
            {
                ProgressBarSize.Large => (116, 61, 28),
                ProgressBarSize.Small => (92, 48, 20),
                _ => (116, 61, 28)
            };
        }
	}
}
