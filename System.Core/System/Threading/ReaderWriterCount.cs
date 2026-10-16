namespace System.Threading;

internal class ReaderWriterCount
{
	public long lockID; //Field offset: 0x8
	public int readercount; //Field offset: 0x10
	public int writercount; //Field offset: 0x14
	public int upgradecount; //Field offset: 0x18
	public ReaderWriterCount next; //Field offset: 0x1C

	public ReaderWriterCount() { }

}

