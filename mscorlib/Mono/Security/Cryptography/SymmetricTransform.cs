namespace Mono.Security.Cryptography;

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	protected SymmetricAlgorithm algo; //Field offset: 0x8
	protected bool encrypt; //Field offset: 0xC
	protected int BlockSizeByte; //Field offset: 0x10
	protected Byte[] temp; //Field offset: 0x14
	protected Byte[] temp2; //Field offset: 0x18
	private Byte[] workBuff; //Field offset: 0x1C
	private Byte[] workout; //Field offset: 0x20
	protected PaddingMode padmode; //Field offset: 0x24
	protected int FeedBackByte; //Field offset: 0x28
	private bool m_disposed; //Field offset: 0x2C
	protected bool lastBlock; //Field offset: 0x2D
	private RandomNumberGenerator _rng; //Field offset: 0x30

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
		 get { } //Length: 11
	}

	private bool KeepLastBlock
	{
		private get { } //Length: 31
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 11
	}

	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] rgbIV) { }

	protected override void CBC(Byte[] input, Byte[] output) { }

	protected override void CFB(Byte[] input, Byte[] output) { }

	private void CheckInput(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override void CTS(Byte[] input, Byte[] output) { }

	protected override void Dispose(bool disposing) { }

	protected abstract void ECB(Byte[] input, Byte[] output) { }

	protected override Byte[] FinalDecrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override Byte[] FinalEncrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual void Finalize() { }

	public override bool get_CanReuseTransform() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	private bool get_KeepLastBlock() { }

	public override int get_OutputBlockSize() { }

	private int InternalTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	protected override void OFB(Byte[] input, Byte[] output) { }

	private void Random(Byte[] buffer, int start, int length) { }

	private override void System.IDisposable.Dispose() { }

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	protected override void Transform(Byte[] input, Byte[] output) { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

