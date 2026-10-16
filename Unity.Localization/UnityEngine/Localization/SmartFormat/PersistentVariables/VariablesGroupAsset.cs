namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[CreateAssetMenu(menuName = "Localization/Variables Group")]
[DefaultMember("Item")]
public class VariablesGroupAsset : ScriptableObject, IVariableGroup, IVariable, IDictionary<String, IVariable>, ICollection<KeyValuePair`2<String, IVariable>>, IEnumerable<KeyValuePair`2<String, IVariable>>, IEnumerable, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<VariableNameValuePair, IVariable> <>9__7_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal IVariable <get_Values>b__7_0(VariableNameValuePair s) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public VariablesGroupAsset <>4__this; //Field offset: 0x10
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
		public <GetEnumerator>d__23(int <>1__state) { }

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
	private sealed class <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22 : IEnumerator<KeyValuePair`2<String, IVariable>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private KeyValuePair<String, IVariable> <>2__current; //Field offset: 0xC
		public VariablesGroupAsset <>4__this; //Field offset: 0x14
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
		public <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22(int <>1__state) { }

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

	[SerializeField]
	internal List<VariableNameValuePair> m_Variables; //Field offset: 0xC
	private Dictionary<String, VariableNameValuePair> m_VariableLookup; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 64
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

	public override ICollection<IVariable> Values
	{
		 get { } //Length: 277
	}

	public VariablesGroupAsset() { }

	public override void Add(KeyValuePair<String, IVariable> item) { }

	public override void Add(string name, IVariable variable) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<String, IVariable> item) { }

	public override bool ContainsKey(string name) { }

	[Obsolete("Please use ContainsKey instead.", False)]
	public bool ContainsName(string name) { }

	public override void CopyTo(KeyValuePair<String, IVariable>[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override IVariable get_Item(string name) { }

	public override ICollection<String> get_Keys() { }

	public override ICollection<IVariable> get_Values() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__23))]
	public override IEnumerator GetEnumerator() { }

	public override object GetSourceValue(ISelectorInfo _) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override bool Remove(KeyValuePair<String, IVariable> item) { }

	public override bool Remove(string name) { }

	public override void set_Item(string name, IVariable value) { }

	[IteratorStateMachine(typeof(<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22))]
	private override IEnumerator<KeyValuePair`2<String, IVariable>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.GetEnumerator() { }

	public override bool TryGetValue(string name, out IVariable value) { }

}

