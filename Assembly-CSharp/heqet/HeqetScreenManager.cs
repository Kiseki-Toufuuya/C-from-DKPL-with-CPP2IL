namespace Heqet;

public class HeqetScreenManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		private struct <<-ctor>b__35_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
			private Awaiter <>u__1; //Field offset: 0x8

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UniTaskVoid> <>9__35_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		[AsyncStateMachine(typeof(<<-ctor>b__35_0>d))]
		internal UniTaskVoid <.ctor>b__35_0() { }

	}

	[CompilerGenerated]
	private struct <ApplyDisplaySettingAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public HeqetScreenManager <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eDisplayMode
	{
		Borderless = 0,
		Fullscreen = 1,
		Window = 2,
	}

	internal enum eFrameRate
	{
		VSync = 0,
		FPS60 = 1,
		FPS120 = 2,
		Unlimit = 3,
	}

	private static HeqetScreenManager instance; //Field offset: 0x0
	[CompilerGenerated]
	private IntPtr <m_pfw>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private IntPtr <m_pfh>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Action<Int32, Int32, Int32> <UpdateResolutionCallback>k__BackingField; //Field offset: 0x10
	private int m_CurrentDisplayMode; //Field offset: 0x14
	[CompilerGenerated]
	private eDisplayMode <DisplayMode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private eFrameRate <FrameRate>k__BackingField; //Field offset: 0x1C
	private int m_currentResolutionIndex; //Field offset: 0x20
	private List<ResolutionSetting> m_SupportResolutions; //Field offset: 0x24

	public int CurrentDisplayMode
	{
		 set { } //Length: 14
	}

	public int CurrentResolutionIndex
	{
		 get { } //Length: 11
		 set { } //Length: 122
	}

	public eDisplayMode DisplayMode
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public eFrameRate FrameRate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsFullScreen
	{
		 get { } //Length: 15
	}

	public private IntPtr m_pfh
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private IntPtr m_pfw
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public List<ResolutionSetting> SupportResolutions
	{
		 get { } //Length: 11
	}

	public private Action<Int32, Int32, Int32> UpdateResolutionCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public HeqetScreenManager() { }

	public void ApplyDisplaySetting() { }

	[AsyncStateMachine(typeof(<ApplyDisplaySettingAsync>d__45))]
	public UniTask ApplyDisplaySettingAsync() { }

	public void ApplyFrameRate() { }

	protected virtual void Finalize() { }

	public int get_CurrentResolutionIndex() { }

	[CompilerGenerated]
	public eDisplayMode get_DisplayMode() { }

	[CompilerGenerated]
	public eFrameRate get_FrameRate() { }

	public bool get_IsFullScreen() { }

	[CompilerGenerated]
	private IntPtr get_m_pfh() { }

	[CompilerGenerated]
	private IntPtr get_m_pfw() { }

	public List<ResolutionSetting> get_SupportResolutions() { }

	[CompilerGenerated]
	private Action<Int32, Int32, Int32> get_UpdateResolutionCallback() { }

	public static HeqetScreenManager GetInstance() { }

	public int GetResolutionIndex(int width, int height) { }

	public void InitDisplay(int displaymode, int width, int height, int framerate) { }

	public void OnUpdateResolution(int displayMode, int resorutionWidth, int resolutionHeight) { }

	public void ResetResolution() { }

	public void set_CurrentDisplayMode(int value) { }

	public void set_CurrentResolutionIndex(int value) { }

	[CompilerGenerated]
	public void set_DisplayMode(eDisplayMode value) { }

	[CompilerGenerated]
	public void set_FrameRate(eFrameRate value) { }

	[CompilerGenerated]
	public void set_m_pfh(IntPtr value) { }

	[CompilerGenerated]
	public void set_m_pfw(IntPtr value) { }

	[CompilerGenerated]
	public void set_UpdateResolutionCallback(Action<Int32, Int32, Int32> value) { }

	public void UpdateFullScreenResolution() { }

	public void UpdateSupportResolutions(int width, int height) { }

	public void UpdateWindowResolution() { }

}

