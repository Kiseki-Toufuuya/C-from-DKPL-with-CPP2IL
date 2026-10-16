namespace System.Text;

internal class InternalEncoderBestFitFallback : EncoderFallback
{
	internal Encoding _encoding; //Field offset: 0x8
	internal Char[] _arrayBestFit; //Field offset: 0xC

	public virtual int MaxCharCount
	{
		 get { } //Length: 6
	}

	internal InternalEncoderBestFitFallback(Encoding encoding) { }

	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

}

