namespace Heqet.Danmaku;

public class SupportItemsDisp : DispBase
{
	private const string ITEMS = "items"; //Field offset: 0x0
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x114
	private List<AtlasImage> itemImages; //Field offset: 0x118

	public SupportItemsDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void GetItem(string itemID) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	protected virtual void UpdateDispMain() { }

	public void UseItem(string itemID) { }

}

