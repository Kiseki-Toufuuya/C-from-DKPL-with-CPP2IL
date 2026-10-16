namespace UnityEngine.InputSystem.Controls;

public class ButtonControl : AxisControl
{
	internal static float s_GlobalDefaultButtonPressPoint; //Field offset: 0x0
	internal const float kMinButtonPressPoint = 0.0001; //Field offset: 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; //Field offset: 0x4
	private bool m_NeedsToCheckFramePress; //Field offset: 0xE8
	private uint m_UpdateCountLastPressed; //Field offset: 0xEC
	private uint m_UpdateCountLastReleased; //Field offset: 0xF0
	private bool m_LastUpdateWasPress; //Field offset: 0xF4
	[CompilerGenerated]
	private bool <needsToCheckFramePress>k__BackingField; //Field offset: 0xF5
	public float pressPoint; //Field offset: 0xF8

	public bool isPressed
	{
		 get { } //Length: 161
	}

	internal bool needsToCheckFramePress
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public float pressPointOrDefault
	{
		 get { } //Length: 72
	}

	public bool wasPressedThisFrame
	{
		 get { } //Length: 342
	}

	public bool wasReleasedThisFrame
	{
		 get { } //Length: 336
	}

	public ButtonControl() { }

	private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) { }

	public bool get_isPressed() { }

	[CompilerGenerated]
	internal bool get_needsToCheckFramePress() { }

	public float get_pressPointOrDefault() { }

	public bool get_wasPressedThisFrame() { }

	public bool get_wasReleasedThisFrame() { }

	public bool IsValueConsideredPressed(float value) { }

	[CompilerGenerated]
	private void set_needsToCheckFramePress(bool value) { }

	internal void UpdateWasPressed() { }

}

