namespace System.Runtime.Serialization;

internal static class JsonFormatGeneratorStatics
{
	private static MethodInfo boxPointer; //Field offset: 0x0
	private static PropertyInfo collectionItemNameProperty; //Field offset: 0x4
	private static ConstructorInfo extensionDataObjectCtor; //Field offset: 0x8
	private static PropertyInfo extensionDataProperty; //Field offset: 0xC
	private static MethodInfo getItemContractMethod; //Field offset: 0x10
	private static MethodInfo getJsonDataContractMethod; //Field offset: 0x14
	private static MethodInfo getJsonMemberIndexMethod; //Field offset: 0x18
	private static MethodInfo getRevisedItemContractMethod; //Field offset: 0x1C
	private static MethodInfo getUninitializedObjectMethod; //Field offset: 0x20
	private static MethodInfo ienumeratorGetCurrentMethod; //Field offset: 0x24
	private static MethodInfo ienumeratorMoveNextMethod; //Field offset: 0x28
	private static MethodInfo isStartElementMethod0; //Field offset: 0x2C
	private static MethodInfo isStartElementMethod2; //Field offset: 0x30
	private static PropertyInfo localNameProperty; //Field offset: 0x34
	private static PropertyInfo namespaceProperty; //Field offset: 0x38
	private static MethodInfo moveToContentMethod; //Field offset: 0x3C
	private static PropertyInfo nodeTypeProperty; //Field offset: 0x40
	private static MethodInfo onDeserializationMethod; //Field offset: 0x44
	private static MethodInfo readJsonValueMethod; //Field offset: 0x48
	private static ConstructorInfo serializationExceptionCtor; //Field offset: 0x4C
	private static Type[] serInfoCtorArgs; //Field offset: 0x50
	private static MethodInfo throwDuplicateMemberExceptionMethod; //Field offset: 0x54
	private static MethodInfo throwMissingRequiredMembersMethod; //Field offset: 0x58
	private static PropertyInfo typeHandleProperty; //Field offset: 0x5C
	private static MethodInfo unboxPointer; //Field offset: 0x60
	private static PropertyInfo useSimpleDictionaryFormatReadProperty; //Field offset: 0x64
	private static PropertyInfo useSimpleDictionaryFormatWriteProperty; //Field offset: 0x68
	private static MethodInfo writeAttributeStringMethod; //Field offset: 0x6C
	private static MethodInfo writeEndElementMethod; //Field offset: 0x70
	private static MethodInfo writeJsonISerializableMethod; //Field offset: 0x74
	private static MethodInfo writeJsonNameWithMappingMethod; //Field offset: 0x78
	private static MethodInfo writeJsonValueMethod; //Field offset: 0x7C
	private static MethodInfo writeStartElementMethod; //Field offset: 0x80
	private static MethodInfo writeStartElementStringMethod; //Field offset: 0x84
	private static MethodInfo parseEnumMethod; //Field offset: 0x88
	private static MethodInfo getJsonMemberNameMethod; //Field offset: 0x8C

	public static MethodInfo BoxPointer
	{
		 get { } //Length: 176
	}

	public static PropertyInfo CollectionItemNameProperty
	{
		 get { } //Length: 185
	}

	public static ConstructorInfo ExtensionDataObjectCtor
	{
		 get { } //Length: 230
	}

	public static PropertyInfo ExtensionDataProperty
	{
		 get { } //Length: 183
	}

	public static MethodInfo GetCurrentMethod
	{
		 get { } //Length: 198
	}

	public static MethodInfo GetItemContractMethod
	{
		 get { } //Length: 211
	}

	public static MethodInfo GetJsonDataContractMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo GetJsonMemberIndexMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo GetJsonMemberNameMethod
	{
		 get { } //Length: 327
	}

	public static MethodInfo GetRevisedItemContractMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo GetUninitializedObjectMethod
	{
		 get { } //Length: 310
	}

	public static MethodInfo IsStartElementMethod0
	{
		 get { } //Length: 215
	}

	public static MethodInfo IsStartElementMethod2
	{
		 get { } //Length: 400
	}

	public static PropertyInfo LocalNameProperty
	{
		 get { } //Length: 185
	}

	public static MethodInfo MoveNextMethod
	{
		 get { } //Length: 183
	}

