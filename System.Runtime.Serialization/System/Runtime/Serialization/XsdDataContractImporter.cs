namespace System.Runtime.Serialization;

public class XsdDataContractImporter
{

	public CodeCompileUnit CodeCompileUnit
	{
		 get { } //Length: 40
	}

	public ImportOptions Options
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public XsdDataContractImporter() { }

	public XsdDataContractImporter(CodeCompileUnit codeCompileUnit) { }

	public bool CanImport(XmlSchemaSet schemas) { }

	public bool CanImport(XmlSchemaSet schemas, ICollection<XmlQualifiedName> typeNames) { }

	public bool CanImport(XmlSchemaSet schemas, XmlSchemaElement element) { }

	public bool CanImport(XmlSchemaSet schemas, XmlQualifiedName typeName) { }

	public CodeCompileUnit get_CodeCompileUnit() { }

	public ImportOptions get_Options() { }

	public CodeTypeReference GetCodeTypeReference(XmlQualifiedName typeName) { }

	public CodeTypeReference GetCodeTypeReference(XmlQualifiedName typeName, XmlSchemaElement element) { }

	public ICollection<CodeTypeReference> GetKnownTypeReferences(XmlQualifiedName typeName) { }

	public void Import(XmlSchemaSet schemas) { }

	public void Import(XmlSchemaSet schemas, ICollection<XmlQualifiedName> typeNames) { }

	public XmlQualifiedName Import(XmlSchemaSet schemas, XmlSchemaElement element) { }

	public void Import(XmlSchemaSet schemas, XmlQualifiedName typeName) { }

	public void set_Options(ImportOptions value) { }

}

