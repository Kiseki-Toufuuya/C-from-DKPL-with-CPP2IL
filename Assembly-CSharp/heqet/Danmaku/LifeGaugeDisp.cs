namespace Heqet.Danmaku;

public class LifeGaugeDisp : DispBase
{
	private const string BAR = "hp_gauge_mask"; //Field offset: 0x0
	private const int CELL_MAX_CELL = 21; //Field offset: 0x0
	private const float MAX_WIDTH = 291; //Field offset: 0x0
	private const float START_WIDTH = 80; //Field offset: 0x0
	private const float CELL_WIDTH = 10; //Field offset: 0x0
	private const float UPWARD_SPEED = 0.001; //Field offset: 0x0
	private const float TEXTURE_WIDTH = 211; //Field offset: 0x0
	private const string ANIMATION_DOWN_NAME = "heart_down"; //Field offset: 0x0
	private const string ANIMATION_UP_NAME = "heart_up"; //Field offset: 0x0
	private const string HP_HEART = "hp_heart"; //Field offset: 0x0
	private const string HP_TEXT = "hp_text"; //Field offset: 0x0
	private const string ANIMATION_DANGER = "heart_danger"; //Field offset: 0x0
	private DanmakuLayer m_DanmaLayer; //Field offset: 0x114
	private RectTransform m_hpBar; //Field offset: 0x118
	private Animator m_HeartAnimator; //Field offset: 0x11C
	private AnimationEventEffect m_AnimationEvent; //Field offset: 0x120
	private TextMeshProUGUI m_HPText; //Field offset: 0x124
	private float m_CurrHPPercent; //Field offset: 0x128
	private float m_LastHPPercent; //Field offset: 0x12C
	private int m_CurrlifeNum; //Field offset: 0x130

	public LifeGaugeDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void SetLifePercent(float percent) { }

	public void SetLifeStockNum(int num) { }

	protected virtual void UpdateDispMain() { }

}

