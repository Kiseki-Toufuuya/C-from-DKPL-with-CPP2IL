namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TwoPaneSplitViewResizer : PointerManipulator
{
	private Vector3 m_Start; //Field offset: 0x14
	protected bool m_Active; //Field offset: 0x20
	private TwoPaneSplitView m_SplitView; //Field offset: 0x24
	private int m_Direction; //Field offset: 0x28
	private float m_Delta; //Field offset: 0x2C

	private VisualElement fixedPane
	{
		private get { } //Length: 26
	}

	private float fixedPaneMargins
	{
		private get { } //Length: 289
	}

	private float fixedPaneMinDimension
	{
		private get { } //Length: 157
	}

	private VisualElement flexedPane
	{
		private get { } //Length: 26
	}

	private float flexedPaneMargin
	{
		private get { } //Length: 289
	}

	private float flexedPaneMinDimension
	{
		private get { } //Length: 157
	}

	private TwoPaneSplitViewOrientation orientation
	{
		private get { } //Length: 26
	}

	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir) { }

	public void ApplyDelta(float delta) { }

	private VisualElement get_fixedPane() { }

	private float get_fixedPaneMargins() { }

	private float get_fixedPaneMinDimension() { }

	private VisualElement get_flexedPane() { }

	private float get_flexedPaneMargin() { }

	private float get_flexedPaneMinDimension() { }

	private TwoPaneSplitViewOrientation get_orientation() { }

	protected void InterruptPointerMove(PointerMoveEvent e) { }

	protected void OnPointerDown(PointerDownEvent e) { }

	protected void OnPointerMove(PointerMoveEvent e) { }

	protected void OnPointerUp(PointerUpEvent e) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

