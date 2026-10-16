namespace XeApp.Game.Net;

public class EncryptorManager
{
	public const int EMBEDED_AES_KEY = 1001; //Field offset: 0x0
	public const int EMBEDED_ASSETBUNDLE_KEY = 1002; //Field offset: 0x0
	public const int EMBEDED_DAT_KEY = 1003; //Field offset: 0x0
	public const int EMBEDED_FILELIST_KEY = 1004; //Field offset: 0x0
	public const int DEFAULT_KEY = 1501; //Field offset: 0x0
	public const int DOWNLOAD_ASSETBUNDLE_KEY_1 = 2001; //Field offset: 0x0
	public const int DOWNLOAD_DAT_KEY = 2002; //Field offset: 0x0
	public const int DOWNLOAD_DB_KEY = 2003; //Field offset: 0x0
	[CompilerGenerated]
	private static EncryptorManager <Instance>k__BackingField; //Field offset: 0x0
	private Dictionary<Int32, ICustomEncryptor> DecryptorMap; //Field offset: 0x8

	public private static EncryptorManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public EncryptorManager() { }

	[CompilerGenerated]
	public static EncryptorManager get_Instance() { }

	public ICustomEncryptor GetDecryptor(int key) { }

	public void Init() { }

	[CompilerGenerated]
	private static void set_Instance(EncryptorManager value) { }

}

