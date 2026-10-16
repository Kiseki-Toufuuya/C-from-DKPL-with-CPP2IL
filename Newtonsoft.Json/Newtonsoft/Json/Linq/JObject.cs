namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JObject : JContainer, IDictionary<String, JToken>, ICollection<KeyValuePair`2<String, JToken>>, IEnumerable<KeyValuePair`2<String, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__64 : IEnumerator<KeyValuePair`2<String, JToken>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		private KeyValuePair<String, JToken> <>2__current; //Field offset: 0xC
		[Nullable(0)]
		public JObject <>4__this; //Field offset: 0x14
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x18

		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current
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
		public <GetEnumerator>d__64(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	private class JObjectDynamicProxy : DynamicProxy<JObject>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			[Nullable(0)]
			public static readonly <>c <>9; //Field offset: 0x0
			[Nullable(0)]
			public static Func<JProperty, String> <>9__2_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			[NullableContext(0)]
			internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

		}


		public JObjectDynamicProxy() { }

		public virtual IEnumerable<String> GetDynamicMemberNames(JObject instance) { }

		public virtual bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

		public virtual bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	}

	private readonly JPropertyKeyedCollection _properties; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x2C
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangingEventHandler PropertyChanging; //Field offset: 0x30

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 11
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 201
		 set { } //Length: 201
	}

	[Nullable(2)]
	public override JToken Item
	{
		 get { } //Length: 91
		 set { } //Length: 254
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
	{
		private get { } //Length: 84
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
	{
		private get { } //Length: 47
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JObject() { }

	public JObject(JObject other) { }

	internal JObject(JObject other, JsonCloneSettings settings) { }

	public JObject(Object[] content) { }

	public JObject(object content) { }

	public override void Add(string propertyName, JToken value) { }

	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	public override bool ContainsKey(string propertyName) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public override JToken get_Item(string propertyName) { }

	public virtual JToken get_Item(object key) { }

	public virtual JTokenType get_Type() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__64))]
	public override IEnumerator<KeyValuePair`2<String, JToken>> GetEnumerator() { }

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	internal void InternalPropertyChanged(JProperty childProperty) { }

	internal void InternalPropertyChanging(JProperty childProperty) { }

	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	protected override void OnPropertyChanged(string propertyName) { }

	protected override void OnPropertyChanging(string propertyName) { }

	public static JObject Parse(string json, JsonLoadSettings settings) { }

	public static JObject Parse(string json) { }

	public IEnumerable<JProperty> Properties() { }

	public JProperty Property(string name, StringComparison comparison) { }

	public override bool Remove(string propertyName) { }

	public virtual void set_Item(object key, JToken value) { }

	public override void set_Item(string propertyName, JToken value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<String, JToken> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<String, JToken> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<String, JToken>[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<String, JToken> item) { }

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	[NullableContext(2)]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	public override bool TryGetValue(string propertyName, out JToken value) { }

	internal virtual void ValidateToken(JToken o, JToken existing) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

