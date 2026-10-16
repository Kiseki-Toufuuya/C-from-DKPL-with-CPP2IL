namespace System.Runtime.Serialization;

internal struct ObjectReferenceStack
{
	private const int MaximumArraySize = 16; //Field offset: 0x0
	private const int InitialArraySize = 4; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private Object[] objectArray; //Field offset: 0x4
	private Boolean[] isReferenceArray; //Field offset: 0x8
	private Dictionary<Object, Object> objectDictionary; //Field offset: 0xC

	internal int Count
	{
		internal get { } //Length: 10
	}

	internal bool Contains(object obj) { }

	internal void EnsureSetAsIsReference(object obj) { }

	internal int get_Count() { }

	internal void Pop(object obj) { }

	internal void Push(object obj) { }

}

