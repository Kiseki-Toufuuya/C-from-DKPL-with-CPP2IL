namespace Heqet.Danmaku;

public class StageBackgroundDisp : DispBase
{
	private enum State
	{
		None = 0,
		Prepare = 1,
		Pause = 2,
		Playing = 3,
		Stop = 4,
	}

	private static readonly String[] stageBackgroundNameList; //Field offset: 0x0
	private const float TIME = 3; //Field offset: 0x0
	private const string MASK = "Mask"; //Field offset: 0x0
	private State state; //Field offset: 0x114
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x118
	private CriManaMovieControllerForUI movieController; //Field offset: 0x11C
	private Material m_ImageMaterial; //Field offset: 0x120
	private Material m_LatticeMaterial; //Field offset: 0x124
	private float m_Radius; //Field offset: 0x128
	private bool m_IsPlay; //Field offset: 0x12C

	private static StageBackgroundDisp() { }

	public StageBackgroundDisp() { }

	[CompilerGenerated]
	private void <InitLayout>b__12_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <PlayMaskEffect>b__23_0() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	public bool IsReadyStageBackground() { }

	public bool IsStopped() { }

	protected virtual void LateUpdate() { }

	public void Pause(bool enable) { }

	public void PlayMaskEffect() { }

	public void Prepare(eStageBackground bg) { }

	public virtual void ReleaseAll() { }

	public void SetMaskEffectPos(Vector2 position) { }

	public void SetSeekPosition(float time) { }

	public void Stop() { }

	protected virtual void UpdateDispMain() { }

}

