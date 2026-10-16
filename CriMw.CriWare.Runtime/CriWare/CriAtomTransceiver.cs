namespace CriWare;

[AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
[DisallowMultipleComponent]
public class CriAtomTransceiver : CriMonoBehaviour
{
	private sealed class SetControlIdMethod : MulticastDelegate
	{

		public SetControlIdMethod(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ushort id, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ushort id) { }

	}

	[CompilerGenerated]
	private CriAtomEx3dTransceiver <transceiverHn>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <inputPos>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Vector3 <inputFront>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Vector3 <inputUp>k__BackingField; //Field offset: 0x3C
	[SerializeField]
	private CriAtomRegion regionOnStart; //Field offset: 0x48
	[SerializeField]
	private bool useDedicatedInput; //Field offset: 0x4C
	[SerializeField]
	private GameObject dedicatedInput; //Field offset: 0x50
	[Range(0, 1)]
	[SerializeField]
	private float outputVolume; //Field offset: 0x54
	[SerializeField]
	private float directAudioRadius; //Field offset: 0x58
	[SerializeField]
	private float crossFadeDistance; //Field offset: 0x5C
	[Range(0, 360)]
	[SerializeField]
	private float coneInsideAngle; //Field offset: 0x60
	[Range(0, 360)]
	[SerializeField]
	private float coneOutsideAngle; //Field offset: 0x64
	[Range(0, 1)]
	[SerializeField]
	private float coneOutsideVolume; //Field offset: 0x68
	[SerializeField]
	private float transceiverRadius; //Field offset: 0x6C
	[SerializeField]
	private float interiorDistance; //Field offset: 0x70
	[SerializeField]
	public float minAttenuation; //Field offset: 0x74
	[SerializeField]
	public float maxAttenuation; //Field offset: 0x78
	[SerializeField]
	private string globalAisacName; //Field offset: 0x7C
	[SerializeField]
	private float maxAngleAisacDelta; //Field offset: 0x80
	[SerializeField]
	private string distanceAisacControlId; //Field offset: 0x84
	[SerializeField]
	private string listenerAzimuthAisacControlId; //Field offset: 0x88
	[SerializeField]
	private string listenerElevationAisacControlId; //Field offset: 0x8C
	[SerializeField]
	private string outputAzimuthAisacControlId; //Field offset: 0x90
	[SerializeField]
	private string outputElevationAisacControlId; //Field offset: 0x94
	public bool inspectorAisacSettingFoldout; //Field offset: 0x98
	private bool isInitialized; //Field offset: 0x99
	private bool dedicatedInputNotSetWarned; //Field offset: 0x9A
	private CriAtomRegion currentRegion; //Field offset: 0x9C

	public private Vector3 inputFront
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 inputPos
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 inputUp
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public CriAtomRegion region3d
	{
		 get { } //Length: 14
		 set { } //Length: 583
	}

	public CriAtomEx3dTransceiver transceiverHn
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public CriAtomTransceiver() { }

	private void ApplyCurrentPosition() { }

	private void ApplyParameters() { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	[CompilerGenerated]
	public Vector3 get_inputFront() { }

	[CompilerGenerated]
	public Vector3 get_inputPos() { }

	[CompilerGenerated]
	public Vector3 get_inputUp() { }

	public CriAtomRegion get_region3d() { }

	[CompilerGenerated]
	public CriAtomEx3dTransceiver get_transceiverHn() { }

	protected override void InitializeParameters() { }

	protected override void InternalFinalize() { }

	protected override void InternalInitialize() { }

	private void OnDestroy() { }

	protected virtual void OnEnable() { }

	[CompilerGenerated]
	private void set_inputFront(Vector3 value) { }

	[CompilerGenerated]
	private void set_inputPos(Vector3 value) { }

	[CompilerGenerated]
	private void set_inputUp(Vector3 value) { }

	public void set_region3d(CriAtomRegion value) { }

	[CompilerGenerated]
	protected void set_transceiverHn(CriAtomEx3dTransceiver value) { }

	private void Start() { }

	private void TrySetAisacControlId(string strId, SetControlIdMethod callback) { }

}

