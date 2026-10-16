namespace Heqet.RG;

public abstract class UIControllerBase : MonoBehaviour
{
	[SerializeField]
	protected ComboMessage comboMessage; //Field offset: 0x10
	[SerializeField]
	protected JudgeMessage judgeMessage; //Field offset: 0x14
	[SerializeField]
	protected FastSlowMessage fastSlowMessage; //Field offset: 0x18
	[SerializeField]
	protected UIAnchor uiAnchor; //Field offset: 0x1C
	private LayerBase layerBase; //Field offset: 0x20

	protected UIControllerBase() { }

	protected abstract GameObject GetJudgeMessagePintOfLowerBlind() { }

	protected abstract GameObject GetJudgeMessagePintOfUpperBlind() { }

	public override void SetGameParam(LayerBase layerBase, HeqetMusicModel musicModel, SettingData musicSettingData) { }

	protected void SetupComboMessage(UICustomizeData uiCustomize) { }

	protected void SetupFastSlowMessage(UICustomizeData uiCustomize) { }

	protected void SetupJudgeMessage(UICustomizeData uiCustomize) { }

}

