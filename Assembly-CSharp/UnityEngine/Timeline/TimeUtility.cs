namespace UnityEngine.Timeline;

public static class TimeUtility
{
	public static readonly double kTimeEpsilon; //Field offset: 0x0
	public static readonly double k_MaxTimelineDurationInSeconds; //Field offset: 0x8

	private static TimeUtility() { }

	public static double GetEpsilon(double time, double frameRate) { }

	public static int ToFrames(double time, double frameRate) { }

	private static void ValidateFrameRate(double frameRate) { }

}

