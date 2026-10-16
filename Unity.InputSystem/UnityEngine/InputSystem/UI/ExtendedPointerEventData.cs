namespace UnityEngine.InputSystem.UI;

public class ExtendedPointerEventData : PointerEventData
{
	[CompilerGenerated]
	private InputControl <control>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private int <touchId>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private UIPointerType <pointerType>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private int <uiToolkitPointerId>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Vector3 <trackedDevicePosition>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Quaternion <trackedDeviceOrientation>k__BackingField; //Field offset: 0x164

	public InputControl control
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public InputDevice device
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public UIPointerType pointerType
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int touchId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Quaternion trackedDeviceOrientation
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public Vector3 trackedDevicePosition
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		 set { } //Length: 30
	}

	public int uiToolkitPointerId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public ExtendedPointerEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public InputControl get_control() { }

	[CompilerGenerated]
	public InputDevice get_device() { }

	[CompilerGenerated]
	public UIPointerType get_pointerType() { }

	[CompilerGenerated]
	public int get_touchId() { }

	[CompilerGenerated]
	public Quaternion get_trackedDeviceOrientation() { }

	[CompilerGenerated]
	public Vector3 get_trackedDevicePosition() { }

	[CompilerGenerated]
	public int get_uiToolkitPointerId() { }

	private static int GetPenPointerId(Pen pen) { }

	private static int GetTouchPointerId(TouchControl touchControl) { }

	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	internal void ReadDeviceState() { }

	[CompilerGenerated]
	public void set_control(InputControl value) { }

	[CompilerGenerated]
	public void set_device(InputDevice value) { }

	[CompilerGenerated]
	public void set_pointerType(UIPointerType value) { }

	[CompilerGenerated]
	public void set_touchId(int value) { }

	[CompilerGenerated]
	public void set_trackedDeviceOrientation(Quaternion value) { }

	[CompilerGenerated]
	public void set_trackedDevicePosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_uiToolkitPointerId(int value) { }

	public virtual string ToString() { }

	internal static int TouchIdFromPointerId(int pointerId) { }

}

