namespace XeApp.Game.Character.CharacterListIcon;

public class CharacterCardIllustDisp : DispBase
{
	private enum eLayerId
	{
		SRC_CARD = 0,
		ROOT = 1,
		BASE_NUM = 2,
		TEXT_NUM = 2,
	}

	internal enum UiState
	{
		Init = 0,
		Wait = 0,
		StartProduct = 1,
		Product = 2,
		ProductFinish = 3,
		Finish = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private readonly float ZoomRatioMin; //Field offset: 0x114
	private readonly float ZoomRatioLimit; //Field offset: 0x118
	private readonly float ZoomRatioMax; //Field offset: 0x11C
	private UiState State; //Field offset: 0x120
	private CardIllust m_SrcCard; //Field offset: 0x124
	private Animator m_RootAnimator; //Field offset: 0x128
	private DragAndPinchControl m_DragControl; //Field offset: 0x12C
	private RectTransform RootTrans; //Field offset: 0x130
	private Vector3 InitPosition; //Field offset: 0x134
	private Vector3 InitScale; //Field offset: 0x140
	private Vector2 InitSize; //Field offset: 0x14C
	private Vector3 NowScrollPosition; //Field offset: 0x154
	private float NowZoomRatio; //Field offset: 0x160
	private RectTransform CardTrans; //Field offset: 0x164
	private Vector3 InitCardPosition; //Field offset: 0x168
	private Vector3 InitCardScale; //Field offset: 0x174
	private List<GameObject> m_LetterBoxList; //Field offset: 0x180
	private QUALITY_MODE m_IllustQuality; //Field offset: 0x184
	private bool m_SettingQualityFlag; //Field offset: 0x188
	private bool m_BlurFlag; //Field offset: 0x189

	public bool IsSingleLongTapped
	{
		 get { } //Length: 36
	}

	public bool IsSingleTapped
	{
		 get { } //Length: 36
	}

	public bool IsTouched
	{
		 get { } //Length: 36
	}

	private static CharacterCardIllustDisp() { }

	public CharacterCardIllustDisp() { }

	private void CalcScroll() { }

	private void CallbackInitLayout() { }

	protected void ChangeBlurEffect() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void EnableCard(bool enable) { }

	public void FitToFullScreen() { }

	public bool get_IsSingleLongTapped() { }

	public bool get_IsSingleTapped() { }

	public bool get_IsTouched() { }

	public virtual void InitLoadAfter() { }

	protected virtual void InitUguiOther() { }

	public bool IsFinishProduct() { }

	public bool IsInitCard() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetBlurEffectEnable(bool enable) { }

	public void SetDragControll(bool enable) { }

	public void SetIllustQuality(QUALITY_MODE quality) { }

	private void SetScrollPosRange() { }

	public void StartCardClose() { }

	public void StartCardOpen(int card_id, int use_awk, bool use_premium) { }

	public void StartCardOpen(int card_id, int use_awk, bool use_premium, FIT_MODE fit_mode) { }

	public void StartCardOpenForce(int card_id) { }

	public void StartFadeIn() { }

	protected void StartFadeOut() { }

	public void StartFinish() { }

	public void StartIn() { }

	protected virtual void UpdateDispMain() { }

	private void UpdateInput() { }

}

