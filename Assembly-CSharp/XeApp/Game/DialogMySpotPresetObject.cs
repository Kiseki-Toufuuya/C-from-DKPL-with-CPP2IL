namespace XeApp.Game;

public class DialogMySpotPresetObject : DialogChildObject
{
	private enum eTextId
	{
		TITLE = 0,
		DETAIL = 1,
		NUM_TEXT_ID = 2,
	}

	internal enum TYPE
	{
		CLEAR = 0,
		PLACEMENT = 1,
	}

	private static readonly String[] m_textDataList; //Field offset: 0x0
	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private RawImage[] m_rawImages; //Field offset: 0x134
	private AtlasImage[] m_atlasImage; //Field offset: 0x138
	private GameObject m_arrowImage; //Field offset: 0x13C
	private UIWrapperTextMeshPro[] m_texts; //Field offset: 0x140
	private TYPE m_type; //Field offset: 0x144

	private static DialogMySpotPresetObject() { }

	public DialogMySpotPresetObject() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetType(TYPE type) { }

	protected virtual void UpdateDispMain() { }

}

