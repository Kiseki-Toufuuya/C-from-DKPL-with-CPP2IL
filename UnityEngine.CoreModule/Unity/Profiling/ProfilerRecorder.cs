namespace Unity.Profiling;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ProfilerRecorderDebugView))]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
[UsedByNativeCode]
public struct ProfilerRecorder : IDisposable
{
	public enum ControlOptions
	{
		Start = 0,
		Stop = 1,
		Reset = 2,
		Release = 4,
		SetFilterToCurrentThread = 5,
		SetToCollectFromAllThreads = 6,
	}

	internal const ProfilerRecorderOptions SharedRecorder = 128; //Field offset: 0x0
	internal ulong handle; //Field offset: 0x0

	public long LastValue
	{
		 get { } //Length: 132
	}

	public bool Valid
	{
		 get { } //Length: 84
	}

	public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	[BurstDiscard]
	private void CheckInitializedAndThrow() { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static void Control(ProfilerRecorder handle, ControlOptions options) { }

	private static void Control_Injected(in ProfilerRecorder handle, ControlOptions options) { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) { }

	private static void Create_Injected(in ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) { }

	public override void Dispose() { }

	public long get_LastValue() { }

	public bool get_Valid() { }

	[NativeMethod(IsThreadSafe = True)]
	private static long GetLastValue(ProfilerRecorder handle) { }

	private static long GetLastValue_Injected(in ProfilerRecorder handle) { }

	[NativeMethod(IsThreadSafe = True)]
	private static bool GetValid(ProfilerRecorder handle) { }

	private static bool GetValid_Injected(in ProfilerRecorder handle) { }

	public void Start() { }

	public void Stop() { }

}

