namespace Heqet.RG;

public class GameOverUIDisp : DispBase
{
	private const string ANIMATOR_ROOT = "img_ingame_res_gameover"; //Field offset: 0x0
	private const string KAGURA_ANIMATION_NAME = "anim_ingame_gameover_2"; //Field offset: 0x0
	private const string DANMAKU_ANIMATION_NAME = "anim_ingame_gameover_1"; //Field offset: 0x0
	private Animator m_UIAnimator; //Field offset: 0x114
	private bool m_IsKagura; //Field offset: 0x118

	public GameOverUIDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	public bool IsPlayFinish() { }

	protected virtual void LateUpdate() { }

	public void PlayAnimation() { }

	protected virtual void UpdateDispMain() { }

}

