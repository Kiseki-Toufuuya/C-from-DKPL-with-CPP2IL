namespace Heqet;

public class StageSelectInfoDisp : DispBase
{
	private enum eBtnLayerId
	{
	}

	private enum eCommonLayerId
	{
		SCENE_ANIM_ROOT = 0,
	}

	private enum eTxtLayerId
	{
	}

	private String[] m_CommonLayerList; //Field offset: 0x114
	private String[] m_TxtLayerList; //Field offset: 0x118
	private String[] m_BtnLayerList; //Field offset: 0x11C
	public SceneInOutAnimation m_SceneInOutAnimator; //Field offset: 0x120

	public StageSelectInfoDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void OnClickButtonRelation(int buttonId) { }

	protected virtual void UpdateDispMain() { }

}

