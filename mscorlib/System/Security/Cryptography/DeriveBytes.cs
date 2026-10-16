namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class DeriveBytes : IDisposable
{

	protected DeriveBytes() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract Byte[] GetBytes(int cb) { }

	public abstract void Reset() { }

}

