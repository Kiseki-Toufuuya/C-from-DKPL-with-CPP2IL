namespace Heqet.Kagura;

public class CountDownDisp : DispBase
{
	private const string ANIMATOR = "restart"; //Field offset: 0x0
	private const string ANIMATION_NAME = "count_down"; //Field offset: 0x0
	private Animator m_CountDownAnimator; //Field offset: 0x114
	private AnimationEventEffect m_AnimationEvent; //Field offset: 0x118
	private CriSeSource m_SESource; //Field offset: 0x11C
	private Action m_OverCallback; //Field offset: 0x120
	private bool m_IsPlay; //Field offset: 0x124

	public CountDownDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void RunCountDown(Action overCallback = null) { }

	protected virtual void UpdateDispMain() { }

}

