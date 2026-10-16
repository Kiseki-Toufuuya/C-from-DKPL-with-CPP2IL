namespace System.Runtime.Serialization;

[DataContract(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
internal struct KeyValue
{
	private K key; //Field offset: 0x0
	private V value; //Field offset: 0x0

	[DataMember(IsRequired = True)]
	public K Key
	{
		 get { } //Length: 10
		 set { } //Length: 23
	}

	[DataMember(IsRequired = True)]
	public V Value
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	internal KeyValue`2(K key, V value) { }

	public K get_Key() { }

	public V get_Value() { }

	public void set_Key(K value) { }

	public void set_Value(V value) { }

}

