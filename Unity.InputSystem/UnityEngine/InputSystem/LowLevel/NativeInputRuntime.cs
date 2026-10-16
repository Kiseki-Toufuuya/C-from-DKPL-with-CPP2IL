namespace UnityEngine.InputSystem.LowLevel;

internal class NativeInputRuntime : IInputRuntime
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action<InputUpdateType> value; //Field offset: 0x8

		public <>c__DisplayClass10_0() { }

		internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Func<InputUpdateType, Boolean> value; //Field offset: 0x8

		public <>c__DisplayClass13_0() { }

		internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public InputUpdateDelegate value; //Field offset: 0x8

		public <>c__DisplayClass7_0() { }

		internal void <set_onUpdate>b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) { }

	}

	public static readonly NativeInputRuntime instance; //Field offset: 0x0
	private bool m_RunInBackground; //Field offset: 0x8
	private Action m_ShutdownMethod; //Field offset: 0xC
	private InputUpdateDelegate m_OnUpdate; //Field offset: 0x10
	private Action<InputUpdateType> m_OnBeforeUpdate; //Field offset: 0x14
	private Func<InputUpdateType, Boolean> m_OnShouldRunUpdate; //Field offset: 0x18
	private float m_PollingFrequency; //Field offset: 0x1C
	private bool m_DidCallOnShutdown; //Field offset: 0x20
	private Action<Boolean> m_FocusChangedMethod; //Field offset: 0x24

	public override double currentTime
	{
		 get { } //Length: 60
	}

	public override double currentTimeForFixedUpdate
	{
		 get { } //Length: 83
	}

	public override double currentTimeOffsetToRealtimeSinceStartup
	{
		 get { } //Length: 60
	}

	public override bool isPlayerFocused
	{
		 get { } //Length: 60
	}

	public override bool normalizeScrollWheelDelta
	{
		 get { } //Length: 60
		 set { } //Length: 67
	}

	public override Action<InputUpdateType> onBeforeUpdate
	{
		 get { } //Length: 11
		 set { } //Length: 271
	}

	public override Action<Int32, String> onDeviceDiscovered
	{
		 get { } //Length: 60
		 set { } //Length: 67
	}

	public override Action<Boolean> onPlayerFocusChanged
	{
		 get { } //Length: 11
		 set { } //Length: 218
	}

	public override Func<InputUpdateType, Boolean> onShouldRunUpdate
	{
		 get { } //Length: 11
		 set { } //Length: 271
	}

	public override Action onShutdown
	{
		 get { } //Length: 11
		 set { } //Length: 218
	}

	public override InputUpdateDelegate onUpdate
	{
		 get { } //Length: 11
		 set { } //Length: 266
	}

	public override float pollingFrequency
	{
		 get { } //Length: 11
		 set { } //Length: 88
	}

	public override bool runInBackground
	{
		 get { } //Length: 78
		 set { } //Length: 14
	}

	public override ScreenOrientation screenOrientation
	{
		 get { } //Length: 11
	}

	public override Vector2 screenSize
	{
		 get { } //Length: 57
	}

	public override float scrollWheelDeltaPerTick
	{
		 get { } //Length: 60
	}

	public override float unscaledGameTime
	{
		 get { } //Length: 11
	}

	private static NativeInputRuntime() { }

	public NativeInputRuntime() { }

	public override int AllocateDeviceId() { }

	public override long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	public override double get_currentTime() { }

	public override double get_currentTimeForFixedUpdate() { }

	public override double get_currentTimeOffsetToRealtimeSinceStartup() { }

	public override bool get_isPlayerFocused() { }

	public override bool get_normalizeScrollWheelDelta() { }

	public override Action<InputUpdateType> get_onBeforeUpdate() { }

	public override Action<Int32, String> get_onDeviceDiscovered() { }

	public override Action<Boolean> get_onPlayerFocusChanged() { }

	public override Func<InputUpdateType, Boolean> get_onShouldRunUpdate() { }

	public override Action get_onShutdown() { }

	public override InputUpdateDelegate get_onUpdate() { }

	public override float get_pollingFrequency() { }

	public override bool get_runInBackground() { }

	public override ScreenOrientation get_screenOrientation() { }

	public override Vector2 get_screenSize() { }

	public override float get_scrollWheelDeltaPerTick() { }

	public override float get_unscaledGameTime() { }

	private void OnFocusChanged(bool focus) { }

	private void OnShutdown() { }

	private bool OnWantsToShutdown() { }

	public override void QueueEvent(InputEvent* ptr) { }

	public override void set_normalizeScrollWheelDelta(bool value) { }

	public override void set_onBeforeUpdate(Action<InputUpdateType> value) { }

	public override void set_onDeviceDiscovered(Action<Int32, String> value) { }

	public override void set_onPlayerFocusChanged(Action<Boolean> value) { }

	public override void set_onShouldRunUpdate(Func<InputUpdateType, Boolean> value) { }

	public override void set_onShutdown(Action value) { }

	public override void set_onUpdate(InputUpdateDelegate value) { }

	public override void set_pollingFrequency(float value) { }

	public override void set_runInBackground(bool value) { }

	public override void Update(InputUpdateType updateType) { }

}

