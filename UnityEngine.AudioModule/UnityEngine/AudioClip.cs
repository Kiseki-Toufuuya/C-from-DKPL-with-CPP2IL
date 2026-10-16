namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioClip : AudioResource
{
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		public PCMReaderCallback(object object, IntPtr method) { }

		public override void Invoke(Single[] data) { }

	}

	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		public PCMSetPositionCallback(object object, IntPtr method) { }

		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x10

	public int frequency
	{
		 get { } //Length: 98
	}

	[NativeProperty("LengthSec")]
	public float length
	{
		 get { } //Length: 102
	}

	[NativeProperty("SampleCount")]
	public int samples
	{
		 get { } //Length: 98
	}

	private AudioClip() { }

	public int get_frequency() { }

	private static int get_frequency_Injected(IntPtr _unity_self) { }

	public float get_length() { }

	private static float get_length_Injected(IntPtr _unity_self) { }

	public int get_samples() { }

	private static int get_samples_Injected(IntPtr _unity_self) { }

	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

