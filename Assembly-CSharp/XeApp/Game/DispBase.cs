namespace XeApp.Game;

public abstract class DispBase : uGUIScreenRotateLayoutBase
{
	internal class AnimLabelData
	{
		public string m_ObjName; //Field offset: 0x8
		public string m_LabelStart; //Field offset: 0xC
		public string m_LabelEnd; //Field offset: 0x10
		public int m_AnimId; //Field offset: 0x14
		public bool m_LoopFg; //Field offset: 0x18
		public bool m_RoundFg; //Field offset: 0x19

		public AnimLabelData(int anim_id, string name, string start, string end, bool loop, bool round) { }

	}

	internal enum eAnimIn
	{
		OFF = 0,
		ON = 1,
	}

	internal enum eDispTiming
	{
		SOON = 0,
		LAYER_ALIGN = 1,
		WAIT = 2,
	}

	private enum eStepLoadUgui
	{
		INIT_LOAD_ASSET = 0,
		INIT_LOAD_LAYOUT = 1,
		WAIT_LOAD_LAYOUT = 2,
		COMPLETE = 3,
		AFTER = 4,
		NUM = 5,
	}

	private enum eUguiAnimStandard
	{
		BASE = 1000,
		IN = 1001,
		OUT = 1002,
		LOOP = 1003,
	}

	private const string ANIM_LABEL_IN_START = "in_st"; //Field offset: 0x0
	private const string ANIM_LABEL_IN_END = "wait"; //Field offset: 0x0
	private const string ANIM_LABEL_OUT_START = "wait"; //Field offset: 0x0
	private const string ANIM_LABEL_OUT_END = "out_en"; //Field offset: 0x0
	private List<UiObject> m_ObjList; //Field offset: 0xA0
	private Action<Boolean> m_OnSetDispCallback; //Field offset: 0xA4
	private Action<Boolean> m_OnSetHideCallback; //Field offset: 0xA8
	private Action<Boolean> m_OnSetTouchCallback; //Field offset: 0xAC
	private int m_OrderId; //Field offset: 0xB0
	private List<AssetBundleLoadAllAssetOperationBase> m_LoadOperationList; //Field offset: 0xB4
	private Dictionary<Int32, UIWrapperBase> m_UguiLayerCommon; //Field offset: 0xB8
	private Dictionary<Int32, UIWrapperText> m_UguiLayerText; //Field offset: 0xBC
	private Dictionary<Int32, UIWrapperImage> m_UguiLayerImage; //Field offset: 0xC0
	private Dictionary<Int32, UIWrapperGage> m_UguiLayerGauge; //Field offset: 0xC4
	private Dictionary<Int32, UIWrapperTextMeshPro> m_UguiLayerTextMesh; //Field offset: 0xC8
	private Action m_UguiLayoutCallback; //Field offset: 0xCC
	private List<List`1<String>> m_UguiAnimAnalysisList; //Field offset: 0xD0
	private List<AnimLabelData> m_UguiAnimLabelDataList; //Field offset: 0xD4
	private Dictionary<Int32, Action`1<Int32>> m_UguiButtonCallback; //Field offset: 0xD8
	private Dictionary<Int32, Int32> m_UguiButtonIdList; //Field offset: 0xDC
	private Dictionary<Int32, Boolean> m_UguiButtonTempList; //Field offset: 0xE0
	private int m_UguiCanvasId; //Field offset: 0xE4
	private int m_UguiLayoutIndex; //Field offset: 0xE8
	private bool m_UguiAnimSetFg; //Field offset: 0xEC
	private bool m_UguiSetTouchFg; //Field offset: 0xED
	private eStepLoadUgui m_StepLoadUgui; //Field offset: 0xF0
	private string m_AssetBundleName; //Field offset: 0xF4
	private string m_AssetName; //Field offset: 0xF8
	private eDispTiming m_UguiDispStartTiming; //Field offset: 0xFC
	private eAnimIn m_UguiDispStartAnimIn; //Field offset: 0x100
	private bool m_IsHide; //Field offset: 0x104
	private bool m_BackupDisp; //Field offset: 0x105
	protected Dictionary<String, Sprite> m_SpriteList; //Field offset: 0x108
	private Transform m_ParentTransform; //Field offset: 0x10C
	private bool m_IsLoadEnd; //Field offset: 0x110
	protected bool m_IsSafeArea; //Field offset: 0x111
	protected bool m_IsTryInstallCheck; //Field offset: 0x112

	public bool IsLoadEnd
	{
		 get { } //Length: 14
	}

	public List<UiObject> ObjList
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action<Boolean> OnSetDispCallback
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action<Boolean> OnSetHideCallback
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action<Boolean> OnSetTouchCallback
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public int OrderId
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public Transform ParentTransform
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	protected DispBase() { }

	public void AddSprite(string fileName, AtlasImage image) { }

	protected override void CallbackAnimInComp() { }

	protected override void CallbackAnimOutComp() { }

	public void CallbackButtonCommon(int id) { }

	public bool ChkUguiAnimPlaying() { }

	public override void CompResourceLoad() { }

	public abstract void Create(LayerBase parent_layer) { }

	protected UiObject CreateUi(string path, int canvas_id) { }

	protected UiObject CreateUi(string path, Canvas canvas) { }

	protected UiObject CreateUi(string path, Transform parent = null) { }

	public override void ForceHideLayerDisp(bool enable) { }

	public bool get_IsLoadEnd() { }

	public List<UiObject> get_ObjList() { }

	public Action<Boolean> get_OnSetDispCallback() { }

	public Action<Boolean> get_OnSetHideCallback() { }

