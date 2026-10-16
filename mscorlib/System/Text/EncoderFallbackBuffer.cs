namespace System.Text;

public abstract class EncoderFallbackBuffer
{
	internal Char* charStart; //Field offset: 0x8
	internal Char* charEnd; //Field offset: 0xC
	internal EncoderNLS encoder; //Field offset: 0x10
	internal bool setEncoder; //Field offset: 0x14
	internal bool bUsedEncoder; //Field offset: 0x15
	internal bool bFallingBack; //Field offset: 0x16
	internal int iRecursionCount; //Field offset: 0x18

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	protected EncoderFallbackBuffer() { }

	public abstract bool Fallback(char charUnknown, int index) { }

	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	internal override bool InternalFallback(char ch, ref Char* chars) { }

	internal char InternalGetNextChar() { }

	internal void InternalInitialize(Char* charStart, Char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	internal void InternalReset() { }

	public abstract bool MovePrevious() { }

	public override void Reset() { }

	internal void ThrowLastCharRecursive(int charRecursive) { }

}

