namespace Ionic.Zlib;

[ClassInterface(ClassInterfaceType::AutoDispatch (1))]
[ComVisible(True)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
public sealed class ZlibCodec
{
	public Byte[] InputBuffer; //Field offset: 0x8
	public int NextIn; //Field offset: 0xC
	public int AvailableBytesIn; //Field offset: 0x10
	public long TotalBytesIn; //Field offset: 0x18
	public Byte[] OutputBuffer; //Field offset: 0x20
	public int NextOut; //Field offset: 0x24
	public int AvailableBytesOut; //Field offset: 0x28
	public long TotalBytesOut; //Field offset: 0x30
	public string Message; //Field offset: 0x38
	internal DeflateManager dstate; //Field offset: 0x3C
	internal InflateManager istate; //Field offset: 0x40
	internal uint _Adler32; //Field offset: 0x44
	public CompressionLevel CompressLevel; //Field offset: 0x48
	public int WindowBits; //Field offset: 0x4C
	public CompressionStrategy Strategy; //Field offset: 0x50

	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	public ZlibCodec() { }

	public int Deflate(FlushType flush) { }

	public int EndDeflate() { }

	public int EndInflate() { }

	internal void flush_pending() { }

	public int Inflate(FlushType flush) { }

	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	public int InitializeInflate(bool expectRfc1950Header) { }

	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	internal int read_buf(Byte[] buf, int start, int size) { }

	public void ResetDeflate() { }

}