	public static MethodInfo MoveToContentMethod
	{
		 get { } //Length: 185
	}

	public static PropertyInfo NamespaceProperty
	{
		 get { } //Length: 185
	}

	public static PropertyInfo NodeTypeProperty
	{
		 get { } //Length: 185
	}

	public static MethodInfo OnDeserializationMethod
	{
		 get { } //Length: 183
	}

	public static MethodInfo ParseEnumMethod
	{
		 get { } //Length: 405
	}

	public static MethodInfo ReadJsonValueMethod
	{
		 get { } //Length: 185
	}

	public static ConstructorInfo SerializationExceptionCtor
	{
		 get { } //Length: 319
	}

	public static Type[] SerInfoCtorArgs
	{
		 get { } //Length: 336
	}

	public static MethodInfo ThrowDuplicateMemberExceptionMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo ThrowMissingRequiredMembersMethod
	{
		 get { } //Length: 185
	}

	public static PropertyInfo TypeHandleProperty
	{
		 get { } //Length: 170
	}

	public static MethodInfo UnboxPointer
	{
		 get { } //Length: 183
	}

	public static PropertyInfo UseSimpleDictionaryFormatReadProperty
	{
		 get { } //Length: 185
	}

	public static PropertyInfo UseSimpleDictionaryFormatWriteProperty
	{
		 get { } //Length: 185
	}

	public static MethodInfo WriteAttributeStringMethod
	{
		 get { } //Length: 571
	}

	public static MethodInfo WriteEndElementMethod
	{
		 get { } //Length: 215
	}

	public static MethodInfo WriteJsonISerializableMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo WriteJsonNameWithMappingMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo WriteJsonValueMethod
	{
		 get { } //Length: 185
	}

	public static MethodInfo WriteStartElementMethod
	{
		 get { } //Length: 409
	}

	public static MethodInfo WriteStartElementStringMethod
	{
		 get { } //Length: 412
	}

	public static MethodInfo get_BoxPointer() { }

	public static PropertyInfo get_CollectionItemNameProperty() { }

	public static ConstructorInfo get_ExtensionDataObjectCtor() { }

	public static PropertyInfo get_ExtensionDataProperty() { }

	public static MethodInfo get_GetCurrentMethod() { }

	public static MethodInfo get_GetItemContractMethod() { }

	public static MethodInfo get_GetJsonDataContractMethod() { }

	public static MethodInfo get_GetJsonMemberIndexMethod() { }

	public static MethodInfo get_GetJsonMemberNameMethod() { }

	public static MethodInfo get_GetRevisedItemContractMethod() { }

	public static MethodInfo get_GetUninitializedObjectMethod() { }

	public static MethodInfo get_IsStartElementMethod0() { }

	public static MethodInfo get_IsStartElementMethod2() { }

	public static PropertyInfo get_LocalNameProperty() { }

	public static MethodInfo get_MoveNextMethod() { }

	public static MethodInfo get_MoveToContentMethod() { }

	public static PropertyInfo get_NamespaceProperty() { }

	public static PropertyInfo get_NodeTypeProperty() { }

	public static MethodInfo get_OnDeserializationMethod() { }

	public static MethodInfo get_ParseEnumMethod() { }

	public static MethodInfo get_ReadJsonValueMethod() { }

	public static ConstructorInfo get_SerializationExceptionCtor() { }

	public static Type[] get_SerInfoCtorArgs() { }

	public static MethodInfo get_ThrowDuplicateMemberExceptionMethod() { }

	public static MethodInfo get_ThrowMissingRequiredMembersMethod() { }

	public static PropertyInfo get_TypeHandleProperty() { }

	public static MethodInfo get_UnboxPointer() { }

	public static PropertyInfo get_UseSimpleDictionaryFormatReadProperty() { }

	public static PropertyInfo get_UseSimpleDictionaryFormatWriteProperty() { }

	public static MethodInfo get_WriteAttributeStringMethod() { }

	public static MethodInfo get_WriteEndElementMethod() { }

	public static MethodInfo get_WriteJsonISerializableMethod() { }

	public static MethodInfo get_WriteJsonNameWithMappingMethod() { }

	public static MethodInfo get_WriteJsonValueMethod() { }

	public static MethodInfo get_WriteStartElementMethod() { }

	public static MethodInfo get_WriteStartElementStringMethod() { }

}

