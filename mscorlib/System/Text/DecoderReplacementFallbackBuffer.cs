namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string _strDefault; //Field offset: 0x10
	private int _fallbackCount; //Field offset: 0x14
	private int _fallbackIndex; //Field offset: 0x18

	public virtual int Remaining
	{
		 get { } //Length: 21
	}

	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	public virtual void Reset() { }

}

