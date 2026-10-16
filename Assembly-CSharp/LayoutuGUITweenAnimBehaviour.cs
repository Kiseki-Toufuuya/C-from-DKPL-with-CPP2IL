//Type is in global namespace

public class LayoutuGUITweenAnimBehaviour : MonoBehaviour
{
	[SerializeField]
	private UGUITweenData m_AnimationData; //Field offset: 0x10
	private UGUITweenData m_OldAnimationData; //Field offset: 0x14
	[SerializeField]
	private string m_AnimationDataPath; //Field offset: 0x18
	private bool m_IsInit; //Field offset: 0x1C
	private LayoutUGUITweenAnimation m_layoutUGUITweenAnimation; //Field offset: 0x20

	public UGUITweenData AnimationData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string AnimationDataPath
	{
		 get { } //Length: 11
	}

	public LayoutUGUITweenAnimation LayoutUGUITweenAnimation
	{
		 get { } //Length: 11
	}

	public LayoutuGUITweenAnimBehaviour() { }

	public UGUITweenData get_AnimationData() { }

	public string get_AnimationDataPath() { }

	public LayoutUGUITweenAnimation get_LayoutUGUITweenAnimation() { }

	public void InitAnimationData() { }

	public void InitAnimationStart() { }

	public bool IsPlaying() { }

	public void set_AnimationData(UGUITweenData value) { }

	public void StartAnimation(int targetIdx) { }

	public void StartAnimation(int baseIdx, int targetIdx) { }

	public void StartAnimation(string targetLabel) { }

	public void StartAnimation(string baseLabel, string targetLabel) { }

	public void UpdateAnimation(float dt) { }

}

