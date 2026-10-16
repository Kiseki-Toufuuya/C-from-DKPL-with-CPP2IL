namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
{
	private BaseRuntimePanel m_Panel; //Field offset: 0x14

	public virtual Camera eventCamera
	{
		 get { } //Length: 3
	}

	public override IPanel panel
	{
		 get { } //Length: 11
		 set { } //Length: 312
	}

	public virtual int renderOrderPriority
	{
		 get { } //Length: 99
	}

	private GameObject selectableGameObject
	{
		private get { } //Length: 25
	}

	public virtual int sortOrderPriority
	{
		 get { } //Length: 125
	}

	public PanelRaycaster() { }

	public virtual Camera get_eventCamera() { }

	public override IPanel get_panel() { }

	public virtual int get_renderOrderPriority() { }

	private GameObject get_selectableGameObject() { }

	public virtual int get_sortOrderPriority() { }

	private void OnPanelDestroyed() { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	private void RegisterCallbacks() { }

	public override void set_panel(IPanel value) { }

	private void UnregisterCallbacks() { }

}

