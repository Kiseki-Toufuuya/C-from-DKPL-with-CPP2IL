namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainAssembly
{
	internal int assemId; //Field offset: 0x8
	internal int assemblyIndex; //Field offset: 0xC

	internal BinaryCrossAppDomainAssembly() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

}

