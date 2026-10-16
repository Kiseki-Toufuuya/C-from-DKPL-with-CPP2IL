namespace System.Runtime.Serialization;

public static class XmlSerializableServices
{
	internal static readonly string ReadNodesMethodName; //Field offset: 0x0
	internal static string WriteNodesMethodName; //Field offset: 0x4
	internal static string AddDefaultSchemaMethodName; //Field offset: 0x8

	private static XmlSerializableServices() { }

	public static void AddDefaultSchema(XmlSchemaSet schemas, XmlQualifiedName typeQName) { }

	private static bool IsValidAttribute(XmlReader xmlReader) { }

	public static XmlNode[] ReadNodes(XmlReader xmlReader) { }

	public static void WriteNodes(XmlWriter xmlWriter, XmlNode[] nodes) { }

}

