namespace Mono.Security.Cryptography;

internal sealed class CryptoConvert
{

	public static RSA FromCapiKeyBlob(Byte[] blob, int offset) { }

	public static RSA FromCapiKeyBlob(Byte[] blob) { }

	public static DSA FromCapiKeyBlobDSA(Byte[] blob, int offset) { }

	public static DSA FromCapiKeyBlobDSA(Byte[] blob) { }

	public static RSA FromCapiPrivateKeyBlob(Byte[] blob, int offset) { }

	public static DSA FromCapiPrivateKeyBlobDSA(Byte[] blob, int offset) { }

	public static RSA FromCapiPublicKeyBlob(Byte[] blob, int offset) { }

	public static DSA FromCapiPublicKeyBlobDSA(Byte[] blob, int offset) { }

	private static Byte[] GetBytesLE(int val) { }

	private static RSAParameters GetParametersFromCapiPrivateKeyBlob(Byte[] blob, int offset) { }

	private static RSAParameters GetParametersFromCapiPublicKeyBlob(Byte[] blob, int offset) { }

	public static Byte[] ToCapiPrivateKeyBlob(DSA dsa) { }

	public static Byte[] ToCapiPrivateKeyBlob(RSA rsa) { }

	public static Byte[] ToCapiPublicKeyBlob(RSA rsa) { }

	public static Byte[] ToCapiPublicKeyBlob(DSA dsa) { }

	private static int ToInt32LE(Byte[] bytes, int offset) { }

	private static uint ToUInt32LE(Byte[] bytes, int offset) { }

	private static Byte[] Trim(Byte[] array) { }

}

