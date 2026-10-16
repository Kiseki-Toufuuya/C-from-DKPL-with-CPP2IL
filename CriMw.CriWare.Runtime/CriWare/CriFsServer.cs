namespace CriWare;

public class CriFsServer : CriMonoBehaviour
{
	private static CriFsServer _instance; //Field offset: 0x0
	private List<CriFsRequest> requestList; //Field offset: 0x20
	[CompilerGenerated]
	private int <installBufferSize>k__BackingField; //Field offset: 0x24

	public private int installBufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public static CriFsServer instance
	{
		 get { } //Length: 50
	}

	public CriFsServer() { }

	public void AddRequest(CriFsRequest request) { }

	private void Awake() { }

	public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) { }

	public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) { }

	public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) { }

	public static void CreateInstance() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public static void DestroyInstance() { }

	[CompilerGenerated]
	public int get_installBufferSize() { }

	public static CriFsServer get_instance() { }

	[Obsolete("CriFsServer.Install is no longer working. Use CriFsServer.WebInstall instead.")]
	public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate) { }

	public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize) { }

	public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, DoneDelegate doneDelegate, int readUnitSize) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private void set_installBufferSize(int value) { }

	public CriFsInstallRequest WebInstall(string srcPath, string dstPath, DoneDelegate doneDelegate) { }

}

