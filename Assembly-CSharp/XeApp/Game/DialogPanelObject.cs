namespace XeApp.Game;

public class DialogPanelObject : UiScrollListPanelBase
{
	private sDialogListArg ListArg; //Field offset: 0x130
	private DialogLayer m_Layer; //Field offset: 0x134
	private Transform m_IconRoot; //Field offset: 0x138
	private CharacterCardSmallIcon m_CardIcon; //Field offset: 0x13C
	private GenericItemIconPanel m_ItemIcon; //Field offset: 0x140
	private bool m_IconSettingFlag; //Field offset: 0x144
	private int m_IconPrefix; //Field offset: 0x148
	private int m_IconId; //Field offset: 0x14C
	private object m_SendData; //Field offset: 0x150

	public DialogPanelObject() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	public virtual Vector2 GetPanelSizeByIndex(int index) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public virtual void SetData(int index, bool active) { }

	private void SetInfo_RewardListWindow(int prefix, int id, object sendData = null) { }

	protected virtual void UpdateDispMain() { }

}

