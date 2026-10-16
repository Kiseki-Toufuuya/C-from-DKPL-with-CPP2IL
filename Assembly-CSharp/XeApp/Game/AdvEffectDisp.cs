namespace XeApp.Game;

public class AdvEffectDisp : DispBase
{
	private EffectObjectBase m_EffectObj; //Field offset: 0x114
	private float m_WaitTime; //Field offset: 0x118
	private List<Renderer> m_RenderList; //Field offset: 0x11C

	public EffectObjectBase EffObj
	{
		 get { } //Length: 14
	}

	public AdvEffectDisp() { }

	[CompilerGenerated]
	private void <SetEffect>g__ListupChildRender|13_0(Transform parent) { }

	public virtual void Create(LayerBase parent_layer) { }

	public EffectObjectBase get_EffObj() { }

	protected virtual void LateUpdate() { }

	public void Play() { }

	public void SetEffect(EffectObjectBase eff_obj) { }

	public void SetPosition(Vector3 pos) { }

	public void SetSortLayer(eEffectSort sort_type) { }

	public void SetWaitTime(int time) { }

	public void Stop() { }

	protected virtual void UpdateDispMain() { }

}

