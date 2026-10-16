namespace System.Security.Cryptography;

public sealed class AesCcm : IDisposable
{

	public static KeySizes NonceByteSizes
	{
		 get { } //Length: 47
	}

	public static KeySizes TagByteSizes
	{
		 get { } //Length: 47
	}

	public AesCcm(Byte[] key) { }

	public AesCcm(ReadOnlySpan<Byte> key) { }

	public void Decrypt(Byte[] nonce, Byte[] ciphertext, Byte[] tag, Byte[] plaintext, Byte[] associatedData = null) { }

	public void Decrypt(ReadOnlySpan<Byte> nonce, ReadOnlySpan<Byte> ciphertext, ReadOnlySpan<Byte> tag, Span<Byte> plaintext, ReadOnlySpan<Byte> associatedData = null) { }

	public override void Dispose() { }

	public void Encrypt(Byte[] nonce, Byte[] plaintext, Byte[] ciphertext, Byte[] tag, Byte[] associatedData = null) { }

	public void Encrypt(ReadOnlySpan<Byte> nonce, ReadOnlySpan<Byte> plaintext, Span<Byte> ciphertext, Span<Byte> tag, ReadOnlySpan<Byte> associatedData = null) { }

	public static KeySizes get_NonceByteSizes() { }

	public static KeySizes get_TagByteSizes() { }

}

