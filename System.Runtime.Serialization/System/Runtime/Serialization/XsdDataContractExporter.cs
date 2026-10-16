namespace System.Runtime.Serialization;

public class XsdDataContractExporter
{
	private ExportOptions _options; //Field offset: 0x8
	private XmlSchemaSet _schemas; //Field offset: 0xC
	private DataContractSet _dataContractSet; //Field offset: 0x10

	private DataContractSet DataContractSet
	{
		private get { } //Length: 64
	}

	public ExportOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaSet Schemas
	{
		 get { } //Length: 100
	}

	public XsdDataContractExporter() { }

	public XsdDataContractExporter(XmlSchemaSet schemas) { }

	private void AddKnownTypes() { }

	private void AddType(Type type) { }

	public bool CanExport(ICollection<Assembly> assemblies) { }

	public bool CanExport(ICollection<Type> types) { }

	public bool CanExport(Type type) { }

	private void CheckAndAddType(Type type) { }

	public void Export(ICollection<Type> types) { }

	private void Export() { }

	public void Export(ICollection<Assembly> assemblies) { }

	public void Export(Type type) { }

	private DataContractSet get_DataContractSet() { }

	public ExportOptions get_Options() { }

	public XmlSchemaSet get_Schemas() { }

	public XmlQualifiedName GetRootElementName(Type type) { }

	private XmlSchemaSet GetSchemaSet() { }

	public XmlSchemaType GetSchemaType(Type type) { }

	public XmlQualifiedName GetSchemaTypeName(Type type) { }

	private Type GetSurrogatedType(Type type) { }

	public void set_Options(ExportOptions value) { }

	private void TraceExportBegin() { }

	private void TraceExportEnd() { }

	private void TraceExportError(Exception exception) { }

}

