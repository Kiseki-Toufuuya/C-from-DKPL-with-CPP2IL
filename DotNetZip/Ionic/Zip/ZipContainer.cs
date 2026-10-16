namespace Ionic.Zip;

internal class ZipContainer
{
	private ZipFile _zf; //Field offset: 0x8
	private ZipOutputStream _zos; //Field offset: 0xC
	private ZipInputStream _zis; //Field offset: 0x10

	public Encoding AlternateEncoding
	{
		 get { } //Length: 41
	}

	public ZipOption AlternateEncodingUsage
	{
		 get { } //Length: 41
	}

	public int BufferSize
	{
		 get { } //Length: 91
	}

	public int CodecBufferSize
	{
		 get { } //Length: 46
	}

	public Encoding DefaultEncoding
	{
		 get { } //Length: 180
	}

	public int ParallelDeflateMaxBufferPairs
	{
		 get { } //Length: 40
	}

	public ParallelDeflateOutputStream ParallelDeflater
	{
		 get { } //Length: 50
		 set { } //Length: 81
	}

	public long ParallelDeflateThreshold
	{
		 get { } //Length: 49
	}

	public string Password
	{
		 get { } //Length: 51
	}

	public Stream ReadStream
	{
		 get { } //Length: 44
	}

	public CompressionStrategy Strategy
	{
		 get { } //Length: 37
	}

	public Zip64Option UseZip64WhenSaving
	{
		 get { } //Length: 40
	}

	public Zip64Option Zip64
	{
		 get { } //Length: 99
	}

	public ZipFile ZipFile
	{
		 get { } //Length: 11
	}

	public ZipOutputStream ZipOutputStream
	{
		 get { } //Length: 11
	}

	public ZipContainer(object o) { }

	public Encoding get_AlternateEncoding() { }

	public ZipOption get_AlternateEncodingUsage() { }

	public int get_BufferSize() { }

	public int get_CodecBufferSize() { }

	public Encoding get_DefaultEncoding() { }

	public int get_ParallelDeflateMaxBufferPairs() { }

	public ParallelDeflateOutputStream get_ParallelDeflater() { }

	public long get_ParallelDeflateThreshold() { }

	public string get_Password() { }

	public Stream get_ReadStream() { }

	public CompressionStrategy get_Strategy() { }

	public Zip64Option get_UseZip64WhenSaving() { }

	public Zip64Option get_Zip64() { }

	public ZipFile get_ZipFile() { }

	public ZipOutputStream get_ZipOutputStream() { }

	public void set_ParallelDeflater(ParallelDeflateOutputStream value) { }

}

