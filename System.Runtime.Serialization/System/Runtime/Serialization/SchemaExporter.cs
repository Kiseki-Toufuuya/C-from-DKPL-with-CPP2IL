namespace System.Runtime.Serialization;

internal class SchemaExporter
{
	private static XmlQualifiedName anytypeQualifiedName; //Field offset: 0x0
	private static XmlQualifiedName stringQualifiedName; //Field offset: 0x4
	private static XmlQualifiedName defaultEnumBaseTypeName; //Field offset: 0x8
	private static XmlQualifiedName enumerationValueAnnotationName; //Field offset: 0xC
	private static XmlQualifiedName surrogateDataAnnotationName; //Field offset: 0x10
	private static XmlQualifiedName defaultValueAnnotation; //Field offset: 0x14
	private static XmlQualifiedName actualTypeAnnotationName; //Field offset: 0x18
	private static XmlQualifiedName isDictionaryAnnotationName; //Field offset: 0x1C
	private static XmlQualifiedName isValueTypeName; //Field offset: 0x20
	private XmlSchemaSet schemas; //Field offset: 0x8
	private XmlDocument xmlDoc; //Field offset: 0xC
	private DataContractSet dataContractSet; //Field offset: 0x10

	internal static XmlQualifiedName ActualTypeAnnotationName
	{
		internal get { } //Length: 187
	}

	internal static XmlQualifiedName AnytypeQualifiedName
	{
		internal get { } //Length: 180
	}

	internal static XmlQualifiedName DefaultEnumBaseTypeName
	{
		internal get { } //Length: 187
	}

	internal static XmlQualifiedName DefaultValueAnnotation
	{
		internal get { } //Length: 187
	}

	internal static XmlQualifiedName EnumerationValueAnnotationName
	{
		internal get { } //Length: 187
	}

	internal static XmlSchemaAttribute IdAttribute
	{
		internal get { } //Length: 349
	}

	internal static XmlQualifiedName IsDictionaryAnnotationName
	{
		internal get { } //Length: 187
	}

	internal static XmlSchemaAttribute ISerializableFactoryTypeAttribute
	{
		internal get { } //Length: 144
	}

	internal static XmlSchemaSequence ISerializableSequence
	{
		internal get { } //Length: 289
	}

	internal static XmlSchemaAny ISerializableWildcardElement
	{
		internal get { } //Length: 186
	}

	internal static XmlQualifiedName IsValueTypeName
	{
		internal get { } //Length: 187
	}

	internal static XmlSchemaAttribute RefAttribute
	{
		internal get { } //Length: 356
	}

	private XmlSchemaSet Schemas
	{
		private get { } //Length: 11
	}

	internal static XmlQualifiedName StringQualifiedName
	{
		internal get { } //Length: 187
	}

	internal static XmlQualifiedName SurrogateDataAnnotationName
	{
		internal get { } //Length: 187
	}

	private XmlDocument XmlDoc
	{
		private get { } //Length: 87
	}

	internal SchemaExporter(XmlSchemaSet schemas, DataContractSet dataContractSet) { }

	private static void AddDefaultDatasetType(XmlSchemaSet schemas, string localName, string ns) { }

	private static void AddDefaultTypedDatasetType(XmlSchemaSet schemas, XmlSchema datasetSchema, string localName, string ns) { }

	internal static void AddDefaultXmlType(XmlSchemaSet schemas, string localName, string ns) { }

	private void AddReferenceAttributes(XmlSchemaObjectCollection attributes, XmlSchema schema) { }

	private bool CheckIfMemberHasConflict(DataMember dataMember) { }

	private static XmlSchemaComplexType CreateAnyElementType() { }

	private static XmlSchemaComplexType CreateAnyType() { }

	private XmlSchemaComplexContentExtension CreateTypeContent(XmlSchemaComplexType type, XmlQualifiedName baseTypeName, XmlSchema schema) { }

	internal void Export() { }

	private XmlElement ExportActualType(XmlQualifiedName typeName) { }

	private static XmlElement ExportActualType(XmlQualifiedName typeName, XmlDocument xmlDoc) { }

	private void ExportClassDataContract(ClassDataContract classDataContract, XmlSchema schema) { }

	private void ExportCollectionDataContract(CollectionDataContract collectionDataContract, XmlSchema schema) { }

	private void ExportDataContract(DataContract dataContract) { }

	private XmlElement ExportEmitDefaultValue(DataMember dataMember) { }

	private void ExportEnumDataContract(EnumDataContract enumDataContract, XmlSchema schema) { }

	private XmlElement ExportGenericInfo(Type clrType, string elementName, string elementNs) { }

	private XmlElement ExportIsDictionary() { }

	private void ExportISerializableDataContract(ClassDataContract dataContract, XmlSchema schema) { }

	private void ExportSerializationSchema() { }

	private XmlElement ExportSurrogateData(object key) { }

	private XmlSchemaElement ExportTopLevelElement(DataContract dataContract, XmlSchema schema) { }

	private void ExportXmlDataContract(XmlDataContract dataContract) { }

	internal static XmlQualifiedName get_ActualTypeAnnotationName() { }

	internal static XmlQualifiedName get_AnytypeQualifiedName() { }

	internal static XmlQualifiedName get_DefaultEnumBaseTypeName() { }

	internal static XmlQualifiedName get_DefaultValueAnnotation() { }

	internal static XmlQualifiedName get_EnumerationValueAnnotationName() { }

	internal static XmlSchemaAttribute get_IdAttribute() { }

	internal static XmlQualifiedName get_IsDictionaryAnnotationName() { }

	internal static XmlSchemaAttribute get_ISerializableFactoryTypeAttribute() { }

	internal static XmlSchemaSequence get_ISerializableSequence() { }

	internal static XmlSchemaAny get_ISerializableWildcardElement() { }

	internal static XmlQualifiedName get_IsValueTypeName() { }

	internal static XmlSchemaAttribute get_RefAttribute() { }

	private XmlSchemaSet get_Schemas() { }

	internal static XmlQualifiedName get_StringQualifiedName() { }

	internal static XmlQualifiedName get_SurrogateDataAnnotationName() { }

	private XmlDocument get_XmlDoc() { }

	private XmlElement GetAnnotationMarkup(XmlQualifiedName annotationQualifiedName, string innerText, XmlSchema schema) { }

	internal static long GetDefaultEnumValue(bool isFlags, int index) { }

	private XmlSchema GetSchema(string ns) { }

	private static XmlSchemaAnnotation GetSchemaAnnotation(XmlNode[] nodes) { }

	private XmlSchemaAnnotation GetSchemaAnnotation(XmlQualifiedName annotationQualifiedName, string innerText, XmlSchema schema) { }

	internal static void GetXmlTypeInfo(Type type, out XmlQualifiedName stableName, out XmlSchemaType xsdType, out bool hasRoot) { }

	private static void InvokeGetSchemaMethod(Type clrType, XmlSchemaSet schemas, XmlQualifiedName stableName) { }

	private static bool InvokeSchemaProviderMethod(Type clrType, XmlSchemaSet schemas, out XmlQualifiedName stableName, out XmlSchemaType xsdType, out bool hasRoot) { }

	internal static bool IsSpecialXmlType(Type type, out XmlQualifiedName typeName, out XmlSchemaType xsdType, out bool hasRoot) { }

	private static void ReprocessAll(XmlSchemaSet schemas) { }

	private void SetElementType(XmlSchemaElement element, DataContract dataContract, XmlSchema schema) { }

}

