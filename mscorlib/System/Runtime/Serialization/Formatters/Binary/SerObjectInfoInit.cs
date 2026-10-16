namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoInit
{
	internal Hashtable seenBeforeTable; //Field offset: 0x8
	internal int objectInfoIdCount; //Field offset: 0xC
	internal SerStack oiPool; //Field offset: 0x10

	public SerObjectInfoInit() { }

}

