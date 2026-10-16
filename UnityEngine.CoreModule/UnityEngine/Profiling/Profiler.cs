namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[UsedByNativeCode]
public sealed class Profiler
{

	public static bool enabled
	{
		[NativeConditional("ENABLE_PROFILER")]
		[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
		 get { } //Length: 29
	}

	[NativeConditional("ENABLE_PROFILER")]
	[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
	public static bool get_enabled() { }

	[NativeMethod(Name = "scripting_gc_get_heap_size", IsFreeFunction = True)]
	public static long GetMonoHeapSizeLong() { }

	[NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = True)]
	public static long GetMonoUsedSizeLong() { }

	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
	public static long GetRuntimeMemorySizeLong(object o) { }

	private static long GetRuntimeMemorySizeLong_Injected(IntPtr o) { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalAllocatedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalAllocatedMemoryLong() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalReservedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalReservedMemoryLong() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalUnusedReservedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalUnusedReservedMemoryLong() { }

}

