namespace System.Runtime.Serialization;

internal class DataContractPairKey
{
	private object object1; //Field offset: 0x8
	private object object2; //Field offset: 0xC

	public DataContractPairKey(object object1, object object2) { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

}

