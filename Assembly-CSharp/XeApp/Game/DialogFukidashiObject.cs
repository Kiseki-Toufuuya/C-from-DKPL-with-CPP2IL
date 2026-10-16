namespace XeApp.Game;

public class DialogFukidashiObject : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_FUKI = 0,
		TEXT_NUM = 1,
	}

	internal enum eSpriteType
	{
		NONE = 0,
		STONE = 1,
		GOLD = 2,
		HEART = 3,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private eSpriteType m_typeSprite; //Field offset: 0x114
	private int m_numCost; //Field offset: 0x118
	private bool m_isUpdateDisp; //Field offset: 0x11C
	private bool m_isNotEnoughFlag; //Field offset: 0x11D

	private static DialogFukidashiObject() { }

	public DialogFukidashiObject() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void SetFukidashiNotEnoughColor() { }

	public void SetFukidashiText(int num, eSpriteType sprite = 0) { }

	public void SetParent(Transform parent) { }

	protected virtual void UpdateDispMain() { }

}

