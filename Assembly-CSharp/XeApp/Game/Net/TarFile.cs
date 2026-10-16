namespace XeApp.Game.Net;

public class TarFile : IDataStorage
{
	private const int BLOCK_SIZE = 512; //Field offset: 0x0
	public Dictionary<String, Byte[]> Files; //Field offset: 0x8

	public TarFile(string path, int decryptorKey) { }

	public TarFile(Byte[] bytes, int decryptorKey) { }

	private Byte[] CopyFileImage(Byte[] rawBytes, int offset) { }

	private void CopyStream(Stream src, Stream dest) { }

	private Byte[] Decrypt(Byte[] encBytes, int decryptKey) { }

	public override Byte[] Get(LocalStorageKey path) { }

	private int GetDataBlockSize(Byte[] rawBytes, int offset) { }

	private int GetDataSize(Byte[] rawBytes, int offset) { }

	private string GetFileName(Byte[] rawBytes, int offset) { }

	public static bool IsGzip(Byte[] bytes) { }

	private bool IsRecularFile(Byte[] rawBytes, int offset) { }

	public void Load(string path, int decryptorKey) { }

	public void Load(Byte[] fileImage, int decryptorKey) { }

	public void LoadFromResource(string path, int decryptorKey) { }

	private void Uncomp(Byte[] dataBytes, Byte[] rawBytes) { }

}

