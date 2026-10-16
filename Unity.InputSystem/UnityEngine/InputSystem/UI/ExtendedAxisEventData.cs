namespace UnityEngine.InputSystem.UI;

internal class ExtendedAxisEventData : AxisEventData, INavigationEventData
{
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x1C

	public override InputDevice device
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ExtendedAxisEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public override InputDevice get_device() { }

	[CompilerGenerated]
	public void set_device(InputDevice value) { }

	public virtual string ToString() { }

}

