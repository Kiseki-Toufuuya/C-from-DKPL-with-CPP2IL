namespace Heqet.Kagura;

public class KaguraLive2DDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Transform nameRoot; //Field offset: 0x8
		public KaguraLive2DDisp <>4__this; //Field offset: 0xC

		public <>c__DisplayClass19_0() { }

		internal void <PlayNamePlateAnimation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public BossHeroineInfo info; //Field offset: 0x8
		public Image image; //Field offset: 0xC

		public <>c__DisplayClass9_0() { }

		internal void <UguiLayoutCallback>b__0(AssetBundleLoadAssetOperation asset) { }

	}

	private class BossHeroineInfo
	{
		public int Id; //Field offset: 0x8
		public Live2DModel Live2DModel; //Field offset: 0xC
		public GameObject DisplayGameObject; //Field offset: 0x10
		public Vector3 Live2DPosition; //Field offset: 0x14
		public float NamePositionX; //Field offset: 0x20
		public string NameRootObjectName; //Field offset: 0x24
		public string NameObjectName; //Field offset: 0x28
		public string NameSecondObjectName; //Field offset: 0x2C
		public bool EnableNamePlateAnimation; //Field offset: 0x30
		public bool IsSpriteLoading; //Field offset: 0x31
		public string SpriteObjectName; //Field offset: 0x34

		public BossHeroineInfo() { }

	}

	private const int BOSS = 0; //Field offset: 0x0
	private const int PLAYER = 1; //Field offset: 0x0
	private const float ANIMATION_DURATION = 0.6; //Field offset: 0x0
	private const float ANIMATION_IN_DELAY = 0; //Field offset: 0x0
	private const float ANIMATION_OUT_DELAY = 1; //Field offset: 0x0
	private BossHeroineInfo[] bossHeroineInfo; //Field offset: 0x114

	public KaguraLive2DDisp() { }

	[CompilerGenerated]
	private void <PlayNamePlateAnimation>b__19_1() { }

	public virtual void Create(LayerBase parent_layer) { }

	private int GetBossId() { }

	private int GetPlayerId() { }

	protected virtual void LateUpdate() { }

	public bool Live2DIsReady() { }

	public void PlayBossLive2DMotion(NotesJudge judge) { }

	private bool PlayerHasAdvantage() { }

	public void PlayNamePlateAnimation() { }

	public virtual void ReleaseAll() { }

	public void StartGameFinishAnimation(bool stageCleared = true) { }

	private void SwitchToStayMotion(Live2DModel live2DModel) { }

	private void UguiLayoutCallback() { }

	protected virtual void UpdateDispMain() { }

}

