namespace UnityEngine.Audio;

[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType::DoubleColon (2))]
internal static class AudioPlayableGraphExtensions
{

	[NativeThrows]
	internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }

	private static bool InternalCreateAudioOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle) { }

}

