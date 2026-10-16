namespace Heqet;

public class ViewMusicInfoDispBase : DispBase
{
	internal class EntryParam
	{
		public Vector3 Position; //Field offset: 0x8
		public Vector2 Scale; //Field offset: 0x14
		public bool IsDispDifficarity; //Field offset: 0x1C
		public bool IsDispInfo; //Field offset: 0x1D

		public EntryParam() { }

	}

	internal class SetupParam
	{
		public HeqetMusicModel MusicModel; //Field offset: 0x8
		public InGameInfo InGameInfo; //Field offset: 0xC

		public SetupParam() { }

	}

	protected LayerBase m_Layer; //Field offset: 0x114
	protected Animator RootAnimator; //Field offset: 0x118
	protected EntryParam m_EntryParam; //Field offset: 0x11C
	protected TextMeshProUGUI m_BPMText; //Field offset: 0x120
	protected TextMeshProUGUI m_TitleText; //Field offset: 0x124
	protected TextMeshProUGUI m_CircleText; //Field offset: 0x128
	protected TextMeshProUGUI m_VocalText; //Field offset: 0x12C
	protected RawImageEx m_JaketImage; //Field offset: 0x130
	protected AtlasImage m_DifficarityImage; //Field offset: 0x134

	public ViewMusicInfoDispBase() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void Entry(EntryParam _param) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void Open() { }

	public void SetLifePercent(float percent) { }

	public override void SetupViewData(SetupParam _param) { }

	public override void UpdateBpm(float _bpm) { }

	protected void UpdateDifficarityIcon(int _difficarity) { }

	protected virtual void UpdateDispMain() { }

}

