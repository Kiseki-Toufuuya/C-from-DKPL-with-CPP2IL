namespace System.Runtime.Serialization;

public interface IDataContractSurrogate
{

	public object GetCustomDataToExport(MemberInfo memberInfo, Type dataContractType) { }

	public object GetCustomDataToExport(Type clrType, Type dataContractType) { }

	public Type GetDataContractType(Type type) { }

	public object GetDeserializedObject(object obj, Type targetType) { }

	public void GetKnownCustomDataTypes(Collection<Type> customDataTypes) { }

	public object GetObjectToSerialize(object obj, Type targetType) { }

	public Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData) { }

	public CodeTypeDeclaration ProcessImportedType(CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit) { }

}

