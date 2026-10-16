namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JProperty : JContainer
{
	[DefaultMember("Item")]
	[Nullable(0)]
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private JToken <>2__current; //Field offset: 0xC
			[Nullable(0)]
			public JPropertyList <>4__this; //Field offset: 0x10

			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
			public <GetEnumerator>d__1(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(2)]
		internal JToken _token; //Field offset: 0x8

		public override int Count
		{
			 get { } //Length: 16
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override JToken Item
		{
			 get { } //Length: 65
			 set { } //Length: 81
		}

		public JPropertyList() { }

		public override void Add(JToken item) { }

		public override void Clear() { }

		public override bool Contains(JToken item) { }

		public override void CopyTo(JToken[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override JToken get_Item(int index) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
		public override IEnumerator<JToken> GetEnumerator() { }

		public override int IndexOf(JToken item) { }

		public override void Insert(int index, JToken item) { }

		public override bool Remove(JToken item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, JToken value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly JPropertyList _content; //Field offset: 0x28
	private readonly string _name; //Field offset: 0x2C

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 11
	}

	public string Name
	{
		[DebuggerStepThrough]
		 get { } //Length: 11
	}

	public virtual JTokenType Type
	{
		[DebuggerStepThrough]
		 get { } //Length: 6
	}

	public JToken Value
	{
		[DebuggerStepThrough]
		 get { } //Length: 23
		 set { } //Length: 106
	}

	public JProperty(string name, object content) { }

	internal JProperty(JProperty other, JsonCloneSettings settings) { }

	internal JProperty(string name) { }

	internal virtual void ClearItems() { }

	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[NullableContext(2)]
	internal virtual bool ContainsItem(JToken item) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	public string get_Name() { }

	[DebuggerStepThrough]
	public virtual JTokenType get_Type() { }

	[DebuggerStepThrough]
	public JToken get_Value() { }

	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

	[NullableContext(2)]
	internal virtual bool RemoveItem(JToken item) { }

	internal virtual void RemoveItemAt(int index) { }

	public void set_Value(JToken value) { }

	[NullableContext(2)]
	internal virtual void SetItem(int index, JToken item) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

