namespace UnityEngine.InputSystem.XR;

[InputControlLayout(commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, isGenericTypeOfDevice = True, displayName = "XR Controller")]
public class XRController : TrackedDevice
{

	public static XRController leftHand
	{
		 get { } //Length: 130
	}

	public static XRController rightHand
	{
		 get { } //Length: 130
	}

	public XRController() { }

	protected virtual void FinishSetup() { }

	public static XRController get_leftHand() { }

	public static XRController get_rightHand() { }

}

