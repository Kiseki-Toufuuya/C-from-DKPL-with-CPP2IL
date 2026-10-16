namespace Heqet;

public class GreditUIItemDisp : UiScrollListPanelBase
{
	private enum eTextId
	{
		Text01 = 0,
		Text02 = 1,
		Text03 = 2,
		Text04 = 3,
		Max = 4,
	}

	private CreditUILayer m_Layer; //Field offset: 0x130
	private String[] m_TextList; //Field offset: 0x134

	public GreditUIItemDisp() { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public virtual void SetData(int list_index, bool active) { }

}

