namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(RectTransform), False)]
[DisplayName("Rect Transform", null)]
public class TrackedRectTransform : TrackedTransform
{
	private Vector3 m_AnchorPosToApply; //Field offset: 0x40
	private Vector2 m_AnchorMinToApply; //Field offset: 0x4C
	private Vector2 m_AnchorMaxToApply; //Field offset: 0x54
	private Vector2 m_PivotToApply; //Field offset: 0x5C
	private Vector2 m_SizeDeltaToApply; //Field offset: 0x64

	public TrackedRectTransform() { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_0(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_1(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_10(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_2(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_3(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_4(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_5(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_6(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_7(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_8(float val) { }

	[CompilerGenerated]
	private void <AddPropertyHandlers>b__5_9(float val) { }

	protected virtual void AddPropertyHandlers(Dictionary<String, Action`1<Single>> handlers) { }

	public virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

}

