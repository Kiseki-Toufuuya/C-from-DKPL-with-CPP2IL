namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class MaskGenerationMethod
{

	protected MaskGenerationMethod() { }

	[ComVisible(True)]
	public abstract Byte[] GenerateMask(Byte[] rgbSeed, int cbReturn) { }

}

