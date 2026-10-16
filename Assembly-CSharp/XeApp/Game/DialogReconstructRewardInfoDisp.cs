namespace XeApp.Game;

public class DialogReconstructRewardInfoDisp : DialogChildObject
{
	private enum eCommonLayerId
	{
		NUM = 0,
	}

	private enum eTxtLayerId
	{
		REWARD_DETAIL = 0,
		NUM = 1,
	}

	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private String[] m_CommonLayerList; //Field offset: 0x134
	private String[] m_TxtLayerList; //Field offset: 0x138
	private UIWrapperTextMeshPro[] m_texts; //Field offset: 0x13C

	public DialogReconstructRewardInfoDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	protected virtual void UpdateDispMain() { }

}

