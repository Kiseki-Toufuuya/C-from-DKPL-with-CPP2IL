namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = True)]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
{
	private static readonly ProfilerMarker k_TouchscreenUpdateMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_TouchAllocateMarker; //Field offset: 0x4
	[CompilerGenerated]
	private static Touchscreen <current>k__BackingField; //Field offset: 0x8
	internal static float s_TapTime; //Field offset: 0xC
	internal static float s_TapDelayTime; //Field offset: 0x10
	internal static float s_TapRadiusSquared; //Field offset: 0x14
	[CompilerGenerated]
	private TouchControl <primaryTouch>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; //Field offset: 0x12C

	public internal static Touchscreen current
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		internal set { } //Length: 89
	}

	public TouchControl primaryTouch
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	protected TouchControl[] touchControlArray
	{
		 get { } //Length: 29
		 set { } //Length: 114
	}

	public ReadOnlyArray<TouchControl> touches
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		 set { } //Length: 47
	}

	private static Touchscreen() { }

	public Touchscreen() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static Touchscreen get_current() { }

	[CompilerGenerated]
	public TouchControl get_primaryTouch() { }

	protected TouchControl[] get_touchControlArray() { }

	[CompilerGenerated]
	public ReadOnlyArray<TouchControl> get_touches() { }

	public virtual void MakeCurrent() { }

	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	protected void OnNextUpdate() { }

	protected virtual void OnRemoved() { }

	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CompilerGenerated]
	internal static void set_current(Touchscreen value) { }

	[CompilerGenerated]
	protected void set_primaryTouch(TouchControl value) { }

	protected void set_touchControlArray(TouchControl[] value) { }

	[CompilerGenerated]
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	private override void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

