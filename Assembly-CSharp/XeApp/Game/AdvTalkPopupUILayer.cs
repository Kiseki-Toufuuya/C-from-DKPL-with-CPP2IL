namespace XeApp.Game;

public class AdvTalkPopupUILayer : LayerBase
{
	private const float DefaultTalkPopupScale = 1.5; //Field offset: 0x0
	private eCanvas PopupUICanvasId; //Field offset: 0x58
	private Vector3 TalkPopupOffsetPos; //Field offset: 0x5C
	private float TalkPopupDispSpeed; //Field offset: 0x68
	private float TalkPopupDispTime; //Field offset: 0x6C
	private TalkPopupUI[] TalkPopupUIList; //Field offset: 0x70
	private List<TalkPopupUI> FreeUIList; //Field offset: 0x74
	private Dictionary<AdvLive2DModel, TalkPopupUI> CharaTalkUIList; //Field offset: 0x78
	private TalkPopupUI CurrentTalkPopup; //Field offset: 0x7C
	private RectTransform CachedCanvasRectTransform; //Field offset: 0x80
	private Camera CachedCanvasCamera; //Field offset: 0x84
	private bool IsLoadTalkPopupUIAsseBundle; //Field offset: 0x88
	private bool IsSkipConfirmFg; //Field offset: 0x89

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public AdvTalkPopupUILayer() { }

	[CompilerGenerated]
	private void <InitAll>b__20_0(DispBase disp) { }

	private void AddSDCharaPopuiUI(AdvLive2DModel chara_model) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsFinishTalkPopup() { }

	protected virtual void LateUpdate(bool is_active) { }

	private Vector3 MakeTalkUIPos(Camera a_camera, int screen_pos_x, int screen_pos_y) { }

	private Vector3 MakeTalkUIPos(Camera a_camera, Transform a_target) { }

	public void OutSDTalkMessage(AdvLive2DModel target_chara) { }

	public void OutSDTalkMessageAll() { }

	public void OutTalkPopup() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetSDTalkMessage(AdvLive2DModel target_chara, int type, int direction, string text) { }

	public void SetSkipConfirmFg(bool enable) { }

	public void SetTalkPopup(int type, int direction, int pos_x, int pos_y, string text) { }

	public void SkipTalkPopup() { }

	protected virtual void Update(bool is_active) { }

	private void UpdateTalkPopup() { }

}

