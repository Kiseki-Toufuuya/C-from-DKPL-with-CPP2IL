namespace System.Xml;

internal class MtomBinaryData
{
	internal MtomBinaryDataType type; //Field offset: 0x8
	internal IStreamProvider provider; //Field offset: 0xC
	internal Byte[] chunk; //Field offset: 0x10

	internal long Length
	{
		internal get { } //Length: 37
	}

	internal MtomBinaryData(IStreamProvider provider) { }

	internal MtomBinaryData(Byte[] buffer, int offset, int count) { }

	internal long get_Length() { }

}

