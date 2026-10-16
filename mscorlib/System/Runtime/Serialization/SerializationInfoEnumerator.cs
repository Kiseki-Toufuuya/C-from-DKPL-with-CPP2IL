namespace System.Runtime.Serialization;

public sealed class SerializationInfoEnumerator : IEnumerator
{
	private readonly String[] _members; //Field offset: 0x8
	private readonly Object[] _data; //Field offset: 0xC
	private readonly Type[] _types; //Field offset: 0x10
	private readonly int _numItems; //Field offset: 0x14
	private int _currItem; //Field offset: 0x18
	private bool _current; //Field offset: 0x1C

	public SerializationEntry Current
	{
		 get { } //Length: 237
	}

	public string Name
	{
		 get { } //Length: 108
	}

	public Type ObjectType
	{
		 get { } //Length: 108
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 86
	}

	public object Value
	{
		 get { } //Length: 108
	}

	internal SerializationInfoEnumerator(String[] members, Object[] info, Type[] types, int numItems) { }

	public SerializationEntry get_Current() { }

	public string get_Name() { }

	public Type get_ObjectType() { }

	public object get_Value() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

