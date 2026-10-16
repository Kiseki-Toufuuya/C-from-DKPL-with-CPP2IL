namespace CriWare;

[AddComponentMenu("CRIWARE/CRI Atom Region")]
[DisallowMultipleComponent]
public class CriAtomRegion : CriMonoBehaviour
{
	[CompilerGenerated]
	private CriAtomEx3dRegion <region3dHn>k__BackingField; //Field offset: 0x20
	internal List<CriAtomSourceBase> referringSources; //Field offset: 0x24
	internal List<CriAtomListener> referringListeners; //Field offset: 0x28
	internal List<CriAtomTransceiver> referringTransceivers; //Field offset: 0x2C

	public CriAtomEx3dRegion region3dHn
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public CriAtomRegion() { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	[CompilerGenerated]
	public CriAtomEx3dRegion get_region3dHn() { }

	protected override void InitializeParameters() { }

	protected override void InternalFinalize() { }

	protected override void InternalInitialize() { }

	private void OnDestroy() { }

	protected virtual void OnEnable() { }

	[CompilerGenerated]
	protected void set_region3dHn(CriAtomEx3dRegion value) { }

}

