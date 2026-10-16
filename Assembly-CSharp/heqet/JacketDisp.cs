namespace Heqet;

public class JacketDisp : UiScrollListPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public JacketDisp <>4__this; //Field offset: 0x8
		public int jacketId; //Field offset: 0xC

		public <>c__DisplayClass25_0() { }

		internal void <SetJacket>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		Root = 0,
		NormalRoot = 1,
		ImageRoot = 2,
		NewMark = 3,
		Max = 4,
	}

	private enum eImageId
	{
		JacketImage = 0,
		ArrowImage = 1,
		Max = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private GalleryJacketLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private RawImageEx m_JacketImage; //Field offset: 0x13C
	private GameObject m_ArrowImage; //Field offset: 0x140
	private GameObject m_NewMarkObj; //Field offset: 0x144
	private int m_disp_index; //Field offset: 0x148
	private ListNavigation m_navigation; //Field offset: 0x14C
	private JacketAssetBunleLoader m_jacketLoader; //Field offset: 0x150
	private int m_RequestId; //Field offset: 0x154

	public GameObject SelectTargetObject
	{
		 get { } //Length: 37
	}

	private static JacketDisp() { }

	public JacketDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_1(AxisEventData eventData) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject get_SelectTargetObject() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public void SetArrowActive(bool flg) { }

	public virtual void SetData(int list_index, bool active) { }

	private void SetJacket(int jacketId) { }

	public void SetNewMarkAction(bool flg) { }

}

