namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
{
	private bool m_disposed; //Field offset: 0x8

	public override bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 3
	}

	public IntPtr KeyHandle
	{
		 get { } //Length: 3
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 3
	}

	internal CryptoAPITransform() { }

	public void Clear() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public override bool get_CanReuseTransform() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	public IntPtr get_KeyHandle() { }

	public override int get_OutputBlockSize() { }

	[ComVisible(False)]
	public void Reset() { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

