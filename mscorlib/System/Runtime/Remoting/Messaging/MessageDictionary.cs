namespace System.Runtime.Remoting.Messaging;

[DefaultMember("Item")]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private MessageDictionary _methodDictionary; //Field offset: 0x8
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0xC
		private int _posMethod; //Field offset: 0x10

		public override object Current
		{
			 get { } //Length: 73
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 370
		}

		public override object Key
		{
			 get { } //Length: 16
		}

		public override object Value
		{
			 get { } //Length: 25
		}

		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private IDictionary _internalProperties; //Field offset: 0x8
	protected IMethodMessage _message; //Field offset: 0xC
	private String[] _methodKeys; //Field offset: 0x10
	private bool _ownProperties; //Field offset: 0x14

	public override int Count
	{
		 get { } //Length: 96
	}

	internal IDictionary InternalDictionary
	{
		internal get { } //Length: 148
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object Item
	{
		 get { } //Length: 232
		 set { } //Length: 275
	}

	public override ICollection Keys
	{
		 get { } //Length: 802
	}

	public String[] MethodKeys
	{
		 set { } //Length: 27
	}

	public override object SyncRoot
	{
		 get { } //Length: 8
	}

	public override ICollection Values
	{
		 get { } //Length: 830
	}

	public MessageDictionary(IMethodMessage message) { }

	public override void Add(object key, object value) { }

	protected override IDictionary AllocInternalProperties() { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	internal IDictionary get_InternalDictionary() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public IDictionary GetInternalProperties() { }

	protected override object GetMethodProperty(string key) { }

	internal bool HasUserData() { }

	private bool IsOverridenKey(string key) { }

	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	public void set_MethodKeys(String[] value) { }

	protected override void SetMethodProperty(string key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

