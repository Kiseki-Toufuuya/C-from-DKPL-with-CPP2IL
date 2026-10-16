namespace System.Runtime.Serialization;

internal struct ScopedKnownTypes
{
	internal Dictionary<XmlQualifiedName, DataContract>[] dataContractDictionaries; //Field offset: 0x0
	private int count; //Field offset: 0x4

	internal DataContract GetDataContract(XmlQualifiedName qname) { }

	internal void Pop() { }

	internal void Push(Dictionary<XmlQualifiedName, DataContract> dataContractDictionary) { }

}

