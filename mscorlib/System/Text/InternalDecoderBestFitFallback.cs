namespace System.Text;

internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	internal Encoding _encoding; //Field offset: 0x8
	internal Char[] _arrayBestFit; //Field offset: 0xC
	internal char _cReplacement; //Field offset: 0x10

	public virtual int MaxCharCount
	{
		 get { } //Length: 6
	}

	internal InternalDecoderBestFitFallback(Encoding encoding) { }

	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

}

