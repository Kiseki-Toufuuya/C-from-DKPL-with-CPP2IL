namespace System.Runtime.Serialization;

internal static class DataContractSurrogateCaller
{

	internal static object GetCustomDataToExport(IDataContractSurrogate surrogate, MemberInfo memberInfo, Type dataContractType) { }

	internal static object GetCustomDataToExport(IDataContractSurrogate surrogate, Type clrType, Type dataContractType) { }

	internal static Type GetDataContractType(IDataContractSurrogate surrogate, Type type) { }

	internal static object GetDeserializedObject(IDataContractSurrogate surrogate, object obj, Type objType, Type memberType) { }

	internal static void GetKnownCustomDataTypes(IDataContractSurrogate surrogate, Collection<Type> customDataTypes) { }

	internal static object GetObjectToSerialize(IDataContractSurrogate surrogate, object obj, Type objType, Type membertype) { }

	internal static Type GetReferencedTypeOnImport(IDataContractSurrogate surrogate, string typeName, string typeNamespace, object customData) { }

	internal static CodeTypeDeclaration ProcessImportedType(IDataContractSurrogate surrogate, CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit) { }

}

