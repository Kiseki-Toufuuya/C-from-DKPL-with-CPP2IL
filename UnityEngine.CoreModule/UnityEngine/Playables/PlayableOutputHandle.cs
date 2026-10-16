namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x4

	public static PlayableOutputHandle Null
	{
		 get { } //Length: 65
	}

	private static PlayableOutputHandle() { }

	[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = True, ThrowsException = True)]
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableOutputHandle other) { }

	public static PlayableOutputHandle get_Null() { }

	public virtual int GetHashCode() { }

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	internal Type GetPlayableOutputType() { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = True, ThrowsException = True)]
	internal int GetSourceOutputPort() { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle GetSourcePlayable() { }

	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = True, ThrowsException = True)]
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, in PlayableHandle origin, INotification notification, object context) { }

	[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = True, ThrowsException = True)]
	internal void SetReferenceObject(object target) { }

	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, IntPtr target) { }

	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, in PlayableHandle target, int port) { }

	[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = True, ThrowsException = True)]
	internal void SetUserData(object target) { }

	[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = True, ThrowsException = True)]
	internal void SetWeight(float weight) { }

}

