namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
public struct LensSettings
{
	internal enum OverrideModes
	{
		None = 0,
		Orthographic = 1,
		Perspective = 2,
		Physical = 3,
	}

	public static LensSettings Default; //Field offset: 0x0
	[Range(1, 179)]
	[Tooltip("This is the camera view in degrees. Display will be in vertical degress, unless the associated camera has its FOV axis setting set to Horizontal, in which case display will be in horizontal degress.  Internally, it is always vertical degrees.  For cinematic people, a 50mm lens on a super-35mm sensor would equal a 19.6 degree FOV")]
	public float FieldOfView; //Field offset: 0x0
	[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
	public float OrthographicSize; //Field offset: 0x4
	[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
	public float NearClipPlane; //Field offset: 0x8
	[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
	public float FarClipPlane; //Field offset: 0xC
	[Range(-180, 180)]
	[Tooltip("Camera Z roll, or tilt, in degrees.")]
	public float Dutch; //Field offset: 0x10
	[Tooltip("Allows you to select a different camera mode to apply to the Camera component when Cinemachine activates this Virtual Camera.  The changes applied to the Camera component through this setting will remain after the Virtual Camera deactivation.")]
	public OverrideModes ModeOverride; //Field offset: 0x14
	public Vector2 LensShift; //Field offset: 0x18
	public GateFitMode GateFit; //Field offset: 0x20
	public float FocusDistance; //Field offset: 0x24
	[SerializeField]
	private Vector2 m_SensorSize; //Field offset: 0x28
	private bool m_OrthoFromCamera; //Field offset: 0x30
	private bool m_PhysicalFromCamera; //Field offset: 0x31

	public float Aspect
	{
		 get { } //Length: 131
	}

	public bool IsPhysicalCamera
	{
		 get { } //Length: 31
		 set { } //Length: 23
	}

	public bool Orthographic
	{
		 get { } //Length: 31
		 set { } //Length: 24
	}

	public Vector2 SensorSize
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	private static LensSettings() { }

	public LensSettings(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch) { }

	public static LensSettings FromCamera(Camera fromCamera) { }

	public float get_Aspect() { }

	public bool get_IsPhysicalCamera() { }

	public bool get_Orthographic() { }

	public Vector2 get_SensorSize() { }

	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) { }

	public void set_IsPhysicalCamera(bool value) { }

	public void set_Orthographic(bool value) { }

	public void set_SensorSize(Vector2 value) { }

	public void SnapshotCameraReadOnlyProperties(Camera camera) { }

	public void SnapshotCameraReadOnlyProperties(ref LensSettings lens) { }

	public void Validate() { }

}

