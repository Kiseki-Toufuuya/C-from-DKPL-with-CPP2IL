namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	private bool _disposed; //Field offset: 0x8
	protected int HashSizeValue; //Field offset: 0xC
	protected private Byte[] HashValue; //Field offset: 0x10
	protected int State; //Field offset: 0x14

	public override bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override Byte[] Hash
	{
		 get { } //Length: 219
	}

	public override int HashSize
	{
		 get { } //Length: 11
	}

	public override int InputBlockSize
	{
		 get { } //Length: 6
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 6
	}

	protected HashAlgorithm() { }

	private Byte[] CaptureHashCodeAndReinitialize() { }

	public void Clear() { }

	public Byte[] ComputeHash(Byte[] buffer) { }

	public Byte[] ComputeHash(Byte[] buffer, int offset, int count) { }

	public Byte[] ComputeHash(Stream inputStream) { }

	public static HashAlgorithm Create() { }

	public static HashAlgorithm Create(string hashName) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override bool get_CanReuseTransform() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override Byte[] get_Hash() { }

	public override int get_HashSize() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	protected override void HashCore(ReadOnlySpan<Byte> source) { }

	protected abstract void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected abstract Byte[] HashFinal() { }

	public abstract void Initialize() { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	public bool TryComputeHash(ReadOnlySpan<Byte> source, Span<Byte> destination, out int bytesWritten) { }

	protected override bool TryHashFinal(Span<Byte> destination, out int bytesWritten) { }

	private void ValidateTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

