namespace XeApp.Game;

public class DialogEventSDEpisodeReleaseDisp : DialogChildObject
{
	private enum eIconPanreList
	{
		ICON_PARENT_1_1 = 0,
		ICON_PARENT_1_2 = 1,
		ICON_PARENT_2_1 = 2,
		ICON_PARENT_2_2 = 3,
		ICON_PARENT_2_3 = 4,
	}

	internal class InOutParam
	{
		public List<Int32> CharacterThumbnailList; //Field offset: 0x8

		public InOutParam() { }

	}

	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private InOutParam m_InOutParam; //Field offset: 0x134
	private String[] IconParentNameList; //Field offset: 0x138
	private CharacterListIconBookPanel[] IconPanelList; //Field offset: 0x13C

	public virtual bool IsReady
	{
		 get { } //Length: 106
	}

	public DialogEventSDEpisodeReleaseDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual bool get_IsReady() { }

	public virtual void InitLoadAfter() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	protected virtual void UpdateDispMain() { }

}

