namespace System.Runtime.Serialization;

public abstract class DataContractResolver
{

	protected DataContractResolver() { }

	public abstract Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver) { }

	public abstract bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace) { }

}

