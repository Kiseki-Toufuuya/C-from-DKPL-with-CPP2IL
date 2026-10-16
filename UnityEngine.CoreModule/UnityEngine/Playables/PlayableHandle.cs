namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x4

	public static PlayableHandle Null
	{
		 get { } //Length: 65
	}

	private static PlayableHandle() { }

	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	internal bool CheckInputBounds(int inputIndex) { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	public override bool Equals(PlayableHandle other) { }

	public virtual bool Equals(object p) { }

	public static PlayableHandle get_Null() { }

	[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetDuration() { }

	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph() { }

	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	public virtual int GetHashCode() { }

	internal Playable GetInput(int inputPort) { }

	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = True, ThrowsException = True)]
	private PlayableHandle GetInputHandle(int index) { }

	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	internal float GetInputWeight(int inputIndex) { }

	[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private float GetInputWeightFromIndex(int index) { }

	internal T GetObject() { }

	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayState GetPlayState() { }

	[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetPreviousTime() { }

	[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	private object GetScriptInstance() { }

	[FreeFunction("PlayableHandleBindings::GetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetSpeed() { }

	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetTime() { }

	[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal DirectorWrapMode GetTimeWrapMode() { }

	[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal bool IsDone() { }

	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void Pause() { }

	[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void Play() { }

	[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetDone(bool value) { }

	[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetDuration(double value) { }

	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputCount(int value) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	internal bool SetInputWeight(int inputIndex, float weight) { }

	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, in PlayableHandle input, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private void SetInputWeightFromIndex(int index, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetPropagateSetTime(bool value) { }

	[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetScriptInstance(object scriptInstance) { }

	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetSpeed(double value) { }

	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTime(double value) { }

	[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

}

