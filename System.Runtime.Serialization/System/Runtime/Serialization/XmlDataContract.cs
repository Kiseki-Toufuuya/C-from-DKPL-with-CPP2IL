namespace System.Runtime.Serialization;

internal sealed class XmlDataContract : DataContract
{
	private class XmlDataContractCriticalHelper : DataContractCriticalHelper
	{
		private Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0x30
		private bool isKnownTypeAttributeChecked; //Field offset: 0x34
		private XmlDictionaryString topLevelElementName; //Field offset: 0x38
		private XmlDictionaryString topLevelElementNamespace; //Field offset: 0x3C
		private bool isTopLevelElementNullable; //Field offset: 0x40
		private bool isTypeDefinedOnImport; //Field offset: 0x41
		private XmlSchemaType xsdType; //Field offset: 0x44
		private bool hasRoot; //Field offset: 0x48
		private CreateXmlSerializableDelegate createXmlSerializable; //Field offset: 0x4C

		internal CreateXmlSerializableDelegate CreateXmlSerializableDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal virtual bool HasRoot
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsAnonymous
		{
			internal get { } //Length: 15
		}

		internal bool IsTopLevelElementNullable
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsTypeDefinedOnImport
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			internal get { } //Length: 299
			internal set { } //Length: 27
		}

		internal virtual XmlDictionaryString TopLevelElementName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal virtual XmlDictionaryString TopLevelElementNamespace
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlSchemaType XsdType
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlDataContractCriticalHelper() { }

		internal XmlDataContractCriticalHelper(Type type) { }

		internal CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate() { }

		internal virtual bool get_HasRoot() { }

		internal bool get_IsAnonymous() { }

		internal bool get_IsTopLevelElementNullable() { }

		internal bool get_IsTypeDefinedOnImport() { }

		internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

		internal virtual XmlDictionaryString get_TopLevelElementName() { }

		internal virtual XmlDictionaryString get_TopLevelElementNamespace() { }

		internal XmlSchemaType get_XsdType() { }

		internal void set_CreateXmlSerializableDelegate(CreateXmlSerializableDelegate value) { }

		internal virtual void set_HasRoot(bool value) { }

		internal void set_IsTopLevelElementNullable(bool value) { }

		internal void set_IsTypeDefinedOnImport(bool value) { }

		internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

		internal virtual void set_TopLevelElementName(XmlDictionaryString value) { }

		internal virtual void set_TopLevelElementNamespace(XmlDictionaryString value) { }

		internal void set_XsdType(XmlSchemaType value) { }

	}

	private XmlDataContractCriticalHelper helper; //Field offset: 0x14

	internal virtual bool CanContainReferences
	{
		internal get { } //Length: 3
	}

	internal CreateXmlSerializableDelegate CreateXmlSerializableDelegate
	{
		internal get { } //Length: 441
	}

	internal virtual bool HasRoot
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal bool IsAnonymous
	{
		internal get { } //Length: 27
	}

	internal virtual bool IsBuiltInDataContract
	{
		internal get { } //Length: 211
	}

	internal bool IsTopLevelElementNullable
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsTypeDefinedOnImport
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal virtual XmlDictionaryString TopLevelElementName
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal virtual XmlDictionaryString TopLevelElementNamespace
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal XmlSchemaType XsdType
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal XmlDataContract() { }

	internal XmlDataContract(Type type) { }

	[CompilerGenerated]
	private IXmlSerializable <GenerateCreateXmlSerializableDelegate>b__39_0() { }

	internal virtual bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	internal CreateXmlSerializableDelegate GenerateCreateXmlSerializableDelegate() { }

	internal virtual bool get_CanContainReferences() { }

	internal CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate() { }

	internal virtual bool get_HasRoot() { }

	internal bool get_IsAnonymous() { }

	internal virtual bool get_IsBuiltInDataContract() { }

	internal bool get_IsTopLevelElementNullable() { }

	internal bool get_IsTypeDefinedOnImport() { }

	internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	internal virtual XmlDictionaryString get_TopLevelElementName() { }

	internal virtual XmlDictionaryString get_TopLevelElementNamespace() { }

	internal XmlSchemaType get_XsdType() { }

	private ConstructorInfo GetConstructor() { }

	public virtual int GetHashCode() { }

	public virtual object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	internal virtual void set_HasRoot(bool value) { }

	internal void set_IsTopLevelElementNullable(bool value) { }

	internal void set_IsTypeDefinedOnImport(bool value) { }

	internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

	internal virtual void set_TopLevelElementName(XmlDictionaryString value) { }

	internal virtual void set_TopLevelElementNamespace(XmlDictionaryString value) { }

	internal void set_XsdType(XmlSchemaType value) { }

	internal void SetTopLevelElementName(XmlQualifiedName elementName) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}

