namespace Heqet;

public class HeqetSelectPanelDispBase : DispBase, IInfiniteScrollSetup
{

	public override RectTransform PanelRoot
	{
		 get { } //Length: 3
	}

	public HeqetSelectPanelDispBase() { }

	public virtual void Create(LayerBase parent_layer) { }

	public override RectTransform get_PanelRoot() { }

	public override int GetItemNo() { }

	protected virtual void LateUpdate() { }

	public override void OnUpdateItem(int itenNo, GameObject obj) { }

	protected virtual void UpdateDispMain() { }

}

