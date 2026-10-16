namespace UnityEngine.Timeline;

internal static class TimeUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Char, Boolean> <>9__19_0; //Field offset: 0x4
		public static Func<Char, Boolean> <>9__19_1; //Field offset: 0x8
		public static Func<Char, Boolean> <>9__20_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal bool <ParseTimeCode>b__19_0(char c) { }

		internal bool <ParseTimeCode>b__19_1(char c) { }

		internal bool <ParseTimeSeconds>b__20_0(char c) { }

	}

	public static readonly double kTimeEpsilon; //Field offset: 0x0
	public static readonly double kFrameRateEpsilon; //Field offset: 0x8
	public static readonly double k_MaxTimelineDurationInSeconds; //Field offset: 0x10
	public static readonly double kFrameRateRounding; //Field offset: 0x18

	private static TimeUtility() { }

	public static double FromFrames(int frames, double frameRate) { }

	public static double FromFrames(double frames, double frameRate) { }

	public static double GetAnimationClipLength(AnimationClip clip) { }

	public static FrameRate GetClosestFrameRate(double frameRate) { }

	public static double GetEpsilon(double time, double frameRate) { }

	public static int NextFrame(double time, double frameRate) { }

	public static double NextFrameTime(double time, double frameRate) { }

	public static bool OnFrameBoundary(double time, double frameRate, double epsilon) { }

	public static bool OnFrameBoundary(double time, double frameRate) { }

	public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue) { }

	public static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue) { }

	public static int PreviousFrame(double time, double frameRate) { }

	public static double PreviousFrameTime(double time, double frameRate) { }

	private static string RemoveChar(string str, Func<Char, Boolean> charToRemoveFunc) { }

	public static double RoundToFrame(double time, double frameRate) { }

	public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2") { }

	public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2") { }

	public static double ToExactFrames(double time, double frameRate) { }

	public static FrameRate ToFrameRate(StandardFrameRates enumValue) { }

	public static int ToFrames(double time, double frameRate) { }

	internal static bool ToStandardFrameRate(FrameRate rate, out StandardFrameRates standard) { }

	private static void ValidateFrameRate(double frameRate) { }

}

