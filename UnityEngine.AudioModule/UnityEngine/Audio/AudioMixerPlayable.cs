namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	internal AudioMixerPlayable(PlayableHandle handle) { }

	public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false) { }

	[NativeThrows]
	private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) { }

	public override bool Equals(AudioMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AudioMixerPlayable playable) { }

}

