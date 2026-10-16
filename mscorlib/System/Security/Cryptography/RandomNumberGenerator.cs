namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable
{

	protected RandomNumberGenerator() { }

	public static RandomNumberGenerator Create() { }

	public static RandomNumberGenerator Create(string rngName) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public static void Fill(Span<Byte> data) { }

	internal static void FillSpan(Span<Byte> data) { }

	public abstract void GetBytes(Byte[] data) { }

	public override void GetBytes(Byte[] data, int offset, int count) { }

	public override void GetBytes(Span<Byte> data) { }

	public static int GetInt32(int fromInclusive, int toExclusive) { }

	public static int GetInt32(int toExclusive) { }

	public override void GetNonZeroBytes(Byte[] data) { }

	public override void GetNonZeroBytes(Span<Byte> data) { }

}

