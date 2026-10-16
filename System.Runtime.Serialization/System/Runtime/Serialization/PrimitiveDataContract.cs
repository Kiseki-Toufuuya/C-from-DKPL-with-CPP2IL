namespace System.Runtime.Serialization;

internal abstract class PrimitiveDataContract : DataContract
{
	private class PrimitiveDataContractCriticalHelper : DataContractCriticalHelper
	{
		private MethodInfo xmlFormatWriterMethod; //Field offset: 0x30
		private MethodInfo xmlFormatContentWriterMethod; //Field offset: 0x34
		private MethodInfo xmlFormatReaderMethod; //Field offset: 0x38

		internal MethodInfo XmlFormatContentWriterMethod
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal MethodInfo XmlFormatReaderMethod
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal MethodInfo XmlFormatWriterMethod
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal PrimitiveDataContractCriticalHelper(Type type, XmlDictionaryString name, XmlDictionaryString ns) { }

		internal MethodInfo get_XmlFormatContentWriterMethod() { }

		internal MethodInfo get_XmlFormatReaderMethod() { }

		internal MethodInfo get_XmlFormatWriterMethod() { }

		internal void set_XmlFormatContentWriterMethod(MethodInfo value) { }

		internal void set_XmlFormatReaderMethod(MethodInfo value) { }

		internal void set_XmlFormatWriterMethod(MethodInfo value) { }

	}

	private PrimitiveDataContractCriticalHelper helper; //Field offset: 0x14

	internal virtual bool CanContainReferences
	{
		internal get { } //Length: 3
	}

	internal virtual bool IsBuiltInDataContract
	{
		internal get { } //Length: 3
	}

	internal virtual bool IsPrimitive
	{
		internal get { } //Length: 3
	}

	internal abstract string ReadMethodName
	{
		internal get { } //Length: 0
	}

	internal virtual XmlDictionaryString TopLevelElementNamespace
	{
		internal get { } //Length: 61
		internal set { } //Length: 3
	}

	internal abstract string WriteMethodName
	{
		internal get { } //Length: 0
	}

	internal MethodInfo XmlFormatContentWriterMethod
	{
		internal get { } //Length: 630
	}

	internal MethodInfo XmlFormatReaderMethod
	{
		internal get { } //Length: 185
	}

	internal MethodInfo XmlFormatWriterMethod
	{
		internal get { } //Length: 996
	}

	protected PrimitiveDataContract(Type type, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal virtual bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	internal virtual bool get_CanContainReferences() { }

	internal virtual bool get_IsBuiltInDataContract() { }

	internal virtual bool get_IsPrimitive() { }

	internal abstract string get_ReadMethodName() { }

	internal virtual XmlDictionaryString get_TopLevelElementNamespace() { }

	internal abstract string get_WriteMethodName() { }

	internal MethodInfo get_XmlFormatContentWriterMethod() { }

	internal MethodInfo get_XmlFormatReaderMethod() { }

	internal MethodInfo get_XmlFormatWriterMethod() { }

	internal static PrimitiveDataContract GetPrimitiveDataContract(string name, string ns) { }

	internal static PrimitiveDataContract GetPrimitiveDataContract(Type type) { }

	protected object HandleReadValue(object obj, XmlObjectSerializerReadContext context) { }

	internal virtual void set_TopLevelElementNamespace(XmlDictionaryString value) { }

	protected bool TryReadNullAtTopLevel(XmlReaderDelegator reader) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}

