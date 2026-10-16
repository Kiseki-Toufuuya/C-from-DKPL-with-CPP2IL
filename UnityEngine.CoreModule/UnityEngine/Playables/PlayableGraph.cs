namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[UsedByNativeCode]
public struct PlayableGraph
{
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x4

	public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort) { }

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle source, int sourceOutputPort, in PlayableHandle destination, int destinationInputPort) { }

	public static PlayableGraph Create(string name) { }

	private static void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret) { }

	[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle CreatePlayableHandle() { }

	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, ref ManagedSpanWrapper name, out PlayableOutputHandle handle) { }

	[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = True, ThrowsException = True)]
	public void Destroy() { }

	public void Disconnect(U input, int inputPort) { }

	[FreeFunction("PlayableGraphBindings::DisconnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private void DisconnectInternal(PlayableHandle playable, int inputPort) { }

	private static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle playable, int inputPort) { }

	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = True, ThrowsException = True)]
	public void Evaluate(float deltaTime) { }

	public void Evaluate() { }

	[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = True, ThrowsException = True)]
	internal FrameRate GetFrameRate() { }

	private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret) { }

	public PlayableOutput GetOutput(int index) { }

	[FreeFunction("PlayableGraphBindings::GetOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool GetOutputInternal(int index, out PlayableOutputHandle handle) { }

	[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetPlayableCount() { }

	[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = True, ThrowsException = True)]
	public IExposedPropertyTable GetResolver() { }

	public Playable GetRootPlayable(int index) { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetRootPlayableCount() { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle GetRootPlayableInternal(int index) { }

	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) { }

	[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = True, ThrowsException = True)]
	internal bool IsMatchFrameRateEnabled() { }

	[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = True, ThrowsException = True)]
	public bool IsPlaying() { }

	public bool IsValid() { }

	[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	public void Play() { }

	[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = True, ThrowsException = True)]
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = True, ThrowsException = True)]
	internal void SynchronizeEvaluation(PlayableGraph playable) { }

	private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, in PlayableGraph playable) { }

}

