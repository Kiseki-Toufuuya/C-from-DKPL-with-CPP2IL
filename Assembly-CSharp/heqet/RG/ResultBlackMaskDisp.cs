namespace Heqet.RG;

public class ResultBlackMaskDisp : DispBase
{
	public eCanvas m_canvas; //Field offset: 0x114
	private Animator m_anim; //Field offset: 0x118

	public Animator Anim
	{
		 get { } //Length: 14
	}

	public ResultBlackMaskDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void EndAnim() { }

	public Animator get_Anim() { }

	protected virtual void InitUguiOther() { }

	public bool IsEnd() { }

	protected virtual void LateUpdate() { }

	public void StartAnim() { }

	protected virtual void UpdateDispMain() { }

}

