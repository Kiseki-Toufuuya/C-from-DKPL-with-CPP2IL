namespace Heqet.RG;

public class StageClearUIDisp : DispBase
{
	private const string ANIMATOR_ROOT = "set_ingame_clear"; //Field offset: 0x0
	private const string ANIMATION_NAME = "anim_ingame_clear_1"; //Field offset: 0x0
	private const string CAMERA = "GameCamera"; //Field offset: 0x0
	private Animator m_UIAnimator; //Field offset: 0x114
	private AnimationEventEffect m_EventEffect; //Field offset: 0x118

	public StageClearUIDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	public bool IsPlayFinish() { }

	protected virtual void LateUpdate() { }

	public void PlayAnimation() { }

	protected virtual void UpdateDispMain() { }

}

