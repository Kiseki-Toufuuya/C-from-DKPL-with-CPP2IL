namespace Heqet;

public class ViewMusicInfoResultDisp : ViewMusicInfoDispBase
{
	private enum eImageId
	{
		JAKET = 0,
		BOSS_ELEMENT = 1,
	}

	private enum eLayerId
	{
		DIFFICULTY_EASY = 0,
		DIFFICULTY_NORMAL = 1,
		DIFFICULTY_HARD = 2,
		DIFFICULTY_LUNATIC = 3,
		BOSS_ELEMENT_ICON = 4,
		LANE_6 = 5,
		LANE_4 = 6,
	}

	private enum eTextId
	{
		BPM = 0,
		TITLE = 1,
		CIRCLE = 2,
		VOCAL = 3,
		TEXT_DIFFICULTY_EASY = 4,
		TEXT_DIFFICULTY_NORMAL = 5,
		TEXT_DIFFICULTY_HARD = 6,
		TEXT_DIFFICULTY_LUNATIC = 7,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private readonly String[] m_LayerList; //Field offset: 0x138
	private readonly string ELEMENT_IMAGE_NAME; //Field offset: 0x13C
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x140
	private int m_JacketId; //Field offset: 0x144
	private AtlasImage m_ElementImage; //Field offset: 0x148

	private static ViewMusicInfoResultDisp() { }

	public ViewMusicInfoResultDisp() { }

	[CompilerGenerated]
	private void <SetupViewData>b__14_0(AssetBundleLoadAssetOperation ope) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void InitLayout() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public virtual void SetupViewData(SetupParam _param) { }

}

