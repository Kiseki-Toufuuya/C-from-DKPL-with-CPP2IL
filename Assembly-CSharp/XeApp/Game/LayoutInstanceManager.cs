namespace XeApp.Game;

public class LayoutInstanceManager : Singleton<LayoutInstanceManager>, IDisposable
{
	private class LayoutInstance
	{
		private GameObject m_Root; //Field offset: 0x8
		private uGUILayoutBase m_Layout; //Field offset: 0xC
		private uGUIScreenRotateLayoutsBase m_RotLayout; //Field offset: 0x10
		private int m_LayoutIndex; //Field offset: 0x14
		private bool m_IsExistLayout; //Field offset: 0x18
		private bool m_IsRotateLayout; //Field offset: 0x19
		private LayoutInstance m_GroupInstance; //Field offset: 0x1C
		private bool m_IsLandscape; //Field offset: 0x20

		public LayoutInstance GroupInstance
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public bool IsExistLayout
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsLandscape
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsRotateLayout
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public uGUILayoutBase Layout
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public int LayoutIndex
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public GameObject Root
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public uGUIScreenRotateLayoutsBase RotLayout
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public LayoutInstance() { }

		public LayoutInstance get_GroupInstance() { }

		public bool get_IsExistLayout() { }

		public bool get_IsLandscape() { }

		public bool get_IsRotateLayout() { }

		public uGUILayoutBase get_Layout() { }

		public int get_LayoutIndex() { }

		public GameObject get_Root() { }

		public uGUIScreenRotateLayoutsBase get_RotLayout() { }

		public void set_GroupInstance(LayoutInstance value) { }

		public void set_IsExistLayout(bool value) { }

		public void set_IsLandscape(bool value) { }

		public void set_IsRotateLayout(bool value) { }

		public void set_Layout(uGUILayoutBase value) { }

		public void set_LayoutIndex(int value) { }

		public void set_Root(GameObject value) { }

		public void set_RotLayout(uGUIScreenRotateLayoutsBase value) { }

	}

	private class RequestData
	{
		private string m_AssetBundleName; //Field offset: 0x8
		private string m_AssetName; //Field offset: 0xC
		private int m_InstanceIdx; //Field offset: 0x10
		private bool m_IsLoaded; //Field offset: 0x14
		private bool m_IsInit; //Field offset: 0x15
		private Transform m_Parent; //Field offset: 0x18
		private RequestData m_GroupRequest; //Field offset: 0x1C

		public string AssetBundleName
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string AssetName
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public RequestData GroupRequest
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public int InstanceIdx
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsInit
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsLoaded
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public Transform ParentTransform
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public RequestData() { }

		public string get_AssetBundleName() { }

		public string get_AssetName() { }

		public RequestData get_GroupRequest() { }

		public int get_InstanceIdx() { }

		public bool get_IsInit() { }

		public bool get_IsLoaded() { }

		public Transform get_ParentTransform() { }

		public void OnInited() { }

		public void OnLoaded(AssetBundleLoadAssetOperation data) { }

		public void set_AssetBundleName(string value) { }

		public void set_AssetName(string value) { }

		public void set_GroupRequest(RequestData value) { }

		public void set_InstanceIdx(int value) { }

		public void set_IsInit(bool value) { }

		public void set_IsLoaded(bool value) { }

		public void set_ParentTransform(Transform value) { }

	}

	private static int m_LayoutInstanceIndex; //Field offset: 0x0
	private List<RequestData> m_RequestList; //Field offset: 0x8
	private Dictionary<String, List`1<LayoutInstance>> m_InstanceDic; //Field offset: 0xC
	private bool m_IsLoading; //Field offset: 0x10

	public bool IsLoading
	{
		 get { } //Length: 11
	}

	public LayoutInstanceManager() { }

	private RequestData AddRequestData(string assetBundleName, string assetName, int idx, Transform parent = null) { }

	public List<AssetBundleLoadAllAssetOperationBase> Begin(int idx) { }

	public void BeginAsset(int idx) { }

	public bool ChkResourceAllLoad() { }

	public bool ChkResourceLoad(string assetBundleName) { }

	private int CreateLayoutInstance(string assetBundleName, out LayoutInstance instance) { }

	public void DestroyUnload(string assetBundleName, int idx = -1) { }

	public override void Dispose() { }

	public bool get_IsLoading() { }

	private LayoutInstance GetLayoutInstance(string assetBundleName, int idx) { }

	public GameObject GetLayoutObject(string assetBundleName, int idx) { }

	private void OnInited(RequestData request) { }

	private void OnLoaded(AssetBundleLoadAssetOperation operation, RequestData request) { }

	public int Request(string assetBundleName, string assetName, uGUILayoutBase layout_base, uGUIScreenRotateLayoutsBase rot_layout, Transform parent = null) { }

	public int Request(string assetBundleName, string assetName, uGUILayoutBase ugui_layout, Transform parent = null) { }

	public int Request(string assetBundleName, string assetName, Transform parent = null) { }

	public int Request(string assetBundleName, string assetName, uGUIScreenRotateLayoutsBase rot_layout, Transform parent = null) { }

	public void SetRootAddress(Func<String> prefab, Func<String> texpack, Func<String> font) { }

}

