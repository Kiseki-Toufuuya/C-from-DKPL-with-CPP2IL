namespace Heqet.Danmaku;

public class TenCountDisp : DispBase
{
	private const string TEN_TEXT = "ten_text"; //Field offset: 0x0
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x114
	private TextMeshProUGUI m_CountText; //Field offset: 0x118

	public TenCountDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetCount(int count, bool isInit = false) { }

	protected virtual void UpdateDispMain() { }

}

