namespace Heqet;

public class SpotIconDisp : DispBase
{
	private enum eImageId
	{
		progress_icon_1 = 0,
		progress_icon_2 = 1,
		progress_icon_3 = 2,
		Max = 3,
	}

	private enum eTextId
	{
		SpotName = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private WorldMapLayer m_Layer; //Field offset: 0x114
	private String[] m_ImageList; //Field offset: 0x118
	private TextMeshProUGUI m_SpotName; //Field offset: 0x11C
	[CompilerGenerated]
	private SpotPoint <TargetSpot>k__BackingField; //Field offset: 0x120

	public SpotPoint TargetSpot
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static SpotIconDisp() { }

	public SpotIconDisp() { }

	[CompilerGenerated]
	private void <Create>b__10_0(bool isEnable) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public SpotPoint get_TargetSpot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[CompilerGenerated]
	public void set_TargetSpot(SpotPoint value) { }

	protected virtual void UpdateDispMain() { }

}

