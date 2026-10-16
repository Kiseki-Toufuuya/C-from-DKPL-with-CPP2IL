namespace System.Text;

public abstract class EncoderFallback
{
	private static EncoderFallback s_replacementFallback; //Field offset: 0x0
	private static EncoderFallback s_exceptionFallback; //Field offset: 0x4

	public static EncoderFallback ExceptionFallback
	{
		 get { } //Length: 112
	}

	public abstract int MaxCharCount
	{
		 get { } //Length: 0
	}

	public static EncoderFallback ReplacementFallback
	{
		 get { } //Length: 144
	}

	protected EncoderFallback() { }

	public abstract EncoderFallbackBuffer CreateFallbackBuffer() { }

	public static EncoderFallback get_ExceptionFallback() { }

	public abstract int get_MaxCharCount() { }

	public static EncoderFallback get_ReplacementFallback() { }

}

