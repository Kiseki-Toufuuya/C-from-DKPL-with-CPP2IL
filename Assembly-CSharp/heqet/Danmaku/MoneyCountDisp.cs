namespace Heqet.Danmaku;

public class MoneyCountDisp : DispBase
{
	private const string MONEY_TEXT = "money_text"; //Field offset: 0x0
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x114
	private TextMeshProUGUI m_CountText; //Field offset: 0x118

	public MoneyCountDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetCount(int count, bool isInit = false) { }

	protected virtual void UpdateDispMain() { }

}

