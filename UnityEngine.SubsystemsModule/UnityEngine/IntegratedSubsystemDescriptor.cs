namespace UnityEngine;

[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x8

	public override string id
	{
		 get { } //Length: 21
	}

	protected IntegratedSubsystemDescriptor() { }

	public override string get_id() { }

}

