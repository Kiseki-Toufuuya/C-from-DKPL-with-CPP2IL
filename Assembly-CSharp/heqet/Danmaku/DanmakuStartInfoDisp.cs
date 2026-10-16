namespace Heqet.Danmaku;

public class DanmakuStartInfoDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public RawImageEx img; //Field offset: 0x8

		public <>c__DisplayClass11_0() { }

		internal void <SetupParam>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	private enum eLayerId
	{
		MUSIC_JACKET = 0,
	}

	private enum eTextId
	{
		TEXT_MUSIC_TITLE = 0,
		TEXT_ILLUSTRATOR = 1,
		TEXT_CIRCLE = 2,
		TEXT_INFO_1 = 3,
		TEXT_INFO_2 = 4,
		TEXT_INFO_3 = 5,
		TEXT_INFO_4 = 6,
		TEXT_INFO_5 = 7,
		TEXT_INFO_6 = 8,
		TEXT_INFO_7 = 9,
		TEXT_INFO_8 = 10,
		TEXT_INFO_9 = 11,
		TEXT_INFO_10 = 12,
		TEXT_INFO_11 = 13,
	}

	private Animation m_RootAnimation; //Field offset: 0x114
	private AnimationEventEffect m_AnimationEvent; //Field offset: 0x118
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x11C
	private int m_JacketId; //Field offset: 0x120
	private readonly String[] m_LayerIdList; //Field offset: 0x124
	private readonly String[] m_TextIdList; //Field offset: 0x128

	public DanmakuStartInfoDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void InitUguiOther() { }

	public bool IsJacketLoading() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void PlayAnimation() { }

	public virtual void ReleaseAll() { }

	public void SetupParam(int _id) { }

	protected virtual void UpdateDispMain() { }

}

