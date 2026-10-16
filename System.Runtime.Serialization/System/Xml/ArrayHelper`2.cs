namespace System.Xml;

internal abstract class ArrayHelper
{

	protected ArrayHelper`2() { }

	public TArray[] ReadArray(XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, int maxArrayLength) { }

	protected abstract int ReadArray(XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count) { }

	public void WriteArray(XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, XmlDictionaryReader reader) { }

	protected abstract void WriteArray(XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count) { }

}

