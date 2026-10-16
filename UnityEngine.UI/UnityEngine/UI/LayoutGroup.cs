namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	[CompilerGenerated]
	private sealed class <DelayedSetDirty>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RectTransform rectTransform; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <DelayedSetDirty>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	protected RectOffset m_Padding; //Field offset: 0x10
	[SerializeField]
	protected TextAnchor m_ChildAlignment; //Field offset: 0x14
	private RectTransform m_Rect; //Field offset: 0x18
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x1C
	private Vector2 m_TotalMinSize; //Field offset: 0x20
	private Vector2 m_TotalPreferredSize; //Field offset: 0x28
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x30
	private List<RectTransform> m_RectChildren; //Field offset: 0x38

	public TextAnchor childAlignment
	{
		 get { } //Length: 11
		 set { } //Length: 59
	}

	public override float flexibleHeight
	{
		 get { } //Length: 17
	}

	public override float flexibleWidth
	{
		 get { } //Length: 17
	}

	private bool isRootLayoutGroup
	{
		private get { } //Length: 250
	}

	public override int layoutPriority
	{
		 get { } //Length: 3
	}

	public override float minHeight
	{
		 get { } //Length: 17
	}

	public override float minWidth
	{
		 get { } //Length: 17
	}

	public RectOffset padding
	{
		 get { } //Length: 11
		 set { } //Length: 59
	}

	public override float preferredHeight
	{
		 get { } //Length: 17
	}

	public override float preferredWidth
	{
		 get { } //Length: 17
	}

	protected List<RectTransform> rectChildren
	{
		 get { } //Length: 11
	}

	protected RectTransform rectTransform
	{
		 get { } //Length: 122
	}

	protected LayoutGroup() { }

	public override void CalculateLayoutInputHorizontal() { }

	public abstract void CalculateLayoutInputVertical() { }

	[IteratorStateMachine(typeof(<DelayedSetDirty>d__57))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	public TextAnchor get_childAlignment() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	private bool get_isRootLayoutGroup() { }

	public override int get_layoutPriority() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public RectOffset get_padding() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	protected List<RectTransform> get_rectChildren() { }

	protected RectTransform get_rectTransform() { }

	protected float GetAlignmentOnAxis(int axis) { }

	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	protected float GetTotalFlexibleSize(int axis) { }

	protected float GetTotalMinSize(int axis) { }

	protected float GetTotalPreferredSize(int axis) { }

	protected override void OnChildRectTransformDimensionsChange() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected override void OnTransformChildrenChanged() { }

	public void set_childAlignment(TextAnchor value) { }

	public void set_padding(RectOffset value) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	protected void SetDirty() { }

	public abstract void SetLayoutHorizontal() { }

	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	public abstract void SetLayoutVertical() { }

	protected void SetProperty(ref T currentValue, T newValue) { }

}

