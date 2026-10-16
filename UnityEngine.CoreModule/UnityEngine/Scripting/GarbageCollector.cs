namespace UnityEngine.Scripting;

[NativeHeader("Runtime/Scripting/GarbageCollector.h")]
public static class GarbageCollector
{
	internal enum Mode
	{
		Disabled = 0,
		Enabled = 1,
		Manual = 2,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Mode> GCModeChanged; //Field offset: 0x0

	public static Mode GCMode
	{
		 set { } //Length: 136
	}

	private static Mode GetMode() { }

	public static void set_GCMode(Mode value) { }

	[NativeThrows]
	private static void SetMode(Mode mode) { }

}

