namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainString
{
	internal int objectId; //Field offset: 0x8
	internal int value; //Field offset: 0xC

	internal BinaryCrossAppDomainString() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

}

