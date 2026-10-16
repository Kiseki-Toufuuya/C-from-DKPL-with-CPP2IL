namespace System.Runtime.Serialization;

internal static class XmlFormatGeneratorStatics
{
	private static MethodInfo writeStartElementMethod2; //Field offset: 0x0
	private static MethodInfo writeStartElementMethod3; //Field offset: 0x4
	private static MethodInfo writeEndElementMethod; //Field offset: 0x8
	private static MethodInfo writeNamespaceDeclMethod; //Field offset: 0xC
	private static PropertyInfo extensionDataProperty; //Field offset: 0x10
	private static MethodInfo boxPointer; //Field offset: 0x14
	private static ConstructorInfo dictionaryEnumeratorCtor; //Field offset: 0x18
	private static MethodInfo ienumeratorMoveNextMethod; //Field offset: 0x1C
	private static MethodInfo ienumeratorGetCurrentMethod; //Field offset: 0x20
	private static MethodInfo getItemContractMethod; //Field offset: 0x24
	private static MethodInfo isStartElementMethod2; //Field offset: 0x28
	private static MethodInfo isStartElementMethod0; //Field offset: 0x2C
	private static MethodInfo getUninitializedObjectMethod; //Field offset: 0x30
	private static MethodInfo onDeserializationMethod; //Field offset: 0x34
	private static MethodInfo unboxPointer; //Field offset: 0x38
	private static PropertyInfo nodeTypeProperty; //Field offset: 0x3C
	private static ConstructorInfo serializationExceptionCtor; //Field offset: 0x40
	private static ConstructorInfo extensionDataObjectCtor; //Field offset: 0x44
	private static ConstructorInfo hashtableCtor; //Field offset: 0x48
	private static MethodInfo getStreamingContextMethod; //Field offset: 0x4C
	private static MethodInfo getCollectionMemberMethod; //Field offset: 0x50
	private static MethodInfo storeCollectionMemberInfoMethod; //Field offset: 0x54
	private static MethodInfo storeIsGetOnlyCollectionMethod; //Field offset: 0x58
	private static MethodInfo throwNullValueReturnedForGetOnlyCollectionExceptionMethod; //Field offset: 0x5C
	private static MethodInfo throwArrayExceededSizeExceptionMethod; //Field offset: 0x60
	private static MethodInfo incrementItemCountMethod; //Field offset: 0x64
	private static MethodInfo demandSerializationFormatterPermissionMethod; //Field offset: 0x68
	private static MethodInfo demandMemberAccessPermissionMethod; //Field offset: 0x6C
	private static MethodInfo internalDeserializeMethod; //Field offset: 0x70
	private static MethodInfo moveToNextElementMethod; //Field offset: 0x74
	private static MethodInfo getMemberIndexMethod; //Field offset: 0x78
	private static MethodInfo getMemberIndexWithRequiredMembersMethod; //Field offset: 0x7C
	private static MethodInfo throwRequiredMemberMissingExceptionMethod; //Field offset: 0x80
	private static MethodInfo skipUnknownElementMethod; //Field offset: 0x84
	private static MethodInfo readIfNullOrRefMethod; //Field offset: 0x88
	private static MethodInfo readAttributesMethod; //Field offset: 0x8C
	private static MethodInfo resetAttributesMethod; //Field offset: 0x90
	private static MethodInfo getObjectIdMethod; //Field offset: 0x94
	private static MethodInfo getArraySizeMethod; //Field offset: 0x98
	private static MethodInfo addNewObjectMethod; //Field offset: 0x9C
	private static MethodInfo addNewObjectWithIdMethod; //Field offset: 0xA0
	private static MethodInfo replaceDeserializedObjectMethod; //Field offset: 0xA4
	private static MethodInfo getExistingObjectMethod; //Field offset: 0xA8
	private static MethodInfo getRealObjectMethod; //Field offset: 0xAC
	private static MethodInfo readMethod; //Field offset: 0xB0
	private static MethodInfo ensureArraySizeMethod; //Field offset: 0xB4
	private static MethodInfo trimArraySizeMethod; //Field offset: 0xB8
	private static MethodInfo checkEndOfArrayMethod; //Field offset: 0xBC
	private static MethodInfo getArrayLengthMethod; //Field offset: 0xC0
	private static MethodInfo readSerializationInfoMethod; //Field offset: 0xC4
	private static MethodInfo createUnexpectedStateExceptionMethod; //Field offset: 0xC8
	private static MethodInfo internalSerializeReferenceMethod; //Field offset: 0xCC
	private static MethodInfo internalSerializeMethod; //Field offset: 0xD0
	private static MethodInfo writeNullMethod; //Field offset: 0xD4
	private static MethodInfo incrementArrayCountMethod; //Field offset: 0xD8
	private static MethodInfo incrementCollectionCountMethod; //Field offset: 0xDC
	private static MethodInfo incrementCollectionCountGenericMethod; //Field offset: 0xE0
	private static MethodInfo getDefaultValueMethod; //Field offset: 0xE4
	private static MethodInfo getNullableValueMethod; //Field offset: 0xE8
	private static MethodInfo throwRequiredMemberMustBeEmittedMethod; //Field offset: 0xEC
	private static MethodInfo getHasValueMethod; //Field offset: 0xF0
	private static MethodInfo writeISerializableMethod; //Field offset: 0xF4
	private static MethodInfo writeExtensionDataMethod; //Field offset: 0xF8
	private static MethodInfo writeXmlValueMethod; //Field offset: 0xFC
	private static MethodInfo readXmlValueMethod; //Field offset: 0x100
	private static MethodInfo throwTypeNotSerializableMethod; //Field offset: 0x104
	private static PropertyInfo namespaceProperty; //Field offset: 0x108
	private static FieldInfo contractNamespacesField; //Field offset: 0x10C
	private static FieldInfo memberNamesField; //Field offset: 0x110
	private static MethodInfo extensionDataSetExplicitMethodInfo; //Field offset: 0x114
	private static PropertyInfo childElementNamespacesProperty; //Field offset: 0x118
	private static PropertyInfo collectionItemNameProperty; //Field offset: 0x11C
	private static PropertyInfo childElementNamespaceProperty; //Field offset: 0x120
	private static MethodInfo getDateTimeOffsetMethod; //Field offset: 0x124
	private static MethodInfo getDateTimeOffsetAdapterMethod; //Field offset: 0x128
	private static MethodInfo traceInstructionMethod; //Field offset: 0x12C
	private static MethodInfo throwInvalidDataContractExceptionMethod; //Field offset: 0x130
	private static PropertyInfo serializeReadOnlyTypesProperty; //Field offset: 0x134
	private static PropertyInfo classSerializationExceptionMessageProperty; //Field offset: 0x138
	private static PropertyInfo collectionSerializationExceptionMessageProperty; //Field offset: 0x13C

