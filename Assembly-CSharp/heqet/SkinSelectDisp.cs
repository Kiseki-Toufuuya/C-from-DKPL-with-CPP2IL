namespace Heqet;

public class SkinSelectDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public SkinSelectDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Screen = 0,
		ArrawLeft = 1,
		ArrowRight = 2,
		SkinDefault = 3,
		SkinLawson = 4,
		Skin00 = 5,
		Skin01 = 6,
		Skin02 = 7,
		Skin03 = 8,
		Skin04 = 9,
		Skin05 = 10,
		Skin06 = 11,
		Skin07 = 12,
		Max = 13,
		SkinTop = 3,
		SkinMax = 13,
	}

	private enum eCommonLayerId
	{
		SkinDefault = 0,
		SkinLawson = 1,
		Skin00 = 2,
		Skin01 = 3,
		Skin02 = 4,
		Skin03 = 5,
		Skin04 = 6,
		Skin05 = 7,
		Skin06 = 8,
		Skin07 = 9,
		Max = 10,
	}

	private enum eImageId
	{
		Max = 0,
	}

	internal enum eSkinType
	{
		SkinDefault = 0,
		SkinLawson = 1,
		Skin00 = 2,
		Skin01 = 3,
		Skin02 = 4,
		Skin03 = 5,
		Skin04 = 6,
		Skin05 = 7,
		Skin06 = 8,
		Skin07 = 9,
	}

	private enum eTextId
	{
		Max = 0,
	}

	internal class SkinButton
	{
		public int m_button_id; //Field offset: 0x8
		public int m_common_layer_id; //Field offset: 0xC
		public int m_heroine_id; //Field offset: 0x10
		public TextMeshProUGUI m_text; //Field offset: 0x14
		public GameObject m_unSelectedObject; //Field offset: 0x18
		public bool m_isActive; //Field offset: 0x1C

		public SkinButton(int button_id, int common_layer_id, int heroine_id) { }

		public void Select(bool enable) { }

		public void Setup(int id, GameObject root) { }

	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private String[] m_ButtonDataList; //Field offset: 0x114
	public Action<Int32> m_onButtonClick; //Field offset: 0x118
	public Action<Int32> m_onChangeSkin; //Field offset: 0x11C
	private SkinButton[] m_SkinChangeButtons; //Field offset: 0x120
	private int m_selectSkinIndex; //Field offset: 0x124
	private int m_activeSkinCoount; //Field offset: 0x128
	private Animator RootAnimator; //Field offset: 0x12C

	private static SkinSelectDisp() { }

	public SkinSelectDisp() { }

	[CompilerGenerated]
	private bool <Open>b__27_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DisableSkinButton(eSkinType skinType) { }

	protected virtual void InitUguiOther() { }

	public static bool IsSkinButton(int btn_id) { }

	protected virtual void LateUpdate() { }

	public void OffsetSelectSkinIndex(int offset) { }

	[AsyncStateMachine(typeof(<Open>d__27))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public bool SetSelectSkinIndex(int index) { }

	public static int SkinButtonId2SkinId(int btn_id) { }

	protected virtual void UpdateDispMain() { }

}

