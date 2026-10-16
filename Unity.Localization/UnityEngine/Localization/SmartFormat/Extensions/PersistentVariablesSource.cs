namespace UnityEngine.Localization.SmartFormat.Extensions;

[DefaultMember("Item")]
public class PersistentVariablesSource : ISource, IDictionary<String, VariablesGroupAsset>, ICollection<KeyValuePair`2<String, VariablesGroupAsset>>, IEnumerable<KeyValuePair`2<String, VariablesGroupAsset>>, IEnumerable, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NameValuePair, VariablesGroupAsset> <>9__14_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal VariablesGroupAsset <get_Values>b__14_0(NameValuePair k) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PersistentVariablesSource <>4__this; //Field offset: 0x10
		private Enumerator<String, NameValuePair> <>7__wrap1; //Field offset: 0x14

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
		public <GetEnumerator>d__35(int <>1__state) { }

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
	private sealed class <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34 : IEnumerator<KeyValuePair`2<String, VariablesGroupAsset>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private KeyValuePair<String, VariablesGroupAsset> <>2__current; //Field offset: 0xC
		public PersistentVariablesSource <>4__this; //Field offset: 0x14
		private Enumerator<String, NameValuePair> <>7__wrap1; //Field offset: 0x18

		private override KeyValuePair<String, VariablesGroupAsset> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset>>.Current
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
		public <System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<String, VariablesGroupAsset> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class NameValuePair
	{
		public string name; //Field offset: 0x8
		[SerializeReference]
		public VariablesGroupAsset group; //Field offset: 0xC

		public NameValuePair() { }

	}

	internal struct ScopedUpdate : IDisposable
	{

		public override void Dispose() { }

	}

	internal static int s_IsUpdating; //Field offset: 0x0
	[CompilerGenerated]
	private static Action EndUpdate; //Field offset: 0x4
	[SerializeField]
	private List<NameValuePair> m_Groups; //Field offset: 0x8
	private Dictionary<String, NameValuePair> m_GroupLookup; //Field offset: 0xC

	public static event Action EndUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 139
		[CompilerGenerated]
		 remove { } //Length: 139
	}

	public override int Count
	{
		 get { } //Length: 52
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public static bool IsUpdating
	{
		 get { } //Length: 44
	}

	public override VariablesGroupAsset Item
	{
		 get { } //Length: 74
		 set { } //Length: 16
	}

	public override ICollection<String> Keys
	{
		 get { } //Length: 64
	}

	public override ICollection<VariablesGroupAsset> Values
	{
		 get { } //Length: 277
	}

	public PersistentVariablesSource(SmartFormatter formatter) { }

	public override void Add(KeyValuePair<String, VariablesGroupAsset> item) { }

	public override void Add(string name, VariablesGroupAsset group) { }

	[CompilerGenerated]
	public static void add_EndUpdate(Action value) { }

	public static void BeginUpdating() { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<String, VariablesGroupAsset> item) { }

	public override bool ContainsKey(string name) { }

	public override void CopyTo(KeyValuePair<String, VariablesGroupAsset>[] array, int arrayIndex) { }

	public static void EndUpdating() { }

	private static bool EvaluateLocalGroup(ISelectorInfo selectorInfo, IVariableGroup variablleGroup) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public static bool get_IsUpdating() { }

	public override VariablesGroupAsset get_Item(string name) { }

	public override ICollection<String> get_Keys() { }

	public override ICollection<VariablesGroupAsset> get_Values() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	public override IEnumerator GetEnumerator() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override bool Remove(string name) { }

	public override bool Remove(KeyValuePair<String, VariablesGroupAsset> item) { }

	[CompilerGenerated]
	public static void remove_EndUpdate(Action value) { }

	public override void set_Item(string name, VariablesGroupAsset value) { }

	[IteratorStateMachine(typeof(<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34))]
	private override IEnumerator<KeyValuePair`2<String, VariablesGroupAsset>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset>>.GetEnumerator() { }

	public override bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

	public override bool TryGetValue(string name, out VariablesGroupAsset value) { }

	public static IDisposable UpdateScope() { }

}

