namespace XeApp.Core;

public class LocalSaveData
{
	private enum CompressType
	{
		None = 0,
		GZip = 1,
		Deflate = 2,
	}

	private const int SAVE_FILE_NUM = 2; //Field offset: 0x0
	private const int HEADER_SIZE = 32; //Field offset: 0x0
	private const int OFFSET_SIG = 0; //Field offset: 0x0
	private const int OFFSET_VER = 4; //Field offset: 0x0
	private const int OFFSET_COMP = 6; //Field offset: 0x0
	private const int OFFSET_SIZE = 8; //Field offset: 0x0
	private const int OFFSET_COUNTER = 12; //Field offset: 0x0
	private const int OFFSET_HASH = 16; //Field offset: 0x0
	private bool firstSaved; //Field offset: 0x0
	private Byte[] swizzleTable; //Field offset: 0x0
	private String[] paths; //Field offset: 0x0
	public ContainerType data; //Field offset: 0x0
	private uint saveCounter; //Field offset: 0x0
	private ContainerType shadow; //Field offset: 0x0
	[CompilerGenerated]
	private bool <DontSave>k__BackingField; //Field offset: 0x0
	private string baseDir; //Field offset: 0x0
	[CompilerGenerated]
	private ulong <LastErrorValue>k__BackingField; //Field offset: 0x0

	public bool DontSave
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool Exists
	{
		 get { } //Length: 204
	}

	public private ulong LastErrorValue
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	private string physicalDir
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	public LocalSaveData`1() { }

	private Byte[] CalcHash(Byte[] bytes) { }

	private bool CheckHash(Byte[] hash, Byte[] bytes) { }

	private bool CheckHeader(ContainerType container, Byte[] bytes) { }

	public void DeleteSaveFile() { }

	[CompilerGenerated]
	public bool get_DontSave() { }

	public bool get_Exists() { }

	[CompilerGenerated]
	public ulong get_LastErrorValue() { }

	private string get_physicalDir() { }

	private string GetFilePath(int fileNo) { }

	public void Init(string dir, string baseName, uint randSeed) { }

	private SaveReturnCode Load(ContainerType container, int fileNo, out uint counter) { }

	public SaveReturnCode Load() { }

	private SaveReturnCode mount(bool isReadOnly) { }

	public void ResetToDefault() { }

	public SaveReturnCode Save() { }

	private SaveReturnCode Save(ContainerType container, int fileNo, uint saveCounter) { }

	[CompilerGenerated]
	public void set_DontSave(bool value) { }

	[CompilerGenerated]
	private void set_LastErrorValue(ulong value) { }

	private void set_physicalDir(string value) { }

	private void Swizzle(Byte[] body, int start) { }

	private void unmount() { }

}

