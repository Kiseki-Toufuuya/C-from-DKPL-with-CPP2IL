namespace System.Xml.Serialization;

internal abstract class SerializationSource
{
	private Type[] includedTypes; //Field offset: 0x8
	private string namspace; //Field offset: 0xC
	private bool canBeGenerated; //Field offset: 0x10

	public SerializationSource(string namspace, Type[] includedTypes) { }

	protected bool BaseEquals(SerializationSource other) { }

}

