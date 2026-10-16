namespace Heqet.Danmaku;

public class BossLifeGaugeDisp : DispBase
{
	private enum PlayType
	{
		None = 0,
		FadeIn = 1,
		Shift = 2,
	}

	private const string BAR = "hp_gauge_mask"; //Field offset: 0x0
	private const string WHITE_BAR = "hp_gauge_white"; //Field offset: 0x0
	private const string WHITE_BAR_IMAGE = "hp_white"; //Field offset: 0x0
	private const float MIN_WIDTH = 32; //Field offset: 0x0
	private const float MAX_WIDTH = 362; //Field offset: 0x0
	private const float ANIMATION_RATE = 0.3; //Field offset: 0x0
	private const float DAMAGE_PERCENT = 0.02; //Field offset: 0x0
	private const float DPS_TIME = 0.2; //Field offset: 0x0
	private readonly String[] HP_STOCK; //Field offset: 0x114
	private readonly String[] HP_STOCK_BG; //Field offset: 0x118
	private PlayType m_PlayType; //Field offset: 0x11C
	private DanmakuLayer m_DanmaLayer; //Field offset: 0x120
	private RectTransform m_HPBar; //Field offset: 0x124
	private RectTransform m_HPWhiteBar; //Field offset: 0x128
	private AtlasImage m_HPWhiteImage; //Field offset: 0x12C
	private Tweener m_Tween; //Field offset: 0x130
	private float m_HPPercent; //Field offset: 0x134
	private float m_dpsTimer; //Field offset: 0x138
	private int m_currLifeNum; //Field offset: 0x13C
	private int m_currHPStock; //Field offset: 0x140
	private bool m_Updating; //Field offset: 0x144
	private List<GameObject> m_HPStock; //Field offset: 0x148
	private List<GameObject> m_HPStockBg; //Field offset: 0x14C

	public BossLifeGaugeDisp() { }

	[CompilerGenerated]
	private void <SetHPPercent>b__29_0() { }

	[CompilerGenerated]
	private void <SetHPPercent>b__29_1() { }

	public virtual void Create(LayerBase parent_layer) { }

	private Vector2 GetNewSizeDelta(float percent) { }

	private void InitHPStock(int lifeNum) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void SetHPPercent(float percent) { }

	public void SetHPStock(int lifeNum) { }

	protected virtual void UpdateDispMain() { }

}

