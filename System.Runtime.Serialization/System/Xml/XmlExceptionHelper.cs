namespace System.Xml;

internal static class XmlExceptionHelper
{

	public static XmlException CreateConversionException(string value, string type, Exception exception) { }

	public static XmlException CreateEncodingException(string value, Exception exception) { }

	public static XmlException CreateEncodingException(Byte[] buffer, int offset, int count, Exception exception) { }

	private static string GetName(string prefix, string localName) { }

	private static string GetWhatWasFound(XmlDictionaryReader reader) { }

	public static void ThrowBase64DataExpected(XmlDictionaryReader reader) { }

	public static void ThrowConversionOverflow(XmlDictionaryReader reader, string value, string type) { }

	public static void ThrowDeclarationNotFirst(XmlDictionaryReader reader) { }

	public static void ThrowDuplicateAttribute(XmlDictionaryReader reader, string prefix1, string prefix2, string localName, string ns) { }

	public static void ThrowDuplicateXmlnsAttribute(XmlDictionaryReader reader, string localName, string ns) { }

	public static void ThrowEmptyNamespace(XmlDictionaryReader reader) { }

	public static void ThrowEndElementExpected(XmlDictionaryReader reader, string localName, string ns) { }

	public static void ThrowFullStartElementExpected(XmlDictionaryReader reader) { }

	public static void ThrowFullStartElementExpected(XmlDictionaryReader reader, string name) { }

	public static void ThrowFullStartElementExpected(XmlDictionaryReader reader, string localName, string ns) { }

	public static void ThrowFullStartElementExpected(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns) { }

	public static void ThrowInvalidBinaryFormat(XmlDictionaryReader reader) { }

	public static void ThrowInvalidCharRef(XmlDictionaryReader reader) { }

	public static void ThrowInvalidRootData(XmlDictionaryReader reader) { }

	public static void ThrowInvalidXml(XmlDictionaryReader reader, byte b) { }

	public static void ThrowMaxArrayLengthExceeded(XmlDictionaryReader reader, int maxArrayLength) { }

	public static void ThrowMaxArrayLengthOrMaxItemsQuotaExceeded(XmlDictionaryReader reader, int maxQuota) { }

	public static void ThrowMaxBytesPerReadExceeded(XmlDictionaryReader reader, int maxBytesPerRead) { }

	public static void ThrowMaxDepthExceeded(XmlDictionaryReader reader, int maxDepth) { }

	public static void ThrowMaxNameTableCharCountExceeded(XmlDictionaryReader reader, int maxNameTableCharCount) { }

	public static void ThrowMaxStringContentLengthExceeded(XmlDictionaryReader reader, int maxStringContentLength) { }

	public static void ThrowMultipleRootElements(XmlDictionaryReader reader) { }

	public static void ThrowProcessingInstructionNotSupported(XmlDictionaryReader reader) { }

	public static void ThrowStartElementExpected(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns) { }

	public static void ThrowStartElementExpected(XmlDictionaryReader reader, string localName, string ns) { }

	public static void ThrowStartElementExpected(XmlDictionaryReader reader, string name) { }

	public static void ThrowStartElementExpected(XmlDictionaryReader reader) { }

	public static void ThrowTagMismatch(XmlDictionaryReader reader, string expectedPrefix, string expectedLocalName, string foundPrefix, string foundLocalName) { }

	public static void ThrowTokenExpected(XmlDictionaryReader reader, string expected, char found) { }

	public static void ThrowTokenExpected(XmlDictionaryReader reader, string expected, string found) { }

	public static void ThrowUndefinedPrefix(XmlDictionaryReader reader, string prefix) { }

	public static void ThrowUnexpectedEndElement(XmlDictionaryReader reader) { }

	public static void ThrowUnexpectedEndOfFile(XmlDictionaryReader reader) { }

	public static void ThrowXmlDictionaryStringIDOutOfRange(XmlDictionaryReader reader) { }

	public static void ThrowXmlDictionaryStringIDUndefinedSession(XmlDictionaryReader reader, int key) { }

	public static void ThrowXmlDictionaryStringIDUndefinedStatic(XmlDictionaryReader reader, int key) { }

	private static void ThrowXmlException(XmlDictionaryReader reader, string res, string arg1) { }

	private static void ThrowXmlException(XmlDictionaryReader reader, string res, string arg1, string arg2, string arg3) { }

	private static void ThrowXmlException(XmlDictionaryReader reader, string res, string arg1, string arg2) { }

	public static void ThrowXmlException(XmlDictionaryReader reader, XmlException exception) { }

	private static void ThrowXmlException(XmlDictionaryReader reader, string res) { }

}

