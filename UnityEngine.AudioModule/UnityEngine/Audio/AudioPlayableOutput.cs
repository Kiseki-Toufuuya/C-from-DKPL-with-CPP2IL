namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public static AudioPlayableOutput Null
	{
		 get { } //Length: 96
	}

	internal AudioPlayableOutput(PlayableOutputHandle handle) { }

	public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) { }

	public static AudioPlayableOutput get_Null() { }

	public override PlayableOutputHandle GetHandle() { }

	[NativeThrows]
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }

	[NativeThrows]
	private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) { }

	private static void InternalSetTarget_Injected(ref PlayableOutputHandle output, IntPtr target) { }

	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	public static PlayableOutput op_Implicit(AudioPlayableOutput output) { }

	public void SetEvaluateOnSeek(bool value) { }

	public void SetTarget(AudioSource value) { }

}

