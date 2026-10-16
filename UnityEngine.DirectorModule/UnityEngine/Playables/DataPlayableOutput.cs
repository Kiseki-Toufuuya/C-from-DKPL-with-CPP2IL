namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
internal struct DataPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	internal DataPlayableOutput(PlayableOutputHandle handle) { }

	public override PlayableOutputHandle GetHandle() { }

	[RequiredByNativeCode]
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }

}

