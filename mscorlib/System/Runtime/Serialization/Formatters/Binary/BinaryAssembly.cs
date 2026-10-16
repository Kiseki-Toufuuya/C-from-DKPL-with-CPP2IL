namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryAssembly
{
	internal int assemId; //Field offset: 0x8
	internal string assemblyString; //Field offset: 0xC

	internal BinaryAssembly() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int assemId, string assemblyString) { }

	public override void Write(__BinaryWriter sout) { }

}

