namespace XeApp.Core;

public class FlexibleLayoutCamera : MonoBehaviour
{
	[SerializeField]
	private List<Camera> flexibleViewportCameraList; //Field offset: 0x10
	[SerializeField]
	private List<Camera> flexibleFovCameraList; //Field offset: 0x14
	private List<Single> flexibleDefaultFovList; //Field offset: 0x18
	[SerializeField]
	private float baseWidth; //Field offset: 0x1C
	[SerializeField]
	private float baseHeight; //Field offset: 0x20
	private bool isEnableFov; //Field offset: 0x24
	private bool isEnableViewPort; //Field offset: 0x25

	public List<Camera> FlexibleFovCameraList
	{
		 get { } //Length: 11
	}

	public List<Camera> FlexibleViewportCameraList
	{
		 get { } //Length: 11
	}

	public bool IsEnableFov
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsEnableViewPort
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public FlexibleLayoutCamera() { }

	public void AddCamera(Camera camera, float fov) { }

	public void CameraListClear() { }

	private void FlexibleAspectProcess() { }

	private void FlexibleFovProcess() { }

	public List<Camera> get_FlexibleFovCameraList() { }

	public List<Camera> get_FlexibleViewportCameraList() { }

	public bool get_IsEnableFov() { }

	public bool get_IsEnableViewPort() { }

	public float GetDefaultFov(int cameraListIndex) { }

	private OverPermissionAspectResult GetOverPermissionAspectResult() { }

	private bool IsOverAspectHdivV() { }

	private bool IsOverAspectVdivH() { }

	private bool IsOverPermissionAspect() { }

	private bool IsPermissionAspect() { }

	public void set_IsEnableFov(bool value) { }

	public void set_IsEnableViewPort(bool value) { }

	public void SetDisable() { }

	public void SetEnable() { }

	private void Start() { }

	private void Update() { }

}

