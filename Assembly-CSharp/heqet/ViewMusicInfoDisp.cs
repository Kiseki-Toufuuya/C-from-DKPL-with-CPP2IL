namespace Heqet;

public class ViewMusicInfoDisp : ViewMusicInfoDispBase
{
	private enum eImageId
	{
		JAKET = 0,
		DIFFICARITY = 1,
	}

	private enum eTextId
	{
		BPM = 0,
		TITLE = 1,
		CIRCLE = 2,
		VOCAL = 3,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x138
	private int m_JacketId; //Field offset: 0x13C
	private GameObject m_DataObject; //Field offset: 0x140
	private float prevBPM; //Field offset: 0x144

	private static ViewMusicInfoDisp() { }

	public ViewMusicInfoDisp() { }

	[CompilerGenerated]
	private void <SetupViewData>b__11_0(AssetBundleLoadAssetOperation ope) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void InitLayout() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public virtual void SetupViewData(SetupParam _param) { }

	public virtual void UpdateBpm(float _bpm) { }

}

