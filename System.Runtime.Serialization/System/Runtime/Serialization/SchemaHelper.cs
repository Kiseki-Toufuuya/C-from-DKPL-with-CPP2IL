namespace System.Runtime.Serialization;

internal static class SchemaHelper
{

	internal static void AddElementForm(XmlSchemaElement element, XmlSchema schema) { }

	internal static void AddSchemaImport(string ns, XmlSchema schema) { }

	private static XmlSchema CreateSchema(string ns, XmlSchemaSet schemas) { }

	internal static XmlQualifiedName GetGlobalElementDeclaration(XmlSchemaSet schemas, XmlQualifiedName typeQName, out bool isNullable) { }

	internal static XmlSchema GetSchema(string ns, XmlSchemaSet schemas) { }

	internal static XmlSchemaElement GetSchemaElement(XmlSchemaSet schemas, XmlQualifiedName elementQName, out XmlSchema outSchema) { }

	internal static XmlSchemaElement GetSchemaElement(Dictionary<XmlQualifiedName, SchemaObjectInfo> schemaInfo, XmlQualifiedName elementName) { }

	internal static XmlSchemaType GetSchemaType(XmlSchemaSet schemas, XmlQualifiedName typeQName, out XmlSchema outSchema) { }

	internal static XmlSchemaType GetSchemaType(Dictionary<XmlQualifiedName, SchemaObjectInfo> schemaInfo, XmlQualifiedName typeName) { }

	internal static XmlSchema GetSchemaWithGlobalElementDeclaration(XmlSchemaElement element, XmlSchemaSet schemas) { }

	internal static XmlSchema GetSchemaWithType(Dictionary<XmlQualifiedName, SchemaObjectInfo> schemaInfo, XmlSchemaSet schemas, XmlQualifiedName typeName) { }

	internal static bool NamespacesEqual(string ns1, string ns2) { }

}

