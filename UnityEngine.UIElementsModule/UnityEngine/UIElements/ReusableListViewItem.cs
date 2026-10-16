namespace UnityEngine.UIElements;

internal class ReusableListViewItem : ReusableCollectionItem
{
	private static readonly string k_SortingDisablesReorderingTooltip; //Field offset: 0x0
	private VisualElement m_Container; //Field offset: 0x28
	private VisualElement m_DragHandle; //Field offset: 0x2C
	private VisualElement m_ItemContainer; //Field offset: 0x30

	public virtual VisualElement rootElement
	{
		 get { } //Length: 22
	}

	private static ReusableListViewItem() { }

	public ReusableListViewItem() { }

	public virtual void DetachElement() { }

	public virtual VisualElement get_rootElement() { }

	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	protected virtual void OnGeometryChanged(GeometryChangedEvent evt) { }

	public virtual void PreAttachElement() { }

	public virtual void SetDragGhost(bool dragGhost) { }

	public void SetDragHandleEnabled(bool enabled) { }

	public void UpdateDragHandle(bool needsDragHandle) { }

	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

}

