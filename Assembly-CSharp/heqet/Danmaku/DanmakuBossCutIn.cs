namespace Heqet.Danmaku;

public class DanmakuBossCutIn
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public DanmakuBossCutIn <>4__this; //Field offset: 0x8
		public Live2DModel live2DModel; //Field offset: 0xC

		public <>c__DisplayClass19_0() { }

		internal void <Initialize>b__0(AssetBundleLoadAssetOperation ope) { }

		internal void <Initialize>b__1(AssetBundleLoadAssetOperation ope) { }

	}

	internal enum EffectBGType
	{
		Loop1 = 0,
		Loop1A = 1,
		Loop2 = 2,
		Loop2A = 3,
		Max = 4,
	}

	private const int MUSIC_BORDER_ID = 74; //Field offset: 0x0
	private const string LIVE2D_MESH = "cutin_spell_start_BossL2D"; //Field offset: 0x0
	private const string CUT_IN_EFFECT_02 = "effect_bg_loop02"; //Field offset: 0x0
	private const string CUT_IN_EFFECT_01A = "effect_bg_loop01A"; //Field offset: 0x0
	private const string CUT_IN_EFFECT_01 = "effect_bg_loop01"; //Field offset: 0x0
	private const string CUT_IN_EFFECT_02A = "effect_bg_loop02A"; //Field offset: 0x0
	private const string CUT_IN_PREFAB = "boss_cut_in"; //Field offset: 0x0
	private const string ASSET_BUNDLE_NAME = "prefab/danmaku/common.xab"; //Field offset: 0x0
	private const float BORDER_COLOR = 0.05; //Field offset: 0x0
	private const string CUT_IN_ANIMATION = "cutin_spell_start_BossImg"; //Field offset: 0x0
	private EffectBGType m_EffectBGType; //Field offset: 0x8
	private GameObject m_CutInObj; //Field offset: 0xC
	private GameObject m_EffectObj; //Field offset: 0x10
	private Live2DModel m_Live2DModel; //Field offset: 0x14
	private Animation m_StartCutInAnimation; //Field offset: 0x18
	private Animation[] m_Animations; //Field offset: 0x1C
	private Animation[] m_BGAnimations; //Field offset: 0x20
	private bool m_Inited; //Field offset: 0x24

	public DanmakuBossCutIn() { }

	private MeshFilter GetCutInLive2DMeshFilter() { }

	private MeshRenderer GetCutInLive2DMeshRenderer() { }

	public void Initialize(Live2DModel live2DModel, EffectBGType type = 0) { }

	public bool IsPlay() { }

	public void Pause() { }

	public void Play() { }

	public void Resume() { }

	public void SetEffectBGActive(bool enable) { }

	private void SetUpBossLive2D(Live2DModel live2DModel) { }

	public void Terminate() { }

	public void Update() { }

}

