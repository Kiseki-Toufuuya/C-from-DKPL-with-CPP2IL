namespace Ionic.BZip2;

internal class BitWriter
{
	private uint accumulator; //Field offset: 0x8
	private int nAccumulatedBits; //Field offset: 0xC
	private Stream output; //Field offset: 0x10
	private int totalBytesWrittenOut; //Field offset: 0x14

	public int NumRemainingBits
	{
		 get { } //Length: 11
	}

	public byte RemainingBits
	{
		 get { } //Length: 21
	}

	public int TotalBytesWrittenOut
	{
		 get { } //Length: 11
	}

	public BitWriter(Stream s) { }

	public void FinishAndPad() { }

	public void Flush() { }

	public int get_NumRemainingBits() { }

	public byte get_RemainingBits() { }

	public int get_TotalBytesWrittenOut() { }

	public void Reset() { }

	public void WriteBits(int nbits, uint value) { }

	public void WriteByte(byte b) { }

	public void WriteInt(uint u) { }

}

