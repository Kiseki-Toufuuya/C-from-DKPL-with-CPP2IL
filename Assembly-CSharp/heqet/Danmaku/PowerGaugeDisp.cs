namespace Heqet.Danmaku;

public class PowerGaugeDisp : DispBase
{
	private const string POWERS = "powers"; //Field offset: 0x0
	private const string POWER_TEXT = "power_text"; //Field offset: 0x0
	private const string PULL_POWER_TAG = "full_tag"; //Field offset: 0x0
	private const int POWERS_MIN_NUM = 0; //Field offset: 0x0
	private const int POWERS_MAX_NUM = 4; //Field offset: 0x0
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x114
	private TextMeshProUGUI m_PowerText; //Field offset: 0x118
	private GameObject m_FullTag; //Field offset: 0x11C
	private Material m_ImageMaterial; //Field offset: 0x120
	private List<GameObject> m_PowerCells; //Field offset: 0x124
	private float m_CurrPLevelAmount; //Field offset: 0x128
	private int m_CurrentPowerNum; //Field offset: 0x12C

	public PowerGaugeDisp() { }

	[CompilerGenerated]
	private void <InitLayout>b__13_0(AssetBundleLoadAssetOperation ope) { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetPowerData(float plevel, bool isInit = false) { }

	protected virtual void UpdateDispMain() { }

}

