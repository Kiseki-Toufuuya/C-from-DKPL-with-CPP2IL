namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[NativeHeader("Runtime/Burst/Burst.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
internal static class BurstCompilerService
{

	[ThreadSafe]
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

}

