namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(Transform), False)]
[DisplayName("Transform", null)]
public class TrackedTransform : TrackedObject
{
	private Vector3 m_PositionToApply; //Field offset: 0x14
	private Quaternion m_RotationToApply; //Field offset: 0x20
	private Vector3 m_ScaleToApply; //Field offset: 0x30
	private Dictionary<String, Action`1<Single>> m_PropertyHandlers; //Field offset: 0x3C

	public TrackedTransform() { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_0(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_1(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_2(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_3(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_4(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_5(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_6(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_7(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_8(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__4_9(float val) { }

	protected override void AddPropertyHandlers(Dictionary<String, Action`1<Single>> handlers) { }

	public virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	public virtual bool CanTrackProperty(string propertyPath) { }

}

