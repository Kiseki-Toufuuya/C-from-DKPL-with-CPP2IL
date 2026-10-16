namespace UnityEngine.Localization;

[DefaultMember("Item")]
[UxmlObject]
public class LocalizedString : LocalizedReference, IVariableGroup, IDictionary<String, IVariable>, ICollection<KeyValuePair`2<String, IVariable>>, IEnumerable<KeyValuePair`2<String, IVariable>>, IEnumerable, IVariableValueChanged, IVariable, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<VariableNameValuePair, IVariable> <>9__43_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal IVariable <get_Values>b__43_0(VariableNameValuePair s) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__58 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LocalizedString <>4__this; //Field offset: 0x10
		private Enumerator<String, VariableNameValuePair> <>7__wrap1; //Field offset: 0x14

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
		public <GetEnumerator>d__58(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private sealed class <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__57 : IEnumerator<KeyValuePair`2<String, IVariable>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private KeyValuePair<String, IVariable> <>2__current; //Field offset: 0xC
		public LocalizedString <>4__this; //Field offset: 0x14
		private Enumerator<String, VariableNameValuePair> <>7__wrap1; //Field offset: 0x18

		private override KeyValuePair<String, IVariable> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 14
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__57(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<String, IVariable> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct ChainedLocalVariablesGroup : IVariableGroup
	{
		[CompilerGenerated]
		private IVariableGroup <ParentGroup>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private IVariableGroup <Group>k__BackingField; //Field offset: 0x4

		private IVariableGroup Group
		{
			[CompilerGenerated]
			[IsReadOnly]
			private get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 27
		}

		private IVariableGroup ParentGroup
		{
			[CompilerGenerated]
			[IsReadOnly]
			private get { } //Length: 10
			[CompilerGenerated]
			private set { } //Length: 23
		}

		public ChainedLocalVariablesGroup(IVariableGroup group, IVariableGroup parent) { }

		[CompilerGenerated]
		[IsReadOnly]
		private IVariableGroup get_Group() { }

		[CompilerGenerated]
		[IsReadOnly]
		private IVariableGroup get_ParentGroup() { }

		[CompilerGenerated]
		private void set_Group(IVariableGroup value) { }

		[CompilerGenerated]
		private void set_ParentGroup(IVariableGroup value) { }

		public override bool TryGetValue(string key, out IVariable value) { }

	}

	internal sealed class ChangeHandler : MulticastDelegate
	{

		public ChangeHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string value) { }

	}

	private struct StringTableEntryVariable : IVariableGroup
	{
		private readonly string m_Localized; //Field offset: 0x0
		private readonly StringTableEntry m_StringTableEntry; //Field offset: 0x4

		public StringTableEntryVariable(string localized, StringTableEntry entry) { }

		public virtual string ToString() { }

		public override bool TryGetValue(string key, out IVariable value) { }

	}

	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData
	{
		[SerializeReference]
		[UxmlObjectReference("variables")]
		private List<UxmlSerializedData> LocalVariablesUXML; //Field offset: 0x58
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags LocalVariablesUXML_UxmlAttributeFlags; //Field offset: 0x5C

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		public virtual void Deserialize(object obj) { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}

	[SerializeField]
	private List<VariableNameValuePair> m_LocalVariables; //Field offset: 0x58
	private CallbackArray<ChangeHandler> m_ChangeHandler; //Field offset: 0x5C
	private string m_CurrentStringChangedValue; //Field offset: 0x74
	private readonly Dictionary<String, VariableNameValuePair> m_VariableLookup; //Field offset: 0x78
	private readonly List<IVariableValueChanged> m_UsedVariables; //Field offset: 0x7C
	private Action<IVariable> m_OnVariableChanged; //Field offset: 0x80
	private Action<Locale> m_SelectedLocaleChanged; //Field offset: 0x84
	private Action<AsyncOperationHandle`1<TableEntryResult<StringTable, StringTableEntry>>> m_AutomaticLoadingCompleted; //Field offset: 0x88
	private Action<AsyncOperationHandle`1<TableEntryResult<StringTable, StringTableEntry>>> m_CompletedSourceValue; //Field offset: 0x8C
	private bool m_WaitingForVariablesEndUpdate; //Field offset: 0x90
	[CompilerGenerated]
	private Action<IVariable> ValueChanged; //Field offset: 0x94
	[CompilerGenerated]
	private IList<Object> <Arguments>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> <CurrentLoadingOperationHandle>k__BackingField; //Field offset: 0x9C
	private List<LocalVariable> m_UxmlLocalVariables; //Field offset: 0xA8

	public event ChangeHandler StringChanged
	{
		 add { } //Length: 403
		 remove { } //Length: 163
	}

	public override event Action<IVariable> ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public IList<Object> Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public override int Count
	{
		 get { } //Length: 64
	}

	public internal AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> CurrentLoadingOperationHandle
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		internal set { } //Length: 47
	}

	internal virtual bool ForceSynchronous
	{
		internal get { } //Length: 115
	}

	public bool HasChangeHandler
	{
		 get { } //Length: 44
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override IVariable Item
	{
		 get { } //Length: 74
		 set { } //Length: 16
	}

	public override ICollection<String> Keys
	{
		 get { } //Length: 64
	}

	[UxmlObjectReference("variables")]
	internal List<LocalVariable> LocalVariablesUXML
	{
		internal get { } //Length: 14
		internal set { } //Length: 426
	}

	public override ICollection<IVariable> Values
	{
		 get { } //Length: 277
	}

	public LocalizedString(TableReference tableReference, TableEntryReference entryReference) { }

	public LocalizedString() { }

	public override void Add(KeyValuePair<String, IVariable> item) { }

	public override void Add(string name, IVariable variable) { }

	public void add_StringChanged(ChangeHandler value) { }

	[CompilerGenerated]
	public override void add_ValueChanged(Action<IVariable> value) { }

	private void AutomaticLoadingCompleted(AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> loadOperation) { }

	protected virtual void Cleanup() { }

	public override void Clear() { }

	private void ClearLoadingOperation() { }

	private void CompletedSourceValue(AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> _) { }

	public override bool Contains(KeyValuePair<String, IVariable> item) { }

	public override bool ContainsKey(string name) { }

	public override void CopyTo(KeyValuePair<String, IVariable>[] array, int arrayIndex) { }

	protected virtual void Finalize() { }

	protected private virtual void ForceUpdate() { }

	[CompilerGenerated]
	public IList<Object> get_Arguments() { }

	public override int get_Count() { }

	[CompilerGenerated]
	public AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> get_CurrentLoadingOperationHandle() { }

	internal virtual bool get_ForceSynchronous() { }

	public bool get_HasChangeHandler() { }

	public override bool get_IsReadOnly() { }

	public override IVariable get_Item(string name) { }

	public override ICollection<String> get_Keys() { }

	internal List<LocalVariable> get_LocalVariablesUXML() { }

	public override ICollection<IVariable> get_Values() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__58))]
	public override IEnumerator GetEnumerator() { }

	public string GetLocalizedString(IList<Object> arguments) { }

	public string GetLocalizedString(Object[] arguments) { }

	public string GetLocalizedString() { }

	public AsyncOperationHandle<String> GetLocalizedStringAsync(IList<Object> arguments) { }

	public AsyncOperationHandle<String> GetLocalizedStringAsync(Object[] arguments) { }

	public AsyncOperationHandle<String> GetLocalizedStringAsync() { }

	public override object GetSourceValue(ISelectorInfo selector) { }

	private void HandleLocaleChange(Locale locale) { }

	protected virtual void Initialize() { }

	private void InvokeChangeHandler(string value) { }

	public virtual void OnAfterDeserialize() { }

	private void OnVariableChanged(IVariable globalVariable) { }

	private void OnVariablesSourceUpdateCompleted() { }

	public bool RefreshString() { }

	public override bool Remove(KeyValuePair<String, IVariable> item) { }

	public override bool Remove(string name) { }

	public void remove_StringChanged(ChangeHandler value) { }

	[CompilerGenerated]
	public override void remove_ValueChanged(Action<IVariable> value) { }

	protected virtual void Reset() { }

	[CompilerGenerated]
	public void set_Arguments(IList<Object> value) { }

	[CompilerGenerated]
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> value) { }

	public override void set_Item(string name, IVariable value) { }

	internal void set_LocalVariablesUXML(List<LocalVariable> value) { }

	[IteratorStateMachine(typeof(<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__57))]
	private override IEnumerator<KeyValuePair`2<String, IVariable>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.GetEnumerator() { }

	private override void System.IDisposable.Dispose() { }

	public override bool TryGetValue(string name, out IVariable value) { }

	protected virtual BindingResult Update(in BindingContext context) { }

	private void UpdateBindingValue(string _) { }

	private void UpdateVariableListeners(List<IVariableValueChanged> variables) { }

}

