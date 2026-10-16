namespace Heqet.RG;

public class ResultPointCmbDisp : DispBase
{
	private enum eComboA
	{
		DIGIT_COMBO_A_0 = 0,
		DIGIT_COMBO_A_1 = 1,
		DIGIT_COMBO_A_2 = 2,
	}

	private enum eComboB
	{
		DIGIT_COMBO_B_0 = 0,
		DIGIT_COMBO_B_1 = 1,
		DIGIT_COMBO_B_2 = 2,
		DIGIT_COMBO_B_3 = 3,
	}

	private enum eLayerId
	{
		BEST_COMBO = 0,
		ALL_BRILLIANT = 1,
		FRAME_PERFECT = 2,
		FULL_COMBO = 3,
		COMBO_A = 4,
		COMBO_B = 5,
		ACCURACY_BASE = 6,
		ACCURACY = 7,
		BEST_ACCURACY = 8,
	}

	private enum eTextId
	{
		TEXT_ACCURACY = 0,
		TEXT_DIFFERENCE_COMBO = 1,
		TEXT_DIFFERENCE_ACCURACY = 2,
	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_TextIdList; //Field offset: 0x4
	private readonly string ComboAPath; //Field offset: 0x114
	private readonly string ComboBPath; //Field offset: 0x118
	private Animator m_RootAnimator; //Field offset: 0x11C
	private Animator m_BestComboAnim; //Field offset: 0x120
	private Animator m_BestAccuracyAnim; //Field offset: 0x124
	private List<AtlasImage> m_ComboAImgs; //Field offset: 0x128
	private List<AtlasImage> m_ComboBImgs; //Field offset: 0x12C
	private bool m_enableTapAccuracy; //Field offset: 0x130
	private UiState WindowState; //Field offset: 0x134

	private static ResultPointCmbDisp() { }

	public ResultPointCmbDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void GenerateCombo(int num) { }

	private void GenerateComboA(int num) { }

	private void GenerateComboB(int num) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void StartCloseAnimation() { }

	public void StartNewAccuracyEffect(float _before, float _best) { }

	public void StartNewComboEffect(int _before, int _best) { }

	public void StartOpenAnimation(float time = 0) { }

	public void UpdateAccuracyrate(float _accuracy) { }

	public void UpdateComboState(bool _brilliant, bool _perfect, bool _fullcombo) { }

	protected virtual void UpdateDispMain() { }

}

