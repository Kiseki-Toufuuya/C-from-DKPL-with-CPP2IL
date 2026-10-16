namespace CriWare;

public class CriFsBinder : CriDisposable
{
	internal struct ContentsFileInfo
	{
		public readonly string directory; //Field offset: 0x0
		public readonly string fileName; //Field offset: 0x4
		public uint readSize; //Field offset: 0x8
		public uint extractSize; //Field offset: 0xC
		public ulong offset; //Field offset: 0x10
		public int fileId; //Field offset: 0x18
		private string userStr; //Field offset: 0x1C

		public ContentsFileInfo(Byte[] data, int startIndex) { }

	}

	internal enum Status
	{
		None = 0,
		Analyze = 1,
		Complete = 2,
		Unbind = 3,
		Removed = 4,
		Invalid = 5,
		Error = 6,
	}

	private IntPtr handle; //Field offset: 0x18

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriFsBinder() { }

	public uint BindCpk(CriFsBinder srcBinder, string path) { }

	public uint BindDirectory(CriFsBinder srcBinder, string path) { }

	public uint BindFile(CriFsBinder srcBinder, string path) { }

	public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName) { }

	private static uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { }

	private static uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { }

	private static uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId) { }

	private static uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId) { }

	private static uint criFsBinder_Create(out IntPtr binder) { }

	private static uint criFsBinder_Destroy(IntPtr binder) { }

	private static int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info) { }

	private static int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info) { }

	private static int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num) { }

	private static int criFsBinder_GetFileSize(IntPtr binder, string path, out long size) { }

	private static int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size) { }

	private static int criFsBinder_GetStatus(uint bindId, out Status status) { }

	private static int criFsBinder_SetPriority(uint bindId, int priority) { }

	private static int criFsBinder_Unbind(uint bindId) { }

	private static int CRIWAREA67DB48D(uint id) { }

	private void Dispose(bool disposing) { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public bool GetContentsFileInfo(int id, out ContentsFileInfo info) { }

	public bool GetContentsFileInfo(string path, out ContentsFileInfo info) { }

	public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info) { }

	public long GetFileSize(int id) { }

	public long GetFileSize(string path) { }

	public static int GetNumContentsFiles(uint bindId) { }

	public static Status GetStatus(uint bindId) { }

	public static void SetPriority(uint bindId, int priority) { }

	public static void Unbind(uint bindId) { }

}