	internal static MethodInfo AddNewObjectMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo AddNewObjectWithIdMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo BoxPointer
	{
		internal get { } //Length: 183
	}

	internal static MethodInfo CheckEndOfArrayMethod
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo ChildElementNamespaceProperty
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo ChildElementNamespacesProperty
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo ClassSerializationExceptionMessageProperty
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo CollectionItemNameProperty
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo CollectionSerializationExceptionMessageProperty
	{
		internal get { } //Length: 196
	}

	internal static FieldInfo ContractNamespacesField
	{
		internal get { } //Length: 205
	}

	internal static MethodInfo CreateUnexpectedStateExceptionMethod
	{
		internal get { } //Length: 425
	}

	internal static MethodInfo DemandMemberAccessPermissionMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo DemandSerializationFormatterPermissionMethod
	{
		internal get { } //Length: 185
	}

	internal static ConstructorInfo DictionaryEnumeratorCtor
	{
		internal get { } //Length: 308
	}

	internal static MethodInfo EnsureArraySizeMethod
	{
		internal get { } //Length: 196
	}

	internal static ConstructorInfo ExtensionDataObjectCtor
	{
		internal get { } //Length: 230
	}

	internal static PropertyInfo ExtensionDataProperty
	{
		internal get { } //Length: 183
	}

	internal static MethodInfo ExtensionDataSetExplicitMethodInfo
	{
		internal get { } //Length: 194
	}

	internal static MethodInfo GetArrayLengthMethod
	{
		internal get { } //Length: 200
	}

	internal static MethodInfo GetArraySizeMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetCollectionMemberMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo GetCurrentMethod
	{
		internal get { } //Length: 198
	}

	internal static MethodInfo GetDateTimeOffsetAdapterMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetDateTimeOffsetMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetDefaultValueMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetExistingObjectMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetHasValueMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetItemContractMethod
	{
		internal get { } //Length: 211
	}

	internal static MethodInfo GetMemberIndexMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo GetMemberIndexWithRequiredMembersMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo GetNullableValueMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetObjectIdMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetRealObjectMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo GetStreamingContextMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo GetUninitializedObjectMethod
	{
		internal get { } //Length: 310
	}

