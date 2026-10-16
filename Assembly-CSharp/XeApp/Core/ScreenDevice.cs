namespace XeApp.Core;

public class ScreenDevice
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32, List`1<ResolutionSetting>, Boolean> <>9__23_0; //Field offset: 0x4
		public static Func<Int32, Int32, Boolean> <>9__23_1; //Field offset: 0x8
		public static Comparison<ResolutionSetting> <>9__23_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal bool <GetSupportResolutions>b__23_0(int width, int height, List<ResolutionSetting> list) { }

		internal bool <GetSupportResolutions>b__23_1(int width, int height) { }

		internal int <GetSupportResolutions>b__23_2(ResolutionSetting a, ResolutionSetting b) { }

	}

	[CompilerGenerated]
	private struct <ChangeResolutionSettingAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public ResolutionSetting setting; //Field offset: 0xC
		public FullScreenMode fullScreenMode; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class ResolutionSetting
	{
		public int Width; //Field offset: 0x8
		public int Height; //Field offset: 0xC
		public string Desc; //Field offset: 0x10

		public ResolutionSetting() { }

	}

	private const int AppBaseWidth = 1334; //Field offset: 0x0
	private const int AppBaseHeight = 750; //Field offset: 0x0
	private const int ContentLimitWidth = 1750; //Field offset: 0x0
	private const int ContentLimitHeight = 1000; //Field offset: 0x0
	private const int FadeRange = 120; //Field offset: 0x0
	public static int NativeWidth; //Field offset: 0x0
	public static int NativeHeight; //Field offset: 0x4
	public static Rect NativeSafeAreaRect; //Field offset: 0x8
	public static Rect SafeArea; //Field offset: 0x18
	public static int RenderWidth; //Field offset: 0x28
	public static int RenderHeight; //Field offset: 0x2C
	public static int ContentWidth; //Field offset: 0x30
	public static int ContentHeight; //Field offset: 0x34
	public static int ContentX; //Field offset: 0x38
	public static int ContentY; //Field offset: 0x3C
	public static float ContentScale; //Field offset: 0x40
	public static float ContentSlideY; //Field offset: 0x44
	public static int ScreenRenderTargetWidth; //Field offset: 0x48
	public static int ScreenRenderTargetHeight; //Field offset: 0x4C
	public static int ScreenRenderTargetHalfWidth; //Field offset: 0x50
	public static int ScreenRenderTargetHalfHeight; //Field offset: 0x54
	private static float ResolutionRatio; //Field offset: 0x58
	public static bool IsInit; //Field offset: 0x5C
	private static ScreenOrientation PrevOrientation; //Field offset: 0x60
	private static ScreenOrientation TargetOrientation; //Field offset: 0x64
	private static int recalcFrame; //Field offset: 0x68
	public static bool IsChangeRotate; //Field offset: 0x6C

	private static ScreenDevice() { }

	public ScreenDevice() { }

	public static void CalcContentArea(float renderWidth, float renderHeight, Rect safeArea, string modelName, out int contentWidth, out int contentHeight, out int contentX, out int contentY, out float contentScale, out float contentSlideY) { }

	public static void CalcResolutionV2(float deviceWidth, float deviceHeight, out float renderWidth, out float renderHeight) { }

	public static void ChangeAutorotate(ScreenOrientation orientation) { }

	[AsyncStateMachine(typeof(<ChangeResolutionSettingAsync>d__36))]
	public static UniTask ChangeResolutionSettingAsync(ResolutionSetting setting, FullScreenMode fullScreenMode) { }

	public static ScreenOrientation GetOrientation() { }

	private static Rect GetSafeArea() { }

	public static int GetSupportResolutions(out List<ResolutionSetting>& list, int targetWidth, int targetHeight) { }

	public static void InitNativeInfo() { }

	public static void InitResolution() { }

	public static bool IsValidOrientation() { }

	public static ScreenOrientation LoadAutorotate() { }

	private static bool NearEqual(int w, float fw) { }

	public static void RecalcContentArea() { }

	public static void SaveAutorotate(ScreenOrientation orientation) { }

	private static Rect SimulateRect(int x, int y, int w, int h) { }

	public static void WatchOrientation() { }

}

