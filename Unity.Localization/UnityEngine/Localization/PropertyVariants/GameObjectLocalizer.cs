namespace UnityEngine.Localization.PropertyVariants;

[DisallowMultipleComponent]
[ExecuteAlways]
public class GameObjectLocalizer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Start>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameObjectLocalizer <>4__this; //Field offset: 0x10
		private AsyncOperationHandle<Locale> <localeOp>5__2; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Start>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeReference]
	private List<TrackedObject> m_TrackedObjects; //Field offset: 0x10
	private Locale m_CurrentLocale; //Field offset: 0x14
	private ChangeHandler m_LocalizedStringChanged; //Field offset: 0x18
	private bool m_IgnoreChange; //Field offset: 0x1C
	[CompilerGenerated]
	private AsyncOperationHandle <CurrentOperation>k__BackingField; //Field offset: 0x20

	internal AsyncOperationHandle CurrentOperation
	{
		[CompilerGenerated]
		internal get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 38
	}

	public List<TrackedObject> TrackedObjects
	{
		 get { } //Length: 11
	}

	public GameObjectLocalizer() { }

	[CompilerGenerated]
	private void <RegisterChanges>b__18_0(string _) { }

	public AsyncOperationHandle ApplyLocaleVariant(Locale locale) { }

	public AsyncOperationHandle ApplyLocaleVariant(Locale locale, Locale fallback) { }

	[CompilerGenerated]
	internal AsyncOperationHandle get_CurrentOperation() { }

	public List<TrackedObject> get_TrackedObjects() { }

	public T GetTrackedObject(object target, bool create = true) { }

	public TrackedObject GetTrackedObject(object target) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RegisterChanges() { }

	private void RequestUpdate() { }

	private void SelectedLocaleChanged(Locale locale) { }

	[CompilerGenerated]
	private void set_CurrentOperation(AsyncOperationHandle value) { }

	[IteratorStateMachine(typeof(<Start>d__10))]
	private IEnumerator Start() { }

	private void UnregisterChanges() { }

}