	internal static ConstructorInfo HashtableCtor
	{
		internal get { } //Length: 207
	}

	internal static MethodInfo IncrementArrayCountMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo IncrementCollectionCountGenericMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo IncrementCollectionCountMethod
	{
		internal get { } //Length: 425
	}

	internal static MethodInfo IncrementItemCountMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo InternalDeserializeMethod
	{
		internal get { } //Length: 667
	}

	internal static MethodInfo InternalSerializeMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo InternalSerializeReferenceMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo IsStartElementMethod0
	{
		internal get { } //Length: 215
	}

	internal static MethodInfo IsStartElementMethod2
	{
		internal get { } //Length: 400
	}

	internal static FieldInfo MemberNamesField
	{
		internal get { } //Length: 205
	}

	internal static MethodInfo MoveNextMethod
	{
		internal get { } //Length: 183
	}

	internal static MethodInfo MoveToNextElementMethod
	{
		internal get { } //Length: 185
	}

	internal static PropertyInfo NamespaceProperty
	{
		internal get { } //Length: 196
	}

	internal static PropertyInfo NodeTypeProperty
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo OnDeserializationMethod
	{
		internal get { } //Length: 183
	}

	internal static MethodInfo ReadAttributesMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ReadIfNullOrRefMethod
	{
		internal get { } //Length: 505
	}

	internal static MethodInfo ReadMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ReadSerializationInfoMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ReadXmlValueMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ReplaceDeserializedObjectMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ResetAttributesMethod
	{
		internal get { } //Length: 196
	}

	internal static ConstructorInfo SerializationExceptionCtor
	{
		internal get { } //Length: 319
	}

	internal static PropertyInfo SerializeReadOnlyTypesProperty
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo SkipUnknownElementMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo StoreCollectionMemberInfoMethod
	{
		internal get { } //Length: 310
	}

	internal static MethodInfo StoreIsGetOnlyCollectionMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo ThrowArrayExceededSizeExceptionMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo ThrowInvalidDataContractExceptionMethod
	{
		internal get { } //Length: 412
	}

	internal static MethodInfo ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod
	{
		internal get { } //Length: 185
	}

	internal static MethodInfo ThrowRequiredMemberMissingExceptionMethod
	{
		internal get { } //Length: 194
	}

	internal static MethodInfo ThrowRequiredMemberMustBeEmittedMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo ThrowTypeNotSerializableMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo TraceInstructionMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo TrimArraySizeMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo UnboxPointer
	{
		internal get { } //Length: 183
	}

	internal static MethodInfo WriteEndElementMethod
	{
		internal get { } //Length: 215
	}

	internal static MethodInfo WriteExtensionDataMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo WriteISerializableMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo WriteNamespaceDeclMethod
	{
		internal get { } //Length: 316
	}

	internal static MethodInfo WriteNullMethod
	{
		internal get { } //Length: 505
	}

	internal static MethodInfo WriteStartElementMethod2
	{
		internal get { } //Length: 393
	}

	internal static MethodInfo WriteStartElementMethod3
	{
		internal get { } //Length: 492
	}

	internal static MethodInfo WriteXmlValueMethod
	{
		internal get { } //Length: 196
	}

	internal static MethodInfo get_AddNewObjectMethod() { }

	internal static MethodInfo get_AddNewObjectWithIdMethod() { }

	internal static MethodInfo get_BoxPointer() { }

	internal static MethodInfo get_CheckEndOfArrayMethod() { }

	internal static PropertyInfo get_ChildElementNamespaceProperty() { }

	internal static PropertyInfo get_ChildElementNamespacesProperty() { }

	internal static PropertyInfo get_ClassSerializationExceptionMessageProperty() { }

	internal static PropertyInfo get_CollectionItemNameProperty() { }

	internal static PropertyInfo get_CollectionSerializationExceptionMessageProperty() { }

	internal static FieldInfo get_ContractNamespacesField() { }

	internal static MethodInfo get_CreateUnexpectedStateExceptionMethod() { }

	internal static MethodInfo get_DemandMemberAccessPermissionMethod() { }

	internal static MethodInfo get_DemandSerializationFormatterPermissionMethod() { }

	internal static ConstructorInfo get_DictionaryEnumeratorCtor() { }

	internal static MethodInfo get_EnsureArraySizeMethod() { }

	internal static ConstructorInfo get_ExtensionDataObjectCtor() { }

