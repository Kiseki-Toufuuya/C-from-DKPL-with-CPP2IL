namespace UnityEngine.Diagnostics;

[NativeHeader("Runtime/Export/Diagnostics/DiagnosticsUtils.bindings.h")]
[NativeHeader("Runtime/Misc/GarbageCollectSharedAssets.h")]
public static class Utils
{

	[FreeFunction("DiagnosticsUtils_Bindings::ForceCrash", IsThreadSafe = True, ThrowsException = True)]
	public static void ForceCrash(ForcedCrashCategory crashCategory) { }

}

