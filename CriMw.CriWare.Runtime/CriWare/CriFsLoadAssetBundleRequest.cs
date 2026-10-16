namespace CriWare;

public class CriFsLoadAssetBundleRequest : CriFsRequest
{
	[CompilerGenerated]
	private string <path>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AssetBundle <assetBundle>k__BackingField; //Field offset: 0x2C
	private CriFsLoadFileRequest loadFileReq; //Field offset: 0x30
	private AssetBundleCreateRequest assetBundleReq; //Field offset: 0x34

	public private AssetBundle assetBundle
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private string path
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize) { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public AssetBundle get_assetBundle() { }

	[CompilerGenerated]
	public string get_path() { }

	[CompilerGenerated]
	private void set_assetBundle(AssetBundle value) { }

	[CompilerGenerated]
	private void set_path(string value) { }

	public virtual void Update() { }

}

