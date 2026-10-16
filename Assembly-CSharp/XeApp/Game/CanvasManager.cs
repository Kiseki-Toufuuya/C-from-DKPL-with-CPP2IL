namespace XeApp.Game;

public class CanvasManager
{
	private static CanvasManager m_Instance; //Field offset: 0x0
	private Transform m_CanvasParent; //Field offset: 0x8
	private Dictionary<Int32, Canvas> m_DicCanvas; //Field offset: 0xC
	private Dictionary<Int32, String> m_DicDefaultSortingLayerName; //Field offset: 0x10

	public static CanvasManager Instance
	{
		 get { } //Length: 40
	}

	public CanvasManager() { }

	public Canvas AddCanvas(int index, string name) { }

	public void ChangeCanvasIndex(Canvas canvas, int index) { }

	public static void Create(Canvas[] canvas_list = null) { }

	public void DeleteCanvas(int index) { }

	public static CanvasManager get_Instance() { }

	public Canvas GetCanvas(int index) { }

	private void InitAll(Canvas[] canvas_list) { }

	public bool IsRegistrationCanvas() { }

	public void SetCanvasCamera(int index, Camera camera) { }

	public void SetCanvasDefaultSortingLayerName(int index) { }

	public void SetDirty() { }

	public void SetIsUseSafeAreaScaling(int index, bool use) { }

	public void SetUICamera(Camera camera) { }

	public void Update() { }

}

