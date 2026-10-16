namespace XeApp.Game;

public abstract class uGUIScreenRotateLayoutsBase : IUpdateable, IInitializable
{
	internal enum LayoutOrientation
	{
		landscape = 0,
		portrait = 1,
		num = 2,
	}

	private LayoutOrientation m_CurrentLayoutOrientation; //Field offset: 0x8
	protected int m_UseLayoutIndex; //Field offset: 0xC
	private bool m_IsBothOrientationLayout; //Field offset: 0x10
	private bool m_CanChgOrientation; //Field offset: 0x11
	protected uGUIScreenRotateLayoutBase[] m_uGUILayouts; //Field offset: 0x14
	private Boolean[] m_IsInitialized; //Field offset: 0x18
	private Boolean[] m_IsMoveEnd; //Field offset: 0x1C
	private Action m_postInit; //Field offset: 0x20
	private bool m_IsDisp; //Field offset: 0x24
	private bool m_IsRegister; //Field offset: 0x25
	private bool m_IsRegisterButton; //Field offset: 0x26

	public bool CanChgOrientation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsDisp
	{
		 get { } //Length: 11
	}

	protected uGUIScreenRotateLayoutsBase() { }

	public override void AddCanvas(Transform trans) { }

	public override void AddCanvas(Canvas canvas) { }

	public void AdjustSafeArea() { }

	protected abstract uGUIScreenRotateLayoutBase CreateScreenRotateLayout() { }

	public void DeleteTexture() { }

	public override void Deregister() { }

	public override void DeregisterButton() { }

	public override void DeregisterUpdater() { }

	public bool get_CanChgOrientation() { }

	public bool get_IsDisp() { }

	public uGUIScreenRotateLayoutBase GetCurrentUGUILayout() { }

	public uGUIScreenRotateLayoutBase GetUGUILayout(LayoutOrientation orientation) { }

	public override void Init(GameObject root_landscape, GameObject root_portrait, List<Font> font = null, Action postInit = null) { }

	public override void Init(GameObject root, List<TexUVFilePack> texUVFilePackList, List<Font> font = null, Action postInit = null) { }

	public override void Init(GameObject root_landscape, GameObject root_portrait, List<TexUVFilePack> texUVFilePackList, List<Font> font = null, Action postInit = null) { }

	public override void Init(GameObject root, List<Font> font = null, Action postInit = null) { }

	public void InitTexture(List<TexUVFilePack> texUVFilePackList) { }

	public override bool IsPlaying() { }

	private void OnMoveEnd(LayoutOrientation layoutOrientation) { }

	private void OnMoveEndLandscape() { }

	private void OnMoveEndPortrait() { }

	protected override void PostInit() { }

	public override void Register() { }

	public override void Register(bool flg) { }

	public override void RegisterButton() { }

	public override void RegisterButton(bool flg) { }

	public override void RegisterUpdater() { }

	public override void RegisterUpdater(bool flg) { }

	public override void RemoveCanvas(Transform parent = null) { }

	public void set_CanChgOrientation(bool value) { }

	public override void SetAction(int actionType, Action action) { }

	public override void SetAction(int actionType, int index, Action<A> action) { }

	public override void SetAction(int actionType, Action<A> action) { }

	public override void SetAction(int actionType, int index, Action action) { }

	public void SetButtonHit(bool flg) { }

	public override void SetDisp(bool flg) { }

	public override void SetDispRegister(bool flg) { }

	public void SetLayouts(uGUIScreenRotateLayoutsBase layouts) { }

	public void SetParameter(int paramType, string key, string param) { }

	public void SetParameter(int paramType, string key, float param) { }

	public void SetParameter(int paramType, string key, int param) { }

	public void SetParameter(int paramType, int index, int index2, object param) { }

	public void SetParameter(int paramType, int index, int index2, string param) { }

	public void SetParameter(int paramType, int index, int index2, float param) { }

	public void SetParameter(int paramType, int index, int index2, int param) { }

	public void SetParameter(int paramType, int index, object param) { }

	public void SetParameter(int paramType, int index, string param) { }

	public void SetParameter(int paramType, int index, float param) { }

	public void SetParameter(int paramType, int index, int param) { }

	public void SetParameter(int paramType, object param) { }

	public void SetParameter(int paramType, string param) { }

	public void SetParameter(int paramType, float param) { }

	public void SetParameter(int paramType, string key, object param) { }

	public void SetParameter(int paramType, int param) { }

	public override void StartState(int stateNo, Action onAnimEnd = null) { }

	public override void StartStateAnim(int stateNo, Action onAnimEnd = null) { }

	public override bool uGUIInitialize() { }

	public override void uGUIUpdate() { }

}

