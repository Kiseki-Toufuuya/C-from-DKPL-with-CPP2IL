namespace UnityEngine.Audio;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	internal AudioClipPlayable(PlayableHandle handle) { }

	public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) { }

	public override bool Equals(AudioClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

	[NativeThrows]
	private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) { }

	private static bool InternalCreateAudioClipPlayable_Injected(ref PlayableGraph graph, IntPtr clip, bool looping, ref PlayableHandle handle) { }

	public static AudioClipPlayable op_Explicit(Playable playable) { }

	public static Playable op_Implicit(AudioClipPlayable playable) { }

	public void Seek(double startTime, double startDelay, double duration) { }

	[NativeThrows]
	private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) { }

	internal void SetSpatialBlend(float value) { }

	[NativeThrows]
	private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) { }

	[NativeThrows]
	private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) { }

	internal void SetStereoPan(float value) { }

	[NativeThrows]
	private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) { }

	internal void SetVolume(float value) { }

	[NativeThrows]
	private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) { }

}

