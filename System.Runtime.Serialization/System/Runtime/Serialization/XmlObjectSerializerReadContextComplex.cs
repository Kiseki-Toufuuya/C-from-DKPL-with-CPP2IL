namespace System.Runtime.Serialization;

internal class XmlObjectSerializerReadContextComplex : XmlObjectSerializerReadContext
{
	private sealed class TopLevelAssemblyTypeResolver
	{
		private Assembly topLevelAssembly; //Field offset: 0x8

		public TopLevelAssemblyTypeResolver(Assembly topLevelAssembly) { }

		public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

	}

	private class XmlObjectDataContractTypeInfo
	{
		private Assembly assembly; //Field offset: 0x8
		private Type type; //Field offset: 0xC

		public Assembly Assembly
		{
			 get { } //Length: 11
		}

		public Type Type
		{
			 get { } //Length: 11
		}

		public XmlObjectDataContractTypeInfo(Assembly assembly, Type type) { }

		public Assembly get_Assembly() { }

		public Type get_Type() { }

	}

	private class XmlObjectDataContractTypeKey
	{
		private string assemblyName; //Field offset: 0x8
		private string typeName; //Field offset: 0xC

		public XmlObjectDataContractTypeKey(string assemblyName, string typeName) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private static Hashtable dataContractTypeCache; //Field offset: 0x0
	private bool preserveObjectReferences; //Field offset: 0x64
	protected IDataContractSurrogate dataContractSurrogate; //Field offset: 0x68
	private SerializationMode mode; //Field offset: 0x6C
	private SerializationBinder binder; //Field offset: 0x70
	private ISurrogateSelector surrogateSelector; //Field offset: 0x74
	private FormatterAssemblyStyle assemblyFormat; //Field offset: 0x78
	private Hashtable surrogateDataContracts; //Field offset: 0x7C

	internal virtual SerializationMode Mode
	{
		internal get { } //Length: 11
	}

	private static XmlObjectSerializerReadContextComplex() { }

	internal XmlObjectSerializerReadContextComplex(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject) { }

	internal XmlObjectSerializerReadContextComplex(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	internal XmlObjectSerializerReadContextComplex(NetDataContractSerializer serializer) { }

	internal virtual void CheckIfTypeSerializable(Type memberType, bool isMemberTypeSerializable) { }

	private bool CheckIfTypeSerializableForSharedTypeMode(Type memberType) { }

	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destinationAssembly, Type resolvedType) { }

	internal virtual SerializationMode get_Mode() { }

	internal virtual int GetArraySize() { }

	internal virtual DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle) { }

	internal virtual DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type) { }

	internal virtual Type GetSurrogatedType(Type type) { }

	public virtual object InternalDeserialize(XmlReaderDelegator xmlReader, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle, string name, string ns) { }

	internal virtual object InternalDeserialize(XmlReaderDelegator xmlReader, Type declaredType, string name, string ns) { }

	internal virtual object InternalDeserialize(XmlReaderDelegator xmlReader, Type declaredType, DataContract dataContract, string name, string ns) { }

	private object InternalDeserializeInSharedTypeMode(XmlReaderDelegator xmlReader, int declaredTypeID, Type declaredType, string name, string ns) { }

	private object InternalDeserializeWithSurrogate(XmlReaderDelegator xmlReader, Type declaredType, DataContract surrogateDataContract, string name, string ns) { }

	protected virtual DataContract ResolveDataContractFromTypeName() { }

	private DataContract ResolveDataContractInSharedTypeMode(string assemblyName, string typeName, out Assembly assembly, out Type type) { }

	private Type ResolveDataContractTypeInSharedTypeMode(string assemblyName, string typeName, out Assembly assembly) { }

	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	private static Assembly ResolveSimpleAssemblyName(string assemblyName) { }

}

