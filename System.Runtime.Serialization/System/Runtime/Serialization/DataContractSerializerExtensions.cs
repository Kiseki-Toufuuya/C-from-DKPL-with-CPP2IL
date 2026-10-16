namespace System.Runtime.Serialization;

[Extension]
public static class DataContractSerializerExtensions
{
	private class SurrogateProviderAdapter : IDataContractSurrogate
	{
		private ISerializationSurrogateProvider _provider; //Field offset: 0x8

		public ISerializationSurrogateProvider Provider
		{
			 get { } //Length: 11
		}

		public SurrogateProviderAdapter(ISerializationSurrogateProvider provider) { }

		public ISerializationSurrogateProvider get_Provider() { }

		public override object GetCustomDataToExport(Type clrType, Type dataContractType) { }

		public override object GetCustomDataToExport(MemberInfo memberInfo, Type dataContractType) { }

		public override Type GetDataContractType(Type type) { }

		public override object GetDeserializedObject(object obj, Type targetType) { }

		public override void GetKnownCustomDataTypes(Collection<Type> customDataTypes) { }

		public override object GetObjectToSerialize(object obj, Type targetType) { }

		public override Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData) { }

		public override CodeTypeDeclaration ProcessImportedType(CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit) { }

	}


	[Extension]
	public static ISerializationSurrogateProvider GetSerializationSurrogateProvider(DataContractSerializer serializer) { }

	[Extension]
	public static void SetSerializationSurrogateProvider(DataContractSerializer serializer, ISerializationSurrogateProvider provider) { }

}

