namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[UsedByNativeCode]
public class IntegratedSubsystem
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x8
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0xC

	public IntegratedSubsystem() { }

	internal void SetHandle(IntegratedSubsystem subsystem) { }

	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }

}

