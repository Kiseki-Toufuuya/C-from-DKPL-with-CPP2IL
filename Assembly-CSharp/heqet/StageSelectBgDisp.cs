namespace Heqet;

public class StageSelectBgDisp : DispBase
{
	private enum eCommonLayerId
	{
		ANIMATION_ROOT = 0,
		BG_IMG = 1,
		NUM = 2,
	}

	private String[] m_CommonLayerList; //Field offset: 0x114
	public SceneInOutAnimation m_SceneInOutAnimator; //Field offset: 0x118
	private Image m_BackgroungImage; //Field offset: 0x11C
	private BackGroundAssetBunleLoader m_Loader; //Field offset: 0x120
	private int m_CurrentId; //Field offset: 0x124

	public StageSelectBgDisp() { }

	[CompilerGenerated]
	private void <DispUpdate>b__11_0(AssetBundleLoadAssetOperation ope) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	public void DispUpdate(int _id) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	protected virtual void UpdateDispMain() { }

}

