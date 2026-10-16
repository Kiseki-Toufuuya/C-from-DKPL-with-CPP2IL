namespace System.Runtime.Serialization;

internal sealed class ValueTypeFixupInfo
{
	private readonly long _containerID; //Field offset: 0x8
	private readonly FieldInfo _parentField; //Field offset: 0x10
	private readonly Int32[] _parentIndex; //Field offset: 0x14

	public long ContainerID
	{
		 get { } //Length: 14
	}

	public FieldInfo ParentField
	{
		 get { } //Length: 11
	}

	public Int32[] ParentIndex
	{
		 get { } //Length: 11
	}

	public ValueTypeFixupInfo(long containerID, FieldInfo member, Int32[] parentIndex) { }

	public long get_ContainerID() { }

	public FieldInfo get_ParentField() { }

	public Int32[] get_ParentIndex() { }

}

