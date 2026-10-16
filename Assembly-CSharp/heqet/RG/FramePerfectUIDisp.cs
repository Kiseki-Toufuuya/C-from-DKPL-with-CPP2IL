namespace Heqet.RG;

public class FramePerfectUIDisp : DispBase
{
	private const string CAMERA = "GameCamera"; //Field offset: 0x0
	private const float PLAY_TIME = 5; //Field offset: 0x0
	private EffectObjectBase m_Effect; //Field offset: 0x114
	private float m_Timer; //Field offset: 0x118
	private bool m_IsPlay; //Field offset: 0x11C

	public FramePerfectUIDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	public bool IsPlayFinish() { }

	protected virtual void LateUpdate() { }

	public void PlayAnimation() { }

	protected virtual void UpdateDispMain() { }

}

