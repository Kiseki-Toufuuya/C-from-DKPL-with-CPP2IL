namespace UnityEngine.Profiling;

[UsedByNativeCode]
public sealed class Recorder
{
	private const ProfilerRecorderOptions s_RecorderDefaultOptions = 153; //Field offset: 0x0
	internal static Recorder s_InvalidRecorder; //Field offset: 0x0
	private ProfilerRecorder m_RecorderCPU; //Field offset: 0x8
	private ProfilerRecorder m_RecorderGPU; //Field offset: 0x10

	public long elapsedNanoseconds
	{
		 get { } //Length: 66
	}

	public bool enabled
	{
		 set { } //Length: 99
	}

	private static Recorder() { }

	internal Recorder() { }

	internal Recorder(ProfilerRecorderHandle handle) { }

	protected virtual void Finalize() { }

	public static Recorder Get(string samplerName) { }

	public long get_elapsedNanoseconds() { }

	public void set_enabled(bool value) { }

	private void SetEnabled(bool state) { }

}

