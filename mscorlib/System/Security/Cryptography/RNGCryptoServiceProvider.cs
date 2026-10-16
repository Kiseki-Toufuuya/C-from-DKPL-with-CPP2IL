namespace System.Security.Cryptography;

public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	private static object _lock; //Field offset: 0x0
	private IntPtr _handle; //Field offset: 0x8

	private static RNGCryptoServiceProvider() { }

	public RNGCryptoServiceProvider() { }

	public RNGCryptoServiceProvider(Byte[] rgb) { }

	public RNGCryptoServiceProvider(CspParameters cspParams) { }

	public RNGCryptoServiceProvider(string str) { }

	private void Check() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public virtual void GetBytes(Byte[] data) { }

	internal void GetBytes(Byte* data, IntPtr data_length) { }

	public virtual void GetNonZeroBytes(Byte[] data) { }

	private static void RngClose(IntPtr handle) { }

	private static IntPtr RngGetBytes(IntPtr handle, Byte* data, IntPtr data_length) { }

	private static IntPtr RngInitialize(Byte* seed, IntPtr seed_length) { }

	private static bool RngOpen() { }

}

