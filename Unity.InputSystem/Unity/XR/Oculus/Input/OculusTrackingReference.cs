namespace Unity.XR.Oculus.Input;

public class OculusTrackingReference : TrackedDevice
{
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x124

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceIsTracked"})]
	public ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceTrackingState"})]
	public IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public OculusTrackingReference() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	protected void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_trackingState(IntegerControl value) { }

}

