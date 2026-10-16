namespace System.Security.Cryptography;

[ComVisible(True)]
public class FromBase64Transform : ICryptoTransform, IDisposable
{
	private Byte[] _inputBuffer; //Field offset: 0x8
	private int _inputIndex; //Field offset: 0xC
	private FromBase64TransformMode _whitespaces; //Field offset: 0x10

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
		 get { } //Length: 6
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 6
	}

	public FromBase64Transform() { }

	public FromBase64Transform(FromBase64TransformMode whitespaces) { }

	public void Clear() { }

	private Byte[] DiscardWhiteSpaces(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public override bool get_CanReuseTransform() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	private void Reset() { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

