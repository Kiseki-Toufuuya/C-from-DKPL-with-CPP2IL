namespace XeApp.Game;

public class AdvEffectLayer : LayerBase
{
	internal enum eEffectSort
	{
		EFF_UI = 0,
		EFF_CHARA = 1,
		EFF_BG = 2,
	}

	internal enum eEffectType
	{
		EFF_ENV_EFFECT_START = 0,
		EFF_DISTORTION = 0,
		EFF_KANKYOU_RAIN_01 = 1,
		EFF_KANKYOU_LINE_01 = 2,
		EFF_KANKYOU_SMOKE_01 = 3,
		EFF_HAKO_KANKYOU_FIRE01 = 4,
		EFF_HAKO_KANKYOU_FLOWER01 = 5,
		EFF_HAKO_KANKYOU_ICE01 = 6,
		EFF_POS_START = 7,
		EFF_YUMEMITAMA_GLASS = 7,
		EFF_YUMEMITAMA_SMOKE = 8,
		EFF_CURTAIN_FLUSH = 9,
		EFF_DARKNESS_AURA01 = 10,
		EFF_YUMEMITAMA_SMOKE_LOOP = 11,
		NUM = 12,
	}

	public Int32[2] EffectData; //Field offset: 0x58
	private Dictionary<Int32, AdvEffectDisp> EpisodeEffect; //Field offset: 0x5C
	private bool CreateFlag; //Field offset: 0x60

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public AdvEffectLayer() { }

	public void CreateEffectDisp(List<Int32> eff_list) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsCreated() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetEffectActive(int eff_no, bool active) { }

	public void StartEffect(int eff_no, Vector3 eff_pos, eEffectSort sort, int time) { }

	public void StopEffect(int eff_no) { }

	protected virtual void Update(bool is_active) { }

}

