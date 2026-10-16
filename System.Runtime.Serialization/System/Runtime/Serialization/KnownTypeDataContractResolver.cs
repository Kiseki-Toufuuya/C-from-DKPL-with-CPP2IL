namespace System.Runtime.Serialization;

internal sealed class KnownTypeDataContractResolver : DataContractResolver
{
	private XmlObjectSerializerContext context; //Field offset: 0x8

	internal KnownTypeDataContractResolver(XmlObjectSerializerContext context) { }

	public virtual Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver) { }

	public virtual bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace) { }

}