	internal static PropertyInfo get_ExtensionDataProperty() { }

	internal static MethodInfo get_ExtensionDataSetExplicitMethodInfo() { }

	internal static MethodInfo get_GetArrayLengthMethod() { }

	internal static MethodInfo get_GetArraySizeMethod() { }

	internal static MethodInfo get_GetCollectionMemberMethod() { }

	internal static MethodInfo get_GetCurrentMethod() { }

	internal static MethodInfo get_GetDateTimeOffsetAdapterMethod() { }

	internal static MethodInfo get_GetDateTimeOffsetMethod() { }

	internal static MethodInfo get_GetDefaultValueMethod() { }

	internal static MethodInfo get_GetExistingObjectMethod() { }

	internal static MethodInfo get_GetHasValueMethod() { }

	internal static MethodInfo get_GetItemContractMethod() { }

	internal static MethodInfo get_GetMemberIndexMethod() { }

	internal static MethodInfo get_GetMemberIndexWithRequiredMembersMethod() { }

	internal static MethodInfo get_GetNullableValueMethod() { }

	internal static MethodInfo get_GetObjectIdMethod() { }

	internal static MethodInfo get_GetRealObjectMethod() { }

	internal static MethodInfo get_GetStreamingContextMethod() { }

	internal static MethodInfo get_GetUninitializedObjectMethod() { }

	internal static ConstructorInfo get_HashtableCtor() { }

	internal static MethodInfo get_IncrementArrayCountMethod() { }

	internal static MethodInfo get_IncrementCollectionCountGenericMethod() { }

	internal static MethodInfo get_IncrementCollectionCountMethod() { }

	internal static MethodInfo get_IncrementItemCountMethod() { }

	internal static MethodInfo get_InternalDeserializeMethod() { }

	internal static MethodInfo get_InternalSerializeMethod() { }

	internal static MethodInfo get_InternalSerializeReferenceMethod() { }

	internal static MethodInfo get_IsStartElementMethod0() { }

	internal static MethodInfo get_IsStartElementMethod2() { }

	internal static FieldInfo get_MemberNamesField() { }

	internal static MethodInfo get_MoveNextMethod() { }

	internal static MethodInfo get_MoveToNextElementMethod() { }

	internal static PropertyInfo get_NamespaceProperty() { }

	internal static PropertyInfo get_NodeTypeProperty() { }

	internal static MethodInfo get_OnDeserializationMethod() { }

	internal static MethodInfo get_ReadAttributesMethod() { }

	internal static MethodInfo get_ReadIfNullOrRefMethod() { }

	internal static MethodInfo get_ReadMethod() { }

	internal static MethodInfo get_ReadSerializationInfoMethod() { }

	internal static MethodInfo get_ReadXmlValueMethod() { }

	internal static MethodInfo get_ReplaceDeserializedObjectMethod() { }

	internal static MethodInfo get_ResetAttributesMethod() { }

	internal static ConstructorInfo get_SerializationExceptionCtor() { }

	internal static PropertyInfo get_SerializeReadOnlyTypesProperty() { }

	internal static MethodInfo get_SkipUnknownElementMethod() { }

	internal static MethodInfo get_StoreCollectionMemberInfoMethod() { }

	internal static MethodInfo get_StoreIsGetOnlyCollectionMethod() { }

	internal static MethodInfo get_ThrowArrayExceededSizeExceptionMethod() { }

	internal static MethodInfo get_ThrowInvalidDataContractExceptionMethod() { }

	internal static MethodInfo get_ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod() { }

	internal static MethodInfo get_ThrowRequiredMemberMissingExceptionMethod() { }

	internal static MethodInfo get_ThrowRequiredMemberMustBeEmittedMethod() { }

	internal static MethodInfo get_ThrowTypeNotSerializableMethod() { }

	internal static MethodInfo get_TraceInstructionMethod() { }

	internal static MethodInfo get_TrimArraySizeMethod() { }

	internal static MethodInfo get_UnboxPointer() { }

	internal static MethodInfo get_WriteEndElementMethod() { }

	internal static MethodInfo get_WriteExtensionDataMethod() { }

	internal static MethodInfo get_WriteISerializableMethod() { }

	internal static MethodInfo get_WriteNamespaceDeclMethod() { }

	internal static MethodInfo get_WriteNullMethod() { }

	internal static MethodInfo get_WriteStartElementMethod2() { }

	internal static MethodInfo get_WriteStartElementMethod3() { }

	internal static MethodInfo get_WriteXmlValueMethod() { }

}

