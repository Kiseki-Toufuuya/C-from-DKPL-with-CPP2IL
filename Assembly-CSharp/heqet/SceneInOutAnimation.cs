namespace Heqet;

public class SceneInOutAnimation
{
	internal enum AnimType
	{
		C_UI = 0,
		C_UI_L = 1,
		C_WIN = 2,
		DAILY_EVENT_CON = 3,
		DAILY_EVENT_CON2 = 4,
		C_UI_T_COM = 5,
		C_UI_B = 6,
		SELECT = 7,
	}

	private readonly String[2] ANIMATION_NAME; //Field offset: 0x8
	private string _startAnimName; //Field offset: 0xC
	private string _endAnimName; //Field offset: 0x10
	private Animator m_RootAnimator; //Field offset: 0x14

	public string CLOSE_ANIM_NAME
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string START_ANIM_NAME
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SceneInOutAnimation() { }

	public string get_CLOSE_ANIM_NAME() { }

	public string get_START_ANIM_NAME() { }

	public void Initialization(Animator animator, AnimType type = 0) { }

	private bool IsEnableAnimator() { }

	public bool IsEndCloseAnim() { }

	public bool IsEndOpenAnim() { }

	public void set_CLOSE_ANIM_NAME(string value) { }

	public void set_START_ANIM_NAME(string value) { }

	public void SetStartAnimPosition() { }

	public void StartCloseAnim(float normalizedTime = 0) { }

	public void StartOpenAnim(float normalizedTime = 0) { }

}