	public Action<Boolean> get_OnSetTouchCallback() { }

	public int get_OrderId() { }

	public Transform get_ParentTransform() { }

	public UIWrapperButton GetButtonObject(string name_hit) { }

	public UIWrapperButton GetButtonObject(int btn_id) { }

	public UIWrapperBase GetLayerCommon(int id) { }

	public UIWrapperGage GetLayerGauge(int id) { }

	public UIWrapperImage GetLayerImage(int id) { }

	public UIWrapperText GetLayerText(int id) { }

	public UIWrapperTextMeshPro GetLayerTextMesh(int id) { }

	public Sprite GetSprite(string fileName) { }

	public bool GetUguiLayerActive(int id) { }

	public UIWrapperBase GetUguiLayerCommon(int id) { }

	protected void HideEnable(bool enable, bool is_hide) { }

	public override void InitLoadAfter() { }

	private void InitUguiAnimAnalysis() { }

	protected override void InitUguiOther() { }

	protected virtual void InitUI() { }

	public override bool IsDestroy() { }

	protected abstract void LateUpdate() { }

	public void LateUpdateDispBase() { }

	public void LoadUguiLayoutRequest(string assetBundleName, string assetName, Action callback = null, int canvas_id = -1, eAnimIn in_anim = 1, eDispTiming timing = 1, bool isSafeArea = true) { }

	protected virtual void onInitEnd() { }

	public override void ReleaseAll() { }

	private void ReleaseUgui() { }

	public void set_ObjList(List<UiObject> value) { }

	public void set_OnSetDispCallback(Action<Boolean> value) { }

	public void set_OnSetHideCallback(Action<Boolean> value) { }

	public void set_OnSetTouchCallback(Action<Boolean> value) { }

	public void set_OrderId(int value) { }

	public void set_ParentTransform(Transform value) { }

	public void SetButtonDownSe(int btn_id, ALL_SE downSeId = 100061) { }

	public void SetButtonDownUpSe(int btn_id, ALL_SE downSeId = 100061, ALL_SE upSeId = 100061) { }

	public void SetButtonEnable(int btn_id, bool enable) { }

	public void SetButtonEnable(int btn_id, bool enable, bool force) { }

	public void SetButtonLongSe(int btn_id, ALL_SE seId = 100061) { }

	protected void SetButtonLongTap(int name_id, float sec, Action<Int32, Single, Boolean> cb_update, Action<Int32, Single, Boolean> cb_up = null, Action<Int32, Single> cb_comp = null) { }

	protected UIWrapperButton SetButtonObject(int name_id, string name_hit, string name_disp, Action<Int32> cb_down, Action<Int32> cb_up = null, Func<Int32, Boolean> cb_enable = null, Func<Int32, Boolean> cb_next = null, Action<Int32> cb_end = null, float next_rag = -1) { }

	protected UIWrapperButton SetButtonObjectForAnimator(int name_id, string name_hit, string name_disp, Action<Int32> cb_down, Action<Int32> cb_up = null, Func<Int32, Boolean> cb_enable = null, Func<Int32, Boolean> cb_next = null, Action<Int32> cb_end = null, float next_rag = -1) { }

	protected UIWrapperButton SetButtonObjectForAnimatorGenerateHitObject(int name_id, string name_disp, Action<Int32> cb_down, Action<Int32> cb_up = null, Func<Int32, Boolean> cb_enable = null, Func<Int32, Boolean> cb_next = null, Action<Int32> cb_end = null, float next_rag = -1) { }

	public override void SetButtonSeEnable(bool enable) { }

	public void SetButtonUpSe(int btn_id, ALL_SE upSeId = 100061) { }

	public void SetCanvas(int canvas_id, bool isSafeArea = true) { }

	public void SetCanvasParent(Transform tran, bool isSafeArea = true) { }

	public void SetChildToLayerCommon(DispBase child_disp_base, string parent_layer_name) { }

	public void SetChildToLayerCommon(DispBase child_disp_base, int parent_layer_id) { }

	public virtual void SetDisp(bool enable) { }

	public override void SetHide(bool enable) { }

	protected void SetLayerCommon(int id, string name) { }

	protected void SetLayerGauge(int id, string name) { }

	protected void SetLayerImage(int id, string name) { }

	protected void SetLayerText(int id, string name) { }

	protected void SetLayerTextMesh(int id, string name) { }

	public void SetNormalButtonDisp(int btn_id, bool enable) { }

	public void SetOrder(int order) { }

	public void SetSelectButtonDisp(int btn_id) { }

	public void SetTouch(bool enable) { }

	public override void SetUguiAnimIn() { }

	public void SetUguiAnimLabel(int anim_id, string obj_name, string label_st, string label_ed, bool loop = false, bool round = false) { }

	public void SetUguiAnimLabelData(AnimLabelData data) { }

	protected void SetUguiAnimLabelDataList(AnimLabelData[] list) { }

	public override void SetUguiAnimOut() { }

	public void SetUguiAnimPlay(int anim_id, Action callback = null) { }

	public void SetUguiAtlasImage(int id, string text) { }

	protected void SetUguiDispStart() { }

	public void SetUguiLayerActive(int id, bool active) { }

	public void SetUguiText(int id, string text) { }

	public void SetUguiTextMesh(int id, string text) { }

	public void SetUguiTextureImage(int id, Texture texture) { }

	public bool TryGetSprite(string fileName, out Sprite outSprite) { }

	public void UpdateDispBase() { }

	protected abstract void UpdateDispMain() { }

	public override bool WaitResourceLoad() { }

	private bool WaitUguiResourceLoad() { }

}

