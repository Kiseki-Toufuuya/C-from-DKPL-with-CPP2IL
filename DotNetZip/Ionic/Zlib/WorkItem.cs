namespace Ionic.Zlib;

internal class WorkItem
{
	public Byte[] buffer; //Field offset: 0x8
	public Byte[] compressed; //Field offset: 0xC
	public int crc; //Field offset: 0x10
	public int index; //Field offset: 0x14
	public int ordinal; //Field offset: 0x18
	public int inputBytesAvailable; //Field offset: 0x1C
	public int compressedBytesAvailable; //Field offset: 0x20
	public ZlibCodec compressor; //Field offset: 0x24

	public WorkItem(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix) { }

}

