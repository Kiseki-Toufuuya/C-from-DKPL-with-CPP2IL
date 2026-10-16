namespace CriWare;

[AddComponentMenu("CRIWARE/CRI Atom Listener")]
public class CriAtomListener : CriMonoBehaviour
{
	private static List<CriAtomListener> listenersList; //Field offset: 0x0
	private static CriAtomListener exclusiveListener; //Field offset: 0x4
	private static CriAtomEx3dListener dummyNativeListener; //Field offset: 0x8
	[CompilerGenerated]
	private CriAtomEx3dListener <nativeListener>k__BackingField; //Field offset: 0x20
	[SerializeField]
	private CriAtomRegion regionOnStart; //Field offset: 0x24
	public bool activateListenerOnEnable; //Field offset: 0x28
	private Vector3 lastPosition; //Field offset: 0x2C
	private CriAtomRegion currentRegion; //Field offset: 0x38
	private bool _isActive; //Field offset: 0x3C

	internal static CriAtomEx3dListener DummyNativeListener
	{
		internal get { } //Length: 61
	}

	public bool isActive
	{
		 get { } //Length: 11
		 set { } //Length: 106
	}

	public CriAtomEx3dListener nativeListener
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public CriAtomRegion region3d
	{
		 get { } //Length: 11
		 set { } //Length: 562
	}

	private static CriAtomListener() { }

	public CriAtomListener() { }

	public void ActivateListener(bool exclusive = true) { }

	private void Awake() { }

	public static void CreateDummyNativeListener() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public static void DestroyDummyNativeListener() { }

	internal static CriAtomEx3dListener get_DummyNativeListener() { }

	public bool get_isActive() { }

	[CompilerGenerated]
	public CriAtomEx3dListener get_nativeListener() { }

	public CriAtomRegion get_region3d() { }

	private void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_isActive(bool value) { }

	[CompilerGenerated]
	protected void set_nativeListener(CriAtomEx3dListener value) { }

	public void set_region3d(CriAtomRegion value) { }

	private void Start() { }

	private void UpdatePosition() { }

}

