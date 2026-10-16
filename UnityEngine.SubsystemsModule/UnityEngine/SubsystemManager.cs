namespace UnityEngine;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action beforeReloadSubsystems; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action afterReloadSubsystems; //Field offset: 0x4
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; //Field offset: 0x8
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; //Field offset: 0xC
	private static List<Subsystem> s_DeprecatedSubsystems; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action reloadSubsytemsStarted; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action reloadSubsytemsCompleted; //Field offset: 0x18

	private static SubsystemManager() { }

	[RequiredByNativeCode]
	private static void ClearSubsystems() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	[RequiredByNativeCode]
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	private static void ReloadSubsystemsStarted() { }

	private static void StaticConstructScriptingClassMap() { }

}

